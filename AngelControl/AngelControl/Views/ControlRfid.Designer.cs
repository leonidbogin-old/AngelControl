namespace AngelControl.Views
{
    partial class ControlRfid
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
            this.panelRfidTop = new System.Windows.Forms.Panel();
            this.panelBorder3 = new System.Windows.Forms.Panel();
            this.panelMonitor = new System.Windows.Forms.Panel();
            this.labelMonitor = new System.Windows.Forms.Label();
            this.panelMonitorActive = new System.Windows.Forms.Panel();
            this.panelBorder2 = new System.Windows.Forms.Panel();
            this.panelStudy = new System.Windows.Forms.Panel();
            this.labelStudy = new System.Windows.Forms.Label();
            this.panelStudyActive = new System.Windows.Forms.Panel();
            this.panelBorder1 = new System.Windows.Forms.Panel();
            this.panelNutrition = new System.Windows.Forms.Panel();
            this.labelNutrition = new System.Windows.Forms.Label();
            this.panelNutritionActive = new System.Windows.Forms.Panel();
            this.panelRfidContent = new System.Windows.Forms.Panel();
            this.panelRfidTop.SuspendLayout();
            this.panelMonitor.SuspendLayout();
            this.panelStudy.SuspendLayout();
            this.panelNutrition.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRfidTop
            // 
            this.panelRfidTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelRfidTop.Controls.Add(this.panelBorder3);
            this.panelRfidTop.Controls.Add(this.panelMonitor);
            this.panelRfidTop.Controls.Add(this.panelBorder2);
            this.panelRfidTop.Controls.Add(this.panelStudy);
            this.panelRfidTop.Controls.Add(this.panelBorder1);
            this.panelRfidTop.Controls.Add(this.panelNutrition);
            this.panelRfidTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRfidTop.Location = new System.Drawing.Point(0, 0);
            this.panelRfidTop.Name = "panelRfidTop";
            this.panelRfidTop.Size = new System.Drawing.Size(703, 35);
            this.panelRfidTop.TabIndex = 0;
            // 
            // panelBorder3
            // 
            this.panelBorder3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelBorder3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorder3.Location = new System.Drawing.Point(542, 0);
            this.panelBorder3.Margin = new System.Windows.Forms.Padding(0);
            this.panelBorder3.Name = "panelBorder3";
            this.panelBorder3.Size = new System.Drawing.Size(1, 35);
            this.panelBorder3.TabIndex = 5;
            // 
            // panelMonitor
            // 
            this.panelMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMonitor.Controls.Add(this.labelMonitor);
            this.panelMonitor.Controls.Add(this.panelMonitorActive);
            this.panelMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMonitor.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMonitor.Location = new System.Drawing.Point(362, 0);
            this.panelMonitor.Name = "panelMonitor";
            this.panelMonitor.Size = new System.Drawing.Size(180, 35);
            this.panelMonitor.TabIndex = 4;
            this.panelMonitor.Click += new System.EventHandler(this.panelMonitor_Click);
            // 
            // labelMonitor
            // 
            this.labelMonitor.BackColor = System.Drawing.Color.Transparent;
            this.labelMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMonitor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMonitor.Location = new System.Drawing.Point(3, 5);
            this.labelMonitor.Name = "labelMonitor";
            this.labelMonitor.Size = new System.Drawing.Size(174, 24);
            this.labelMonitor.TabIndex = 1;
            this.labelMonitor.Text = "Монитор";
            this.labelMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMonitor.Click += new System.EventHandler(this.labelMonitor_Click);
            this.labelMonitor.MouseEnter += new System.EventHandler(this.labelMonitor_MouseEnter);
            this.labelMonitor.MouseLeave += new System.EventHandler(this.labelMonitor_MouseLeave);
            // 
            // panelMonitorActive
            // 
            this.panelMonitorActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.panelMonitorActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMonitorActive.Location = new System.Drawing.Point(0, 0);
            this.panelMonitorActive.Name = "panelMonitorActive";
            this.panelMonitorActive.Size = new System.Drawing.Size(180, 3);
            this.panelMonitorActive.TabIndex = 0;
            this.panelMonitorActive.Visible = false;
            this.panelMonitorActive.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMonitorActive_Paint);
            // 
            // panelBorder2
            // 
            this.panelBorder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelBorder2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorder2.Location = new System.Drawing.Point(361, 0);
            this.panelBorder2.Margin = new System.Windows.Forms.Padding(0);
            this.panelBorder2.Name = "panelBorder2";
            this.panelBorder2.Size = new System.Drawing.Size(1, 35);
            this.panelBorder2.TabIndex = 3;
            // 
            // panelStudy
            // 
            this.panelStudy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelStudy.Controls.Add(this.labelStudy);
            this.panelStudy.Controls.Add(this.panelStudyActive);
            this.panelStudy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelStudy.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudy.Location = new System.Drawing.Point(181, 0);
            this.panelStudy.Name = "panelStudy";
            this.panelStudy.Size = new System.Drawing.Size(180, 35);
            this.panelStudy.TabIndex = 2;
            this.panelStudy.Click += new System.EventHandler(this.panelStudy_Click);
            // 
            // labelStudy
            // 
            this.labelStudy.BackColor = System.Drawing.Color.Transparent;
            this.labelStudy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStudy.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudy.Location = new System.Drawing.Point(3, 5);
            this.labelStudy.Name = "labelStudy";
            this.labelStudy.Size = new System.Drawing.Size(174, 24);
            this.labelStudy.TabIndex = 1;
            this.labelStudy.Text = "Учёба";
            this.labelStudy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStudy.Click += new System.EventHandler(this.labelStudy_Click);
            this.labelStudy.MouseEnter += new System.EventHandler(this.labelStudy_MouseEnter);
            this.labelStudy.MouseLeave += new System.EventHandler(this.labelStudy_MouseLeave);
            // 
            // panelStudyActive
            // 
            this.panelStudyActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.panelStudyActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudyActive.Location = new System.Drawing.Point(0, 0);
            this.panelStudyActive.Name = "panelStudyActive";
            this.panelStudyActive.Size = new System.Drawing.Size(180, 3);
            this.panelStudyActive.TabIndex = 0;
            this.panelStudyActive.Visible = false;
            this.panelStudyActive.Click += new System.EventHandler(this.panelStudyActive_Click);
            // 
            // panelBorder1
            // 
            this.panelBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelBorder1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBorder1.Location = new System.Drawing.Point(180, 0);
            this.panelBorder1.Margin = new System.Windows.Forms.Padding(0);
            this.panelBorder1.Name = "panelBorder1";
            this.panelBorder1.Size = new System.Drawing.Size(1, 35);
            this.panelBorder1.TabIndex = 1;
            // 
            // panelNutrition
            // 
            this.panelNutrition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelNutrition.Controls.Add(this.labelNutrition);
            this.panelNutrition.Controls.Add(this.panelNutritionActive);
            this.panelNutrition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelNutrition.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNutrition.Location = new System.Drawing.Point(0, 0);
            this.panelNutrition.Name = "panelNutrition";
            this.panelNutrition.Size = new System.Drawing.Size(180, 35);
            this.panelNutrition.TabIndex = 0;
            this.panelNutrition.Click += new System.EventHandler(this.panelNutrition_Click);
            this.panelNutrition.MouseEnter += new System.EventHandler(this.panelNutrition_MouseEnter);
            this.panelNutrition.MouseLeave += new System.EventHandler(this.panelNutrition_MouseLeave);
            // 
            // labelNutrition
            // 
            this.labelNutrition.BackColor = System.Drawing.Color.Transparent;
            this.labelNutrition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNutrition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNutrition.Location = new System.Drawing.Point(3, 5);
            this.labelNutrition.Name = "labelNutrition";
            this.labelNutrition.Size = new System.Drawing.Size(174, 24);
            this.labelNutrition.TabIndex = 1;
            this.labelNutrition.Text = "Питание";
            this.labelNutrition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNutrition.Click += new System.EventHandler(this.labelNutrition_Click);
            // 
            // panelNutritionActive
            // 
            this.panelNutritionActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.panelNutritionActive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNutritionActive.Location = new System.Drawing.Point(0, 0);
            this.panelNutritionActive.Name = "panelNutritionActive";
            this.panelNutritionActive.Size = new System.Drawing.Size(180, 3);
            this.panelNutritionActive.TabIndex = 0;
            this.panelNutritionActive.Visible = false;
            this.panelNutritionActive.Click += new System.EventHandler(this.panelNutritionActive_Click);
            // 
            // panelRfidContent
            // 
            this.panelRfidContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRfidContent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelRfidContent.Location = new System.Drawing.Point(0, 35);
            this.panelRfidContent.Name = "panelRfidContent";
            this.panelRfidContent.Size = new System.Drawing.Size(703, 393);
            this.panelRfidContent.TabIndex = 1;
            // 
            // Rfid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panelRfidContent);
            this.Controls.Add(this.panelRfidTop);
            this.Name = "Rfid";
            this.Size = new System.Drawing.Size(703, 428);
            this.Load += new System.EventHandler(this.Rfid_Load);
            this.panelRfidTop.ResumeLayout(false);
            this.panelMonitor.ResumeLayout(false);
            this.panelStudy.ResumeLayout(false);
            this.panelNutrition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRfidTop;
        private System.Windows.Forms.Panel panelNutrition;
        private System.Windows.Forms.Panel panelNutritionActive;
        private System.Windows.Forms.Panel panelRfidContent;
        private System.Windows.Forms.Label labelNutrition;
        private System.Windows.Forms.Panel panelBorder1;
        private System.Windows.Forms.Panel panelStudy;
        private System.Windows.Forms.Label labelStudy;
        private System.Windows.Forms.Panel panelStudyActive;
        private System.Windows.Forms.Panel panelMonitor;
        private System.Windows.Forms.Label labelMonitor;
        private System.Windows.Forms.Panel panelMonitorActive;
        private System.Windows.Forms.Panel panelBorder2;
        private System.Windows.Forms.Panel panelBorder3;
    }
}
