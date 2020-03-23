namespace AngelControl
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelBorder3 = new System.Windows.Forms.Panel();
            this.panelMenuRfid = new System.Windows.Forms.Panel();
            this.pictureBoxMenuRfid = new System.Windows.Forms.PictureBox();
            this.panelBorder2 = new System.Windows.Forms.Panel();
            this.panelMenuReg = new System.Windows.Forms.Panel();
            this.pictureBoxMenuReg = new System.Windows.Forms.PictureBox();
            this.panelBorder1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.pictureBoxRfid = new System.Windows.Forms.PictureBox();
            this.pictureBoxDatabase = new System.Windows.Forms.PictureBox();
            this.pictureBoxSsh = new System.Windows.Forms.PictureBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.contextMenuStripSshOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSshChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSshClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipSsh = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDatabase = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripDatabaseOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipRfid = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripRfidOpen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRfidChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRfidClose = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainMenu.SuspendLayout();
            this.panelMenuRfid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuRfid)).BeginInit();
            this.panelMenuReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuReg)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRfid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSsh)).BeginInit();
            this.contextMenuStripSshOpen.SuspendLayout();
            this.contextMenuStripDatabaseOpen.SuspendLayout();
            this.contextMenuStripRfidOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 40);
            this.panelTop.TabIndex = 2;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.panelMainMenu.Controls.Add(this.panelBorder3);
            this.panelMainMenu.Controls.Add(this.panelMenuRfid);
            this.panelMainMenu.Controls.Add(this.panelBorder2);
            this.panelMainMenu.Controls.Add(this.panelMenuReg);
            this.panelMainMenu.Controls.Add(this.panelBorder1);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(80, 410);
            this.panelMainMenu.TabIndex = 3;
            // 
            // panelBorder3
            // 
            this.panelBorder3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panelBorder3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder3.Location = new System.Drawing.Point(0, 162);
            this.panelBorder3.Margin = new System.Windows.Forms.Padding(0);
            this.panelBorder3.Name = "panelBorder3";
            this.panelBorder3.Size = new System.Drawing.Size(80, 1);
            this.panelBorder3.TabIndex = 4;
            // 
            // panelMenuRfid
            // 
            this.panelMenuRfid.Controls.Add(this.pictureBoxMenuRfid);
            this.panelMenuRfid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuRfid.Location = new System.Drawing.Point(0, 82);
            this.panelMenuRfid.Name = "panelMenuRfid";
            this.panelMenuRfid.Size = new System.Drawing.Size(80, 80);
            this.panelMenuRfid.TabIndex = 3;
            // 
            // pictureBoxMenuRfid
            // 
            this.pictureBoxMenuRfid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuRfid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMenuRfid.Image = global::AngelControl.Properties.Resources.MenuRfid;
            this.pictureBoxMenuRfid.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuRfid.Name = "pictureBoxMenuRfid";
            this.pictureBoxMenuRfid.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxMenuRfid.TabIndex = 1;
            this.pictureBoxMenuRfid.TabStop = false;
            this.pictureBoxMenuRfid.Click += new System.EventHandler(this.pictureBoxMenuRfid_Click);
            this.pictureBoxMenuRfid.MouseEnter += new System.EventHandler(this.pictureBoxMenuRfid_MouseEnter);
            this.pictureBoxMenuRfid.MouseLeave += new System.EventHandler(this.pictureBoxMenuRfid_MouseLeave);
            // 
            // panelBorder2
            // 
            this.panelBorder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panelBorder2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder2.Location = new System.Drawing.Point(0, 81);
            this.panelBorder2.Margin = new System.Windows.Forms.Padding(0);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(80, 1);
            this.panelBorder2.TabIndex = 2;
            // 
            // panelMenuReg
            // 
            this.panelMenuReg.Controls.Add(this.pictureBoxMenuReg);
            this.panelMenuReg.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuReg.Location = new System.Drawing.Point(0, 1);
            this.panelMenuReg.Name = "panelMenuReg";
            this.panelMenuReg.Size = new System.Drawing.Size(80, 80);
            this.panelMenuReg.TabIndex = 1;
            // 
            // pictureBoxMenuReg
            // 
            this.pictureBoxMenuReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenuReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMenuReg.Image = global::AngelControl.Properties.Resources.MenuProfile;
            this.pictureBoxMenuReg.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMenuReg.Name = "pictureBoxMenuReg";
            this.pictureBoxMenuReg.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxMenuReg.TabIndex = 0;
            this.pictureBoxMenuReg.TabStop = false;
            this.pictureBoxMenuReg.Click += new System.EventHandler(this.pictureBoxMenuReg_Click);
            this.pictureBoxMenuReg.MouseEnter += new System.EventHandler(this.pictureBoxMenuReg_MouseEnter);
            this.pictureBoxMenuReg.MouseLeave += new System.EventHandler(this.pictureBoxMenuReg_MouseLeave);
            // 
            // panelBorder1
            // 
            this.panelBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.panelBorder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorder1.Location = new System.Drawing.Point(0, 0);
            this.panelBorder1.Margin = new System.Windows.Forms.Padding(0);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(80, 1);
            this.panelBorder1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(80, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(720, 410);
            this.panelMain.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(720, 380);
            this.panelContent.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelBottom.Controls.Add(this.pictureBoxRfid);
            this.panelBottom.Controls.Add(this.pictureBoxDatabase);
            this.panelBottom.Controls.Add(this.pictureBoxSsh);
            this.panelBottom.Controls.Add(this.labelLog);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 380);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(720, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // pictureBoxRfid
            // 
            this.pictureBoxRfid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRfid.Image = global::AngelControl.Properties.Resources.rfid_close;
            this.pictureBoxRfid.Location = new System.Drawing.Point(104, 7);
            this.pictureBoxRfid.Name = "pictureBoxRfid";
            this.pictureBoxRfid.Size = new System.Drawing.Size(23, 17);
            this.pictureBoxRfid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRfid.TabIndex = 3;
            this.pictureBoxRfid.TabStop = false;
            this.pictureBoxRfid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRfid_MouseDown);
            // 
            // pictureBoxDatabase
            // 
            this.pictureBoxDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDatabase.Image = global::AngelControl.Properties.Resources.database_error_icon;
            this.pictureBoxDatabase.Location = new System.Drawing.Point(71, 6);
            this.pictureBoxDatabase.Name = "pictureBoxDatabase";
            this.pictureBoxDatabase.Size = new System.Drawing.Size(25, 20);
            this.pictureBoxDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDatabase.TabIndex = 2;
            this.pictureBoxDatabase.TabStop = false;
            this.pictureBoxDatabase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDatabase_MouseDown);
            // 
            // pictureBoxSsh
            // 
            this.pictureBoxSsh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSsh.Image = global::AngelControl.Properties.Resources.ssh_icon_close;
            this.pictureBoxSsh.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxSsh.Name = "pictureBoxSsh";
            this.pictureBoxSsh.Size = new System.Drawing.Size(48, 20);
            this.pictureBoxSsh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSsh.TabIndex = 1;
            this.pictureBoxSsh.TabStop = false;
            this.pictureBoxSsh.Tag = "";
            this.pictureBoxSsh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxSsh_MouseDown);
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLog.ForeColor = System.Drawing.Color.DarkGray;
            this.labelLog.Location = new System.Drawing.Point(7, 10);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(0, 15);
            this.labelLog.TabIndex = 0;
            // 
            // contextMenuStripSshOpen
            // 
            this.contextMenuStripSshOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSshChange,
            this.toolStripMenuItemSshClose});
            this.contextMenuStripSshOpen.Name = "contextMenuStripSsh";
            this.contextMenuStripSshOpen.ShowImageMargin = false;
            this.contextMenuStripSshOpen.Size = new System.Drawing.Size(159, 48);
            // 
            // toolStripMenuItemSshChange
            // 
            this.toolStripMenuItemSshChange.Name = "toolStripMenuItemSshChange";
            this.toolStripMenuItemSshChange.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemSshChange.Text = "Изменить туннель";
            this.toolStripMenuItemSshChange.Click += new System.EventHandler(this.toolStripMenuItemSshChange_Click);
            // 
            // toolStripMenuItemSshClose
            // 
            this.toolStripMenuItemSshClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemSshClose.Name = "toolStripMenuItemSshClose";
            this.toolStripMenuItemSshClose.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItemSshClose.Text = "Отключить туннель";
            this.toolStripMenuItemSshClose.Click += new System.EventHandler(this.toolStripMenuItemSshClose_Click);
            // 
            // toolTipSsh
            // 
            this.toolTipSsh.ShowAlways = true;
            this.toolTipSsh.ToolTipTitle = "SSH";
            // 
            // toolTipDatabase
            // 
            this.toolTipDatabase.ShowAlways = true;
            this.toolTipDatabase.ToolTipTitle = "Database";
            // 
            // contextMenuStripDatabaseOpen
            // 
            this.contextMenuStripDatabaseOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSettings});
            this.contextMenuStripDatabaseOpen.Name = "contextMenuStripSsh";
            this.contextMenuStripDatabaseOpen.ShowImageMargin = false;
            this.contextMenuStripDatabaseOpen.Size = new System.Drawing.Size(318, 26);
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(317, 22);
            this.toolStripMenuItemSettings.Text = "Изменить настройки подключения базы данных";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.toolStripMenuItemSettings_Click);
            // 
            // toolTipRfid
            // 
            this.toolTipRfid.ShowAlways = true;
            this.toolTipRfid.ToolTipTitle = "RFID";
            // 
            // contextMenuStripRfidOpen
            // 
            this.contextMenuStripRfidOpen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRfidChange,
            this.toolStripMenuItemRfidClose});
            this.contextMenuStripRfidOpen.Name = "contextMenuStripSsh";
            this.contextMenuStripRfidOpen.ShowImageMargin = false;
            this.contextMenuStripRfidOpen.Size = new System.Drawing.Size(212, 48);
            // 
            // toolStripMenuItemRfidChange
            // 
            this.toolStripMenuItemRfidChange.Name = "toolStripMenuItemRfidChange";
            this.toolStripMenuItemRfidChange.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemRfidChange.Text = "Изменить RFID подключение";
            this.toolStripMenuItemRfidChange.Click += new System.EventHandler(this.toolStripMenuItemRfidChange_Click);
            // 
            // toolStripMenuItemRfidClose
            // 
            this.toolStripMenuItemRfidClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItemRfidClose.Name = "toolStripMenuItemRfidClose";
            this.toolStripMenuItemRfidClose.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItemRfidClose.Text = "Отключить RFID считыватель";
            this.toolStripMenuItemRfidClose.Click += new System.EventHandler(this.toolStripMenuItemCloseRfid_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроль учений ПСО «Ангел»";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMenuRfid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuRfid)).EndInit();
            this.panelMenuReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuReg)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRfid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSsh)).EndInit();
            this.contextMenuStripSshOpen.ResumeLayout(false);
            this.contextMenuStripDatabaseOpen.ResumeLayout(false);
            this.contextMenuStripRfidOpen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Panel panelBorder1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelBorder3;
        private System.Windows.Forms.Panel panelMenuRfid;
        private System.Windows.Forms.Panel panelBorder2;
        private System.Windows.Forms.Panel panelMenuReg;
        private System.Windows.Forms.PictureBox pictureBoxMenuRfid;
        private System.Windows.Forms.PictureBox pictureBoxMenuReg;
        private System.Windows.Forms.Panel panelContent;
        public System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.PictureBox pictureBoxSsh;
        private System.Windows.Forms.ToolTip toolTipSsh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSshOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSshClose;
        private System.Windows.Forms.PictureBox pictureBoxDatabase;
        private System.Windows.Forms.ToolTip toolTipDatabase;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDatabaseOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.PictureBox pictureBoxRfid;
        private System.Windows.Forms.ToolTip toolTipRfid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRfidOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRfidClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSshChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRfidChange;
    }
}

