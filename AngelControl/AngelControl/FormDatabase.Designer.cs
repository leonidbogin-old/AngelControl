namespace AngelControl {
    partial class FormDatabase {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatabase));
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericUpDownDatabasePort = new System.Windows.Forms.NumericUpDown();
            this.textBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDatabasePassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDatabaseUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDatabaseServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatabasePort)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSave.Location = new System.Drawing.Point(106, 212);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(240, 30);
            this.buttonSave.TabIndex = 10;
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
            this.buttonCancel.Location = new System.Drawing.Point(21, 212);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericUpDownDatabasePort
            // 
            this.numericUpDownDatabasePort.BackColor = System.Drawing.Color.White;
            this.numericUpDownDatabasePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownDatabasePort.Font = new System.Drawing.Font("Arial Narrow", 11.5F);
            this.numericUpDownDatabasePort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownDatabasePort.Location = new System.Drawing.Point(244, 24);
            this.numericUpDownDatabasePort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDownDatabasePort.Name = "numericUpDownDatabasePort";
            this.numericUpDownDatabasePort.Size = new System.Drawing.Size(64, 25);
            this.numericUpDownDatabasePort.TabIndex = 20;
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.BackColor = System.Drawing.Color.White;
            this.textBoxDatabaseName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDatabaseName.Location = new System.Drawing.Point(142, 157);
            this.textBoxDatabaseName.MaxLength = 256;
            this.textBoxDatabaseName.Name = "textBoxDatabaseName";
            this.textBoxDatabaseName.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabaseName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(32, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "База_данных";
            // 
            // textBoxDatabasePassword
            // 
            this.textBoxDatabasePassword.BackColor = System.Drawing.Color.White;
            this.textBoxDatabasePassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabasePassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDatabasePassword.Location = new System.Drawing.Point(142, 112);
            this.textBoxDatabasePassword.MaxLength = 256;
            this.textBoxDatabasePassword.Name = "textBoxDatabasePassword";
            this.textBoxDatabasePassword.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabasePassword.TabIndex = 17;
            this.textBoxDatabasePassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(72, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Пароль";
            // 
            // textBoxDatabaseUserId
            // 
            this.textBoxDatabaseUserId.BackColor = System.Drawing.Color.White;
            this.textBoxDatabaseUserId.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseUserId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDatabaseUserId.Location = new System.Drawing.Point(142, 68);
            this.textBoxDatabaseUserId.MaxLength = 256;
            this.textBoxDatabaseUserId.Name = "textBoxDatabaseUserId";
            this.textBoxDatabaseUserId.Size = new System.Drawing.Size(166, 26);
            this.textBoxDatabaseUserId.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(82, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Логин";
            // 
            // textBoxDatabaseServer
            // 
            this.textBoxDatabaseServer.BackColor = System.Drawing.Color.White;
            this.textBoxDatabaseServer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDatabaseServer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDatabaseServer.Location = new System.Drawing.Point(142, 24);
            this.textBoxDatabaseServer.MaxLength = 256;
            this.textBoxDatabaseServer.Name = "textBoxDatabaseServer";
            this.textBoxDatabaseServer.Size = new System.Drawing.Size(101, 26);
            this.textBoxDatabaseServer.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(75, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Сервер";
            // 
            // FormDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 257);
            this.Controls.Add(this.numericUpDownDatabasePort);
            this.Controls.Add(this.textBoxDatabaseName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDatabasePassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDatabaseUserId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDatabaseServer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки подключения базы данных";
            this.Load += new System.EventHandler(this.FormDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDatabasePort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDownDatabasePort;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
        protected System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDatabasePassword;
        protected System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDatabaseUserId;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDatabaseServer;
        protected System.Windows.Forms.Label label6;
    }
}