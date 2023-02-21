namespace VMBoxSnapshot
{
    partial class App
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.TimePick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PathTxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.notIco = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideCMB = new System.Windows.Forms.ToolStripMenuItem();
            this.createCMB = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSMB = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.ListVM = new System.Windows.Forms.ListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.OnItervalRb = new System.Windows.Forms.RadioButton();
            this.OnHourRb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CreatedTodayCh = new System.Windows.Forms.CheckBox();
            this.ContMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TimePick
            // 
            this.TimePick.CustomFormat = "HH:mm";
            this.TimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePick.Location = new System.Drawing.Point(212, 77);
            this.TimePick.Name = "TimePick";
            this.TimePick.ShowUpDown = true;
            this.TimePick.Size = new System.Drawing.Size(82, 20);
            this.TimePick.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snapshoot time";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(229, 149);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            // 
            // PathTxBox
            // 
            this.PathTxBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PathTxBox.Location = new System.Drawing.Point(11, 123);
            this.PathTxBox.Name = "PathTxBox";
            this.PathTxBox.Size = new System.Drawing.Size(292, 20);
            this.PathTxBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "VM Box root folder:";
            // 
            // notIco
            // 
            this.notIco.ContextMenuStrip = this.ContMenu;
            this.notIco.Icon = ((System.Drawing.Icon)(resources.GetObject("notIco.Icon")));
            this.notIco.Text = "VMSnapShot";
            this.notIco.Visible = true;
            // 
            // ContMenu
            // 
            this.ContMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideCMB,
            this.createCMB,
            this.exitSMB});
            this.ContMenu.Name = "ContMenu";
            this.ContMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContMenu.ShowImageMargin = false;
            this.ContMenu.ShowItemToolTips = false;
            this.ContMenu.Size = new System.Drawing.Size(156, 104);
            // 
            // showHideCMB
            // 
            this.showHideCMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showHideCMB.ForeColor = System.Drawing.Color.White;
            this.showHideCMB.Name = "showHideCMB";
            this.showHideCMB.Size = new System.Drawing.Size(155, 26);
            this.showHideCMB.Text = "Hide/Show";
            // 
            // createCMB
            // 
            this.createCMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createCMB.ForeColor = System.Drawing.Color.White;
            this.createCMB.Name = "createCMB";
            this.createCMB.Size = new System.Drawing.Size(155, 26);
            this.createCMB.Text = "Create Now";
            // 
            // exitSMB
            // 
            this.exitSMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitSMB.ForeColor = System.Drawing.Color.White;
            this.exitSMB.Name = "exitSMB";
            this.exitSMB.Size = new System.Drawing.Size(155, 26);
            this.exitSMB.Text = "Exit";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(229, 311);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(75, 23);
            this.CreateBtn.TabIndex = 6;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // ListVM
            // 
            this.ListVM.FormattingEnabled = true;
            this.ListVM.Location = new System.Drawing.Point(9, 172);
            this.ListVM.Name = "ListVM";
            this.ListVM.Size = new System.Drawing.Size(295, 134);
            this.ListVM.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(9, 311);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // OnItervalRb
            // 
            this.OnItervalRb.AutoSize = true;
            this.OnItervalRb.Location = new System.Drawing.Point(212, 45);
            this.OnItervalRb.Name = "OnItervalRb";
            this.OnItervalRb.Size = new System.Drawing.Size(89, 17);
            this.OnItervalRb.TabIndex = 9;
            this.OnItervalRb.Text = "In the interval";
            this.OnItervalRb.UseVisualStyleBackColor = true;
            // 
            // OnHourRb
            // 
            this.OnHourRb.AutoSize = true;
            this.OnHourRb.Checked = true;
            this.OnHourRb.Location = new System.Drawing.Point(75, 45);
            this.OnHourRb.Name = "OnHourRb";
            this.OnHourRb.Size = new System.Drawing.Size(99, 17);
            this.OnHourRb.TabIndex = 10;
            this.OnHourRb.TabStop = true;
            this.OnHourRb.Text = "On a daily basis";
            this.OnHourRb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Update";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(9, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 33);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(9, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 36);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(9, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(295, 67);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // CreatedTodayCh
            // 
            this.CreatedTodayCh.AutoSize = true;
            this.CreatedTodayCh.Location = new System.Drawing.Point(114, 315);
            this.CreatedTodayCh.Name = "CreatedTodayCh";
            this.CreatedTodayCh.Size = new System.Drawing.Size(92, 17);
            this.CreatedTodayCh.TabIndex = 15;
            this.CreatedTodayCh.Text = "Created today";
            this.CreatedTodayCh.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(316, 346);
            this.Controls.Add(this.CreatedTodayCh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OnHourRb);
            this.Controls.Add(this.OnItervalRb);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ListVM);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathTxBox);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimePick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic VM SnapShoot";
            this.ContMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TimePick;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox PathTxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notIco;
        private System.Windows.Forms.ContextMenuStrip ContMenu;
        private System.Windows.Forms.ToolStripMenuItem showHideCMB;
        private System.Windows.Forms.ToolStripMenuItem exitSMB;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.ListBox ListVM;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.RadioButton OnItervalRb;
        private System.Windows.Forms.RadioButton OnHourRb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem createCMB;
        private System.Windows.Forms.CheckBox CreatedTodayCh;
    }
}

