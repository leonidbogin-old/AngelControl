﻿namespace AngelControl
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
            this.labelLog = new System.Windows.Forms.Label();
            this.panelMainMenu.SuspendLayout();
            this.panelMenuRfid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuRfid)).BeginInit();
            this.panelMenuReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuReg)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
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
            this.panelContent.Size = new System.Drawing.Size(720, 375);
            this.panelContent.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panelBottom.Controls.Add(this.labelLog);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 375);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(720, 35);
            this.panelBottom.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMainMenu.ResumeLayout(false);
            this.panelMenuRfid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuRfid)).EndInit();
            this.panelMenuReg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenuReg)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
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
    }
}
