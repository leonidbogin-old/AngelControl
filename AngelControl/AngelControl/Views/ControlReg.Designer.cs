namespace AngelControl.Views
{
    partial class ControlReg
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.dataGridViewReg = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.textBoxPname);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.textBoxFname);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.textBoxLname);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(243, 437);
            this.panelSearch.TabIndex = 0;
            // 
            // textBoxLname
            // 
            this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxLname.Location = new System.Drawing.Point(12, 26);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(216, 26);
            this.textBoxLname.TabIndex = 0;
            this.textBoxLname.TextChanged += new System.EventHandler(this.textBoxLname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // textBoxFname
            // 
            this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFname.Location = new System.Drawing.Point(12, 72);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(216, 26);
            this.textBoxFname.TabIndex = 2;
            this.textBoxFname.TextChanged += new System.EventHandler(this.textBoxFname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yandex-UI-Icons-Private", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Отчество";
            // 
            // textBoxPname
            // 
            this.textBoxPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPname.Location = new System.Drawing.Point(12, 118);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(216, 26);
            this.textBoxPname.TabIndex = 4;
            this.textBoxPname.TextChanged += new System.EventHandler(this.textBoxPname_TextChanged);
            // 
            // dataGridViewReg
            // 
            this.dataGridViewReg.AllowUserToAddRows = false;
            this.dataGridViewReg.AllowUserToDeleteRows = false;
            this.dataGridViewReg.AllowUserToResizeRows = false;
            this.dataGridViewReg.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewReg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnEdit,
            this.ColumnLname,
            this.ColumnFname,
            this.ColumnPname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReg.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReg.Location = new System.Drawing.Point(243, 0);
            this.dataGridViewReg.MultiSelect = false;
            this.dataGridViewReg.Name = "dataGridViewReg";
            this.dataGridViewReg.ReadOnly = true;
            this.dataGridViewReg.RowHeadersVisible = false;
            this.dataGridViewReg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReg.ShowCellToolTips = false;
            this.dataGridViewReg.ShowEditingIcon = false;
            this.dataGridViewReg.Size = new System.Drawing.Size(472, 437);
            this.dataGridViewReg.TabIndex = 1;
            // 
            // ColumnId
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnId.HeaderText = "id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 35;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.HeaderText = " ";
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.ToolTipText = "Редактировать";
            this.ColumnEdit.Width = 20;
            // 
            // ColumnLname
            // 
            this.ColumnLname.HeaderText = "Фамилия";
            this.ColumnLname.Name = "ColumnLname";
            this.ColumnLname.ReadOnly = true;
            // 
            // ColumnFname
            // 
            this.ColumnFname.HeaderText = "Имя";
            this.ColumnFname.Name = "ColumnFname";
            this.ColumnFname.ReadOnly = true;
            // 
            // ColumnPname
            // 
            this.ColumnPname.HeaderText = "Отчество";
            this.ColumnPname.Name = "ColumnPname";
            this.ColumnPname.ReadOnly = true;
            // 
            // ControlReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewReg);
            this.Controls.Add(this.panelSearch);
            this.Name = "ControlReg";
            this.Size = new System.Drawing.Size(715, 437);
            this.Load += new System.EventHandler(this.Reg_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.DataGridView dataGridViewReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPname;
    }
}
