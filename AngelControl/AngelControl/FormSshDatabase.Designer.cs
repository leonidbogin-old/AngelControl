namespace AngelControl {
    partial class FormSshDatabase {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSshDatabase));
            this.pictureBoxDatabase = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSshPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSshLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSshIp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDatabasePort = new System.Windows.Forms.NumericUpDown();
            this.textBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDatabasePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDatabaseUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDatabaseServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBorderDatabase = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatabasePort)).BeginInit();
            this.panelBorderDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDatabase
            // 
            this.pictureBoxDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.pictureBoxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDatabase.Image = global::AngelControl.Properties.Resources.Database;
            this.pictureBoxDatabase.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxDatabase.Name = "pictureBoxDatabase";
            this.pictureBoxDatabase.Size = new System.Drawing.Size(218, 395);
            this.pictureBoxDatabase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDatabase.TabIndex = 0;
            this.pictureBoxDatabase.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSshPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSshLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSshIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(249, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SSH";
            // 
            // textBoxSshPassword
            // 
            this.textBoxSshPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshPassword.Location = new System.Drawing.Point(102, 112);
            this.textBoxSshPassword.MaxLength = 256;
            this.textBoxSshPassword.Name = "textBoxSshPassword";
            this.textBoxSshPassword.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshPassword.TabIndex = 6;
            this.textBoxSshPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // textBoxSshLogin
            // 
            this.textBoxSshLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshLogin.Location = new System.Drawing.Point(102, 74);
            this.textBoxSshLogin.MaxLength = 256;
            this.textBoxSshLogin.Name = "textBoxSshLogin";
            this.textBoxSshLogin.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(52, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Login";
            // 
            // textBoxSshIp
            // 
            this.textBoxSshIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshIp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshIp.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshIp.Location = new System.Drawing.Point(102, 35);
            this.textBoxSshIp.MaxLength = 256;
            this.textBoxSshIp.Name = "textBoxSshIp";
            this.textBoxSshIp.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshIp.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownDatabasePort);
            this.groupBox2.Controls.Add(this.textBoxDatabaseName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxDatabasePassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxDatabaseUserId);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxDatabaseServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(249, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 239);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "База_данных";
            // 
            // numericUpDownDatabasePort
            // 
            this.numericUpDownDatabasePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.numericUpDownDatabasePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDatabasePort.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.numericUpDownDatabasePort.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownDatabasePort.Location = new System.Drawing.Point(102, 74);
            this.numericUpDownDatabasePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownDatabasePort.Name = "numericUpDownDatabasePort";
            this.numericUpDownDatabasePort.Size = new System.Drawing.Size(166, 26);
            this.numericUpDownDatabasePort.TabIndex = 11;
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabaseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseName.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabaseName.Location = new System.Drawing.Point(102, 189);
            this.textBoxDatabaseName.MaxLength = 256;
            this.textBoxDatabaseName.Name = "textBoxDatabaseName";
            this.textBoxDatabaseName.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabaseName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(27, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Database";
            // 
            // textBoxDatabasePassword
            // 
            this.textBoxDatabasePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabasePassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabasePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabasePassword.Location = new System.Drawing.Point(102, 151);
            this.textBoxDatabasePassword.MaxLength = 256;
            this.textBoxDatabasePassword.Name = "textBoxDatabasePassword";
            this.textBoxDatabasePassword.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabasePassword.TabIndex = 8;
            this.textBoxDatabasePassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(27, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // textBoxDatabaseUserId
            // 
            this.textBoxDatabaseUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabaseUserId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseUserId.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabaseUserId.Location = new System.Drawing.Point(102, 112);
            this.textBoxDatabaseUserId.MaxLength = 256;
            this.textBoxDatabaseUserId.Name = "textBoxDatabaseUserId";
            this.textBoxDatabaseUserId.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabaseUserId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(45, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "UserID";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(61, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Port";
            // 
            // textBoxDatabaseServer
            // 
            this.textBoxDatabaseServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabaseServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseServer.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabaseServer.Location = new System.Drawing.Point(102, 35);
            this.textBoxDatabaseServer.MaxLength = 256;
            this.textBoxDatabaseServer.Name = "textBoxDatabaseServer";
            this.textBoxDatabaseServer.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabaseServer.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(46, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Server";
            // 
            // panelBorderDatabase
            // 
            this.panelBorderDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBorderDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBorderDatabase.Controls.Add(this.pictureBoxDatabase);
            this.panelBorderDatabase.Location = new System.Drawing.Point(15, 11);
            this.panelBorderDatabase.Name = "panelBorderDatabase";
            this.panelBorderDatabase.Padding = new System.Windows.Forms.Padding(1);
            this.panelBorderDatabase.Size = new System.Drawing.Size(222, 399);
            this.panelBorderDatabase.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Gray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(360, 428);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 33);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить настройки";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(17, 427);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 33);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.Gray;
            this.buttonTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTest.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTest.Location = new System.Drawing.Point(297, 428);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(56, 33);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = false;
            // 
            // FormSshDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(559, 479);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelBorderDatabase);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSshDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки подключения базы данных через SSH";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDatabase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatabasePort)).EndInit();
            this.panelBorderDatabase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSshLogin;
        private System.Windows.Forms.TextBox textBoxSshIp;
        private System.Windows.Forms.TextBox textBoxSshPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
        private System.Windows.Forms.TextBox textBoxDatabasePassword;
        private System.Windows.Forms.TextBox textBoxDatabaseUserId;
        private System.Windows.Forms.TextBox textBoxDatabaseServer;
        private System.Windows.Forms.Panel panelBorderDatabase;
        private System.Windows.Forms.NumericUpDown numericUpDownDatabasePort;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonTest;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
    }
}