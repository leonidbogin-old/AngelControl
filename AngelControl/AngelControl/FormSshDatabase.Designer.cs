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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSshPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxSshHost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownSshBoundPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxSshPassword = new System.Windows.Forms.TextBox();
            this.textBoxSshBoundHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.textBoxDatabaseServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshBoundPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatabasePort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP_адрес";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownSshPort);
            this.groupBox1.Controls.Add(this.textBoxSshHost);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDownSshBoundPort);
            this.groupBox1.Controls.Add(this.textBoxSshPassword);
            this.groupBox1.Controls.Add(this.textBoxSshBoundHost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSshLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSshIp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SSH";
            // 
            // numericUpDownSshPort
            // 
            this.numericUpDownSshPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.numericUpDownSshPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSshPort.Font = new System.Drawing.Font("Arial Narrow", 11.5F);
            this.numericUpDownSshPort.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownSshPort.Location = new System.Drawing.Point(277, 165);
            this.numericUpDownSshPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSshPort.Name = "numericUpDownSshPort";
            this.numericUpDownSshPort.Size = new System.Drawing.Size(64, 25);
            this.numericUpDownSshPort.TabIndex = 17;
            // 
            // textBoxSshHost
            // 
            this.textBoxSshHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshHost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshHost.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshHost.Location = new System.Drawing.Point(175, 165);
            this.textBoxSshHost.MaxLength = 256;
            this.textBoxSshHost.Name = "textBoxSshHost";
            this.textBoxSshHost.Size = new System.Drawing.Size(101, 26);
            this.textBoxSshHost.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(68, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Хост_1";
            // 
            // numericUpDownSshBoundPort
            // 
            this.numericUpDownSshBoundPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.numericUpDownSshBoundPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSshBoundPort.Font = new System.Drawing.Font("Arial Narrow", 11.5F);
            this.numericUpDownSshBoundPort.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownSshBoundPort.Location = new System.Drawing.Point(277, 208);
            this.numericUpDownSshBoundPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSshBoundPort.Name = "numericUpDownSshBoundPort";
            this.numericUpDownSshBoundPort.Size = new System.Drawing.Size(64, 25);
            this.numericUpDownSshBoundPort.TabIndex = 14;
            // 
            // textBoxSshPassword
            // 
            this.textBoxSshPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshPassword.Location = new System.Drawing.Point(175, 122);
            this.textBoxSshPassword.MaxLength = 256;
            this.textBoxSshPassword.Name = "textBoxSshPassword";
            this.textBoxSshPassword.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshPassword.TabIndex = 6;
            this.textBoxSshPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSshBoundHost
            // 
            this.textBoxSshBoundHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshBoundHost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshBoundHost.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshBoundHost.Location = new System.Drawing.Point(175, 208);
            this.textBoxSshBoundHost.MaxLength = 256;
            this.textBoxSshBoundHost.Name = "textBoxSshBoundHost";
            this.textBoxSshBoundHost.Size = new System.Drawing.Size(101, 26);
            this.textBoxSshBoundHost.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(68, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Хост_2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(68, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // textBoxSshLogin
            // 
            this.textBoxSshLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshLogin.Location = new System.Drawing.Point(175, 79);
            this.textBoxSshLogin.MaxLength = 256;
            this.textBoxSshLogin.Name = "textBoxSshLogin";
            this.textBoxSshLogin.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(68, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // textBoxSshIp
            // 
            this.textBoxSshIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxSshIp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshIp.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxSshIp.Location = new System.Drawing.Point(175, 35);
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
            this.groupBox2.Controls.Add(this.textBoxDatabaseServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(17, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 230);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "База_данных";
            // 
            // numericUpDownDatabasePort
            // 
            this.numericUpDownDatabasePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.numericUpDownDatabasePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDatabasePort.Font = new System.Drawing.Font("Arial Narrow", 11.5F);
            this.numericUpDownDatabasePort.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownDatabasePort.Location = new System.Drawing.Point(277, 40);
            this.numericUpDownDatabasePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownDatabasePort.Name = "numericUpDownDatabasePort";
            this.numericUpDownDatabasePort.Size = new System.Drawing.Size(64, 25);
            this.numericUpDownDatabasePort.TabIndex = 11;
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabaseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseName.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabaseName.Location = new System.Drawing.Point(175, 173);
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
            this.label7.Location = new System.Drawing.Point(67, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "База_данных";
            // 
            // textBoxDatabasePassword
            // 
            this.textBoxDatabasePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabasePassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabasePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabasePassword.Location = new System.Drawing.Point(175, 128);
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
            this.label8.Location = new System.Drawing.Point(66, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пароль";
            // 
            // textBoxDatabaseUserId
            // 
            this.textBoxDatabaseUserId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabaseUserId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseUserId.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabaseUserId.Location = new System.Drawing.Point(175, 84);
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
            this.label4.Location = new System.Drawing.Point(68, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Логин";
            // 
            // textBoxDatabaseServer
            // 
            this.textBoxDatabaseServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.textBoxDatabaseServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseServer.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxDatabaseServer.Location = new System.Drawing.Point(175, 40);
            this.textBoxDatabaseServer.MaxLength = 256;
            this.textBoxDatabaseServer.Name = "textBoxDatabaseServer";
            this.textBoxDatabaseServer.Size = new System.Drawing.Size(101, 26);
            this.textBoxDatabaseServer.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(68, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Сервер";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Gray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(238, 527);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(203, 33);
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
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonCancel.Location = new System.Drawing.Point(17, 527);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 33);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormSshDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(459, 573);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSshDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки подключения базы данных через SSH";
            this.Load += new System.EventHandler(this.FormSshDatabase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshBoundPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatabasePort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSshLogin;
        private System.Windows.Forms.TextBox textBoxSshIp;
        private System.Windows.Forms.TextBox textBoxSshPassword;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
        private System.Windows.Forms.TextBox textBoxDatabasePassword;
        private System.Windows.Forms.TextBox textBoxDatabaseUserId;
        private System.Windows.Forms.TextBox textBoxDatabaseServer;
        private System.Windows.Forms.NumericUpDown numericUpDownDatabasePort;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSshBoundPort;
        private System.Windows.Forms.TextBox textBoxSshBoundHost;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSshPort;
        private System.Windows.Forms.TextBox textBoxSshHost;
        protected System.Windows.Forms.Label label9;
    }
}