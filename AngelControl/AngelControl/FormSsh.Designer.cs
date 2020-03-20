namespace AngelControl {
    partial class FormSsh {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSsh));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshBoundPort)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(104, 249);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 30);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить настройки";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.buttonCancel.ForeColor = System.Drawing.Color.DimGray;
            this.buttonCancel.Location = new System.Drawing.Point(18, 249);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownSshPort
            // 
            this.numericUpDownSshPort.BackColor = System.Drawing.Color.White;
            this.numericUpDownSshPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSshPort.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.numericUpDownSshPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownSshPort.Location = new System.Drawing.Point(230, 153);
            this.numericUpDownSshPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSshPort.Name = "numericUpDownSshPort";
            this.numericUpDownSshPort.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownSshPort.TabIndex = 4;
            // 
            // textBoxSshHost
            // 
            this.textBoxSshHost.BackColor = System.Drawing.Color.White;
            this.textBoxSshHost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshHost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSshHost.Location = new System.Drawing.Point(128, 153);
            this.textBoxSshHost.MaxLength = 256;
            this.textBoxSshHost.Name = "textBoxSshHost";
            this.textBoxSshHost.Size = new System.Drawing.Size(101, 26);
            this.textBoxSshHost.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(61, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "Хост_1";
            // 
            // numericUpDownSshBoundPort
            // 
            this.numericUpDownSshBoundPort.BackColor = System.Drawing.Color.White;
            this.numericUpDownSshBoundPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSshBoundPort.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.numericUpDownSshBoundPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownSshBoundPort.Location = new System.Drawing.Point(230, 196);
            this.numericUpDownSshBoundPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownSshBoundPort.Name = "numericUpDownSshBoundPort";
            this.numericUpDownSshBoundPort.Size = new System.Drawing.Size(64, 26);
            this.numericUpDownSshBoundPort.TabIndex = 6;
            // 
            // textBoxSshPassword
            // 
            this.textBoxSshPassword.BackColor = System.Drawing.Color.White;
            this.textBoxSshPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSshPassword.Location = new System.Drawing.Point(128, 110);
            this.textBoxSshPassword.MaxLength = 256;
            this.textBoxSshPassword.Name = "textBoxSshPassword";
            this.textBoxSshPassword.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshPassword.TabIndex = 2;
            this.textBoxSshPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSshBoundHost
            // 
            this.textBoxSshBoundHost.BackColor = System.Drawing.Color.White;
            this.textBoxSshBoundHost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshBoundHost.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSshBoundHost.Location = new System.Drawing.Point(128, 196);
            this.textBoxSshBoundHost.MaxLength = 256;
            this.textBoxSshBoundHost.Name = "textBoxSshBoundHost";
            this.textBoxSshBoundHost.Size = new System.Drawing.Size(101, 26);
            this.textBoxSshBoundHost.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(61, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Хост_2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Пароль";
            // 
            // textBoxSshLogin
            // 
            this.textBoxSshLogin.BackColor = System.Drawing.Color.White;
            this.textBoxSshLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSshLogin.Location = new System.Drawing.Point(128, 67);
            this.textBoxSshLogin.MaxLength = 256;
            this.textBoxSshLogin.Name = "textBoxSshLogin";
            this.textBoxSshLogin.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(68, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Логин";
            // 
            // textBoxSshIp
            // 
            this.textBoxSshIp.BackColor = System.Drawing.Color.White;
            this.textBoxSshIp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSshIp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSshIp.Location = new System.Drawing.Point(128, 23);
            this.textBoxSshIp.MaxLength = 256;
            this.textBoxSshIp.Name = "textBoxSshIp";
            this.textBoxSshIp.Size = new System.Drawing.Size(166, 26);
            this.textBoxSshIp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "IP_адрес";
            // 
            // FormSsh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 294);
            this.Controls.Add(this.numericUpDownSshPort);
            this.Controls.Add(this.textBoxSshHost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownSshBoundPort);
            this.Controls.Add(this.textBoxSshPassword);
            this.Controls.Add(this.textBoxSshBoundHost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSshLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSshIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSsh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки туннеля SSH";
            this.Load += new System.EventHandler(this.FormSshDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSshBoundPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownSshPort;
        private System.Windows.Forms.TextBox textBoxSshHost;
        protected System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownSshBoundPort;
        private System.Windows.Forms.TextBox textBoxSshPassword;
        private System.Windows.Forms.TextBox textBoxSshBoundHost;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSshLogin;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSshIp;
        protected System.Windows.Forms.Label label1;
    }
}