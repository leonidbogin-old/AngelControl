namespace AngelControl
{
    partial class FormRfidConnect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRfidConnect));
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReaderOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxHandshake = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxWriteTimeout = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxReadTimeout = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(37, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "StopBits -";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "OnePointFive",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(108, 83);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(84, 21);
            this.comboBoxStopBits.TabIndex = 42;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(108, 52);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(84, 21);
            this.comboBoxParity.Sorted = true;
            this.comboBoxParity.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(53, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Parity -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(231, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "BaudRate -";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28900",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(313, 21);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(84, 21);
            this.comboBoxBaudRate.TabIndex = 38;
            // 
            // comboBoxPortName
            // 
            this.comboBoxPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxPortName.FormattingEnabled = true;
            this.comboBoxPortName.Location = new System.Drawing.Point(108, 20);
            this.comboBoxPortName.Name = "comboBoxPortName";
            this.comboBoxPortName.Size = new System.Drawing.Size(84, 21);
            this.comboBoxPortName.TabIndex = 36;
            this.comboBoxPortName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxReaderPort_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "PortName -";
            // 
            // buttonReaderOpen
            // 
            this.buttonReaderOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonReaderOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReaderOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReaderOpen.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.buttonReaderOpen.ForeColor = System.Drawing.Color.Black;
            this.buttonReaderOpen.Location = new System.Drawing.Point(108, 157);
            this.buttonReaderOpen.Name = "buttonReaderOpen";
            this.buttonReaderOpen.Size = new System.Drawing.Size(289, 30);
            this.buttonReaderOpen.TabIndex = 44;
            this.buttonReaderOpen.Text = "Открыть порт";
            this.buttonReaderOpen.UseVisualStyleBackColor = false;
            this.buttonReaderOpen.Click += new System.EventHandler(this.buttonReaderOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(238, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "DataBits -";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(313, 52);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(84, 21);
            this.comboBoxDataBits.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(18, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Handshake -";
            // 
            // comboBoxHandshake
            // 
            this.comboBoxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHandshake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxHandshake.FormattingEnabled = true;
            this.comboBoxHandshake.Items.AddRange(new object[] {
            "None",
            "RequestToSend",
            "RequestToSendXOnXOff",
            "XOnXOff"});
            this.comboBoxHandshake.Location = new System.Drawing.Point(108, 114);
            this.comboBoxHandshake.Name = "comboBoxHandshake";
            this.comboBoxHandshake.Size = new System.Drawing.Size(84, 21);
            this.comboBoxHandshake.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(226, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "WriteTime -";
            // 
            // comboBoxWriteTimeout
            // 
            this.comboBoxWriteTimeout.AutoCompleteCustomSource.AddRange(new string[] {
            "1000"});
            this.comboBoxWriteTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxWriteTimeout.FormattingEnabled = true;
            this.comboBoxWriteTimeout.Items.AddRange(new object[] {
            "1000"});
            this.comboBoxWriteTimeout.Location = new System.Drawing.Point(313, 114);
            this.comboBoxWriteTimeout.Name = "comboBoxWriteTimeout";
            this.comboBoxWriteTimeout.Size = new System.Drawing.Size(84, 21);
            this.comboBoxWriteTimeout.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.75F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(230, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "ReadTime -";
            // 
            // comboBoxReadTimeout
            // 
            this.comboBoxReadTimeout.AutoCompleteCustomSource.AddRange(new string[] {
            "1000"});
            this.comboBoxReadTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.comboBoxReadTimeout.FormattingEnabled = true;
            this.comboBoxReadTimeout.Items.AddRange(new object[] {
            "1000"});
            this.comboBoxReadTimeout.Location = new System.Drawing.Point(313, 83);
            this.comboBoxReadTimeout.Name = "comboBoxReadTimeout";
            this.comboBoxReadTimeout.Size = new System.Drawing.Size(84, 21);
            this.comboBoxReadTimeout.TabIndex = 49;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Calibri", 12.75F);
            this.buttonClose.ForeColor = System.Drawing.Color.Black;
            this.buttonClose.Location = new System.Drawing.Point(22, 157);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 30);
            this.buttonClose.TabIndex = 53;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormRfidConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(417, 201);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxWriteTimeout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxReadTimeout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxHandshake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.buttonReaderOpen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxPortName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRfidConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подключение RFID";
            this.Load += new System.EventHandler(this.FormRfidConnect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReaderOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxHandshake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxWriteTimeout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxReadTimeout;
        private System.Windows.Forms.Button buttonClose;
    }
}