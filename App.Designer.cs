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
            this.SnapshotTimeLb = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.PathTxBox = new System.Windows.Forms.TextBox();
            this.RootFolderLb = new System.Windows.Forms.Label();
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
            this.UpdateLb = new System.Windows.Forms.Label();
            this.UpdateFr = new System.Windows.Forms.PictureBox();
            this.SnapShootFr = new System.Windows.Forms.PictureBox();
            this.RootFolderFr = new System.Windows.Forms.PictureBox();
            this.CreatedTodayCh = new System.Windows.Forms.CheckBox();
            this.ContMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnapShootFr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootFolderFr)).BeginInit();
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
            // SnapshotTimeLb
            // 
            this.SnapshotTimeLb.AutoSize = true;
            this.SnapshotTimeLb.ForeColor = System.Drawing.Color.Gray;
            this.SnapshotTimeLb.Location = new System.Drawing.Point(13, 80);
            this.SnapshotTimeLb.Name = "SnapshotTimeLb";
            this.SnapshotTimeLb.Size = new System.Drawing.Size(80, 13);
            this.SnapshotTimeLb.TabIndex = 1;
            this.SnapshotTimeLb.Text = "Snapshoot time";
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
            // RootFolderLb
            // 
            this.RootFolderLb.AutoSize = true;
            this.RootFolderLb.ForeColor = System.Drawing.Color.Gray;
            this.RootFolderLb.Location = new System.Drawing.Point(13, 107);
            this.RootFolderLb.Name = "RootFolderLb";
            this.RootFolderLb.Size = new System.Drawing.Size(97, 13);
            this.RootFolderLb.TabIndex = 4;
            this.RootFolderLb.Text = "VM Box root folder:";
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
            this.ContMenu.Size = new System.Drawing.Size(135, 82);
            // 
            // showHideCMB
            // 
            this.showHideCMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showHideCMB.ForeColor = System.Drawing.Color.White;
            this.showHideCMB.Name = "showHideCMB";
            this.showHideCMB.Size = new System.Drawing.Size(134, 26);
            this.showHideCMB.Text = "Hide/Show";
            // 
            // createCMB
            // 
            this.createCMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createCMB.ForeColor = System.Drawing.Color.White;
            this.createCMB.Name = "createCMB";
            this.createCMB.Size = new System.Drawing.Size(134, 26);
            this.createCMB.Text = "Create Now";
            // 
            // exitSMB
            // 
            this.exitSMB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitSMB.ForeColor = System.Drawing.Color.White;
            this.exitSMB.Name = "exitSMB";
            this.exitSMB.Size = new System.Drawing.Size(134, 26);
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
            // UpdateLb
            // 
            this.UpdateLb.AutoSize = true;
            this.UpdateLb.ForeColor = System.Drawing.Color.Gray;
            this.UpdateLb.Location = new System.Drawing.Point(13, 46);
            this.UpdateLb.Name = "UpdateLb";
            this.UpdateLb.Size = new System.Drawing.Size(42, 13);
            this.UpdateLb.TabIndex = 11;
            this.UpdateLb.Text = "Update";
            // 
            // UpdateFr
            // 
            this.UpdateFr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpdateFr.Location = new System.Drawing.Point(9, 34);
            this.UpdateFr.Name = "UpdateFr";
            this.UpdateFr.Size = new System.Drawing.Size(295, 33);
            this.UpdateFr.TabIndex = 12;
            this.UpdateFr.TabStop = false;
            // 
            // SnapShootFr
            // 
            this.SnapShootFr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SnapShootFr.Location = new System.Drawing.Point(9, 68);
            this.SnapShootFr.Name = "SnapShootFr";
            this.SnapShootFr.Size = new System.Drawing.Size(295, 36);
            this.SnapShootFr.TabIndex = 13;
            this.SnapShootFr.TabStop = false;
            // 
            // RootFolderFr
            // 
            this.RootFolderFr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RootFolderFr.Location = new System.Drawing.Point(9, 105);
            this.RootFolderFr.Name = "RootFolderFr";
            this.RootFolderFr.Size = new System.Drawing.Size(295, 67);
            this.RootFolderFr.TabIndex = 14;
            this.RootFolderFr.TabStop = false;
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
            this.Controls.Add(this.UpdateLb);
            this.Controls.Add(this.OnHourRb);
            this.Controls.Add(this.OnItervalRb);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ListVM);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.RootFolderLb);
            this.Controls.Add(this.PathTxBox);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.SnapshotTimeLb);
            this.Controls.Add(this.TimePick);
            this.Controls.Add(this.UpdateFr);
            this.Controls.Add(this.SnapShootFr);
            this.Controls.Add(this.RootFolderFr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic VM SnapShoot";
            this.ContMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnapShootFr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RootFolderFr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SnapshotTimeLb;
        private System.Windows.Forms.DateTimePicker TimePick;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox PathTxBox;
        private System.Windows.Forms.Label RootFolderLb;
        private System.Windows.Forms.NotifyIcon notIco;
        private System.Windows.Forms.ContextMenuStrip ContMenu;
        private System.Windows.Forms.ToolStripMenuItem showHideCMB;
        private System.Windows.Forms.ToolStripMenuItem exitSMB;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.ListBox ListVM;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.RadioButton OnItervalRb;
        private System.Windows.Forms.RadioButton OnHourRb;
        private System.Windows.Forms.Label UpdateLb;
        private System.Windows.Forms.PictureBox UpdateFr; //Frame around 
        private System.Windows.Forms.PictureBox SnapShootFr; //Frame around 
        private System.Windows.Forms.PictureBox RootFolderFr; //Frame around 
        private System.Windows.Forms.ToolStripMenuItem createCMB;
        private System.Windows.Forms.CheckBox CreatedTodayCh;
    }
}

