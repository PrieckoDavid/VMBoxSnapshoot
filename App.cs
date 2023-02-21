using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Tmr = System.Windows.Forms.Timer;

namespace VMBoxSnapshot
{
    public delegate void CommandVMs(string data); 
    public partial class App : Form
    {
        public event CommandVMs Proc;

        public int TimerInterval => tm.Interval;
        Tmr tm = new Tmr();

        #region Date and Time proportis

        DateTime timeInDay
        {
            get => TimePick.Value;
            set => TimePick.Value = value;
        }
        string TimeInDay
        {
            get => timeInDay.ToShortTimeString();
            set
            {
                DateTime _tm = (DateTime.TryParse(value, out _tm)) ? _tm : DateTime.Now;

                timeInDay = new DateTime(year: DateTime.Now.Year,
                                         month: DateTime.Now.Month,
                                         day: DateTime.Now.Day,
                                         hour: _tm.Hour,
                                         minute: _tm.Minute,
                                         second: 0);
            }
        }

        DateTime TimeLastUpdate => DateTime.Parse(LastUpdate);
        TimeSpan OverTheLastUpdate => (DateTime.Now -  new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, TimeLastUpdate.Hour, TimeLastUpdate.Minute,0));
        TimeSpan ElapsedTIme => (DateTime.Now - timeInDay);

        string lastUpdate;
        string LastUpdate
        {
            get => lastUpdate ?? DateTime.Now.ToString();
            set
            {
                DateTime _dt;
                lastUpdate = (DateTime.TryParse(value, out _dt)) ? _dt.ToString() : DateTime.Now.ToString();
            }
        }

        #endregion Date and Time proportis

        string path
        {
            get => PathTxBox.Text;
            set => PathTxBox.Text = value;
        }
        string Path
        {
            get => Directory.Exists(path) ? path : "";
            set => path = VMBoxFolderExisted(folderPath: value,
                                             file: "VBoxManage.exe",
                                             path => ReadProcess(path,"list vms",id:1))
                                             ? value : "";
        }
        string selectedVM;
        byte mode
        {
            get
            {
                if (OnHourRb.Checked && !OnItervalRb.Checked) return 1;
                else if (!OnHourRb.Checked && OnItervalRb.Checked) return 2;
                else return 0;
            }
            set
            {
                switch (value)
                {
                    case 1:
                        OnHourRb.Checked = true;
                        OnItervalRb.Checked = false;
                        break;
                    case 2:
                        OnHourRb.Checked = false;
                        OnItervalRb.Checked = true;
                        break;
                    default:
                        OnHourRb.Checked = false;
                        OnItervalRb.Checked = false;
                        break;
                }
            }
        }
        readonly string confPath = @".\config.ini";
        bool readyToAutoSnapShot = false;
        public App()
        {
            InitializeComponent();
            /*Load all events*/
            LoadNoNameEvents();
        }
        /// <summary>
        /// Loading all events
        /// </summary>
        void LoadNoNameEvents()
        {
            /*After show refresh form*/
            this.Shown += (o, e) => { Refresh(); };
            /*Browse button click event*/
            BrowseBtn.Click += (o, e) => Path = FolderPathBrowse(@"C:\Program Files\Oracle\VirtualBox");
            /*Context menu exit click event*/
            exitSMB.Click += (o, e) => this.Close();
            /*Context menu Hide/Show click event*/
            showHideCMB.Click += ShowHide;
            notIco.DoubleClick += ShowHide;
            /*Save button click event*/
            SaveBtn.Click += (o, e) => SaveConfig(confPath);
            /*Create Snapshoot buttons*/
            CreateBtn.Click += (o,e) => CreateSnapShot();
            createCMB.Click += (o,e) => CreateSnapShot();
            /*List VM selected event change used VM*/
            ListVM.SelectedValueChanged += (o, e) => selectedVM = (ListVM.SelectedIndex >= 0) ? ListVM.Items[ListVM.SelectedIndex].ToString() : null;
            //proc += (data) => ThreadDone(data);

        }

