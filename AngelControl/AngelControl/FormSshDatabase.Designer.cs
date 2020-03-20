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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshBoundPort)).BeginInit();
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
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(238, 285);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(203, 33);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить настройки";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonCancel.Location = new System.Drawing.Point(17, 285);
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
            this.ClientSize = new System.Drawing.Size(459, 330);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSshLogin;
        private System.Windows.Forms.TextBox textBoxSshIp;
        private System.Windows.Forms.TextBox textBoxSshPassword;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSshBoundPort;
        private System.Windows.Forms.TextBox textBoxSshBoundHost;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownSshPort;
        private System.Windows.Forms.TextBox textBoxSshHost;
        protected System.Windows.Forms.Label label9;
    }
}