        /// <summary>
        /// Hide Close button
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | 0x200;
                return myCp;
            }
        }
        public override void Refresh()
        {
            LoadConfig();
            base.Refresh();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (WindowState == FormWindowState.Minimized) foreach (Form item in Application.OpenForms) item.Hide();
            else foreach (Form item in Application.OpenForms) item.Show();
        }
        void ShowHide(object o, EventArgs e)
        {
            if (this.Visible) foreach (Form item in Application.OpenForms) item.Hide();
            else
            {
                foreach (Form item in Application.OpenForms) item.Show();
                WindowState = FormWindowState.Normal;
            }
                
        }
        void TimerUpdate(object o,EventArgs e)
        {
            TimeOutUpdater();
        }
        void TimeOutUpdater()
        {
            var _df = (new TimeSpan(hours: timeInDay.Hour, minutes: timeInDay.Minute, 0) - OverTheLastUpdate);

            /*Elapsed time message*/
            //string _elMessage = $"Time elapsed before \"{ElapsedTIme.Hours} hours :" +
            //                                         $" {ElapsedTIme.Minutes} min :" +
            //                                         $" {ElapsedTIme.Seconds} sec\"";
            /*Time count down message*/
            string _cdMessage = string.Format("{0}: {1} hour {2} min {3} sec",(_df.Ticks < 0)?
                "Time expires in" : "Time passed before", _df.Hours,_df.Minutes,_df.Seconds);

            switch (mode)
            {
                /*Daily update */
                case 1:
                    if (!CreatedTodayCh.Checked)
                        if ((DateTime.Compare(DateTime.Now, TimePick.Value) >= 0)) 
                        {
                            CreatedTodayCh.Checked = true;
                            var _res = (MessageBox.Show("Time to make SnapShot! Do you want to make Snapshot?", "Alarm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) ) ;
                            if (_res == DialogResult.Yes)
                            {
                                CreateSnapShot();
                                SaveConfig(confPath);
                            }
                            else if (_res == DialogResult.Cancel) CreatedTodayCh.Checked = false;
                        }
                    break;
                /*Interval update*/
                case 2:
                    notIco.ShowBalloonTip(100, "Time update", _cdMessage, ToolTipIcon.Info);
                    break;
            }
        }

        bool VMBoxFolderExisted(string folderPath, string file)
        {
            if (Directory.Exists(folderPath))
                if (File.Exists(string.Format(@"{0}\{1}", folderPath, file))) 
                    return true;
                else return false;
            else return false;
        }
        bool VMBoxFolderExisted(string folderPath,string file,Action<string> existed)
        {
            var _bl = (VMBoxFolderExisted(folderPath, file));
            if (_bl) existed((string.Format(@"{0}\{1}", folderPath, file)));
            return _bl;
        }
        public string FolderPathBrowse(string defaultPath = @"C:\")
        {
            var _path = defaultPath;
            using(var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = defaultPath;
                fbd.Description = "Select VMBox root folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                   _path = fbd.SelectedPath;
            }
            return _path;
        }
        void FilterVMsName(string output)
        {
            var _t = output.Split('\"').ToList(); //separate line
            _t.RemoveAll(x => string.IsNullOrEmpty(x) || x.Contains("\r")); //remove empty and uid

            ListVM.Items.Clear();

            foreach (var item in _t)
                ListVM.Items.Add(item);
        }
        public void ReadProcess(string path,string args,uint id = 0)
        {
            string _list = null;

            /*-------------------------------------*/
            /*Create new thread for reading process*/
            /*-------------------------------------*/

            #region Another tread

            new Thread(() => {
                using (Process pr = new Process())
                {
                    pr.StartInfo.FileName = path;
                    pr.StartInfo.Arguments = args;
                    pr.StartInfo.UseShellExecute = false;
                    pr.StartInfo.RedirectStandardOutput = true;
                    pr.StartInfo.CreateNoWindow = true;

                    pr.Start();

                    _list = pr.StandardOutput.ReadToEnd();
                    pr.WaitForExit();

                    /*        Create delegate for thread.                   */
                    /*        For a component that runs in another thread.  */

                    if (id == 1)
                    {
                        CommandVMs del = new CommandVMs(FilterVMsName);
                        ListVM.BeginInvoke(del, _list);
                    }
                    else notIco.ShowBalloonTip(100, "SnapShoot was successfully created!", _list, ToolTipIcon.Info);
                }
            }).Start();

            #endregion Another tread
        }
        #region Config file

        void SaveConfig(string path)
        {
            if (File.Exists(confPath))
            {
                if (ListVM.Items.Count > 0 && selectedVM != null)
                {
                    File.WriteAllLines(path, new string[] { Path, DateTime.Now.ToString(), mode.ToString(), selectedVM,TimeInDay });
                    notIco.ShowBalloonTip(100, "Saved", "Configuration file successfully saved!", ToolTipIcon.Info);

                    Refresh();
                }
                else MessageBox.Show("First select the VM root folder, after that select VM name. Then repeat the action.", "VM data not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                /*Creating config file if is not existed*/
                using (File.Create(path))
                notIco.ShowBalloonTip(100, "Config file was created", "Configuration file does not exist, but now was created!", ToolTipIcon.Info);
                SaveConfig(path);
            }
        }
        void LoadConfig()
        {
            if (File.Exists(confPath))
            {
                var _data = File.ReadAllLines(confPath);
                if (_data != null && _data.Length == 5)
                {
                    try
                    {
                        Path = _data[0];
                        LastUpdate = _data[1];
                        mode = byte.Parse(_data[2]);
                        selectedVM = _data[3];
                        TimeInDay = _data[4];

                        OkIsAll();
                    }
                    catch(Exception ex)
                    {
                        /*Delete wrong configuration file*/
                        if (MessageBox.Show($"The configuration file is corrupted. Do you wish to remove it? \n\n Exception :{ex.Message}",
                                            "Reading config file failed",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
                                                 File.Delete(path);
                    }
                }
                /*Reading failed message*/
                else notIco.ShowBalloonTip(100, "Reading config file failed", "The configuration file is corrupted or data has been deleted!", ToolTipIcon.Error);
            }
            else notIco.ShowBalloonTip(100, "Application don't was configured!", "For functionality, it is necessary to set everything and save the configuration.", ToolTipIcon.Info);
        }

        #endregion Config file
        /// <summary>
        /// Function create snapshot
        /// </summary>
        void CreateSnapShot()
        {
            if (File.Exists(confPath))
            {
                if(readyToAutoSnapShot)
                {
                    ReadProcess(string.Format(@"{0}\VBoxManage.exe",Path), $"snapshot \"{selectedVM}\" take " +
                                              $"\"{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day} " +
                                              $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}\"");
                    SaveConfig(Path);
                }
            }
        }
        void OkIsAll()
        {
            tm.Tick += TimerUpdate;
            tm.Interval = 10000;
            tm.Start();

            readyToAutoSnapShot = true;
            foreach (Form item in Application.OpenForms) item.Hide();
        }
    }
}
