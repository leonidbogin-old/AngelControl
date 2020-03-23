using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngelControl.Data;
using AngelControl.Data.Class;
using System.Threading;

namespace AngelControl.Views {
    public partial class ControlReg : UserControl {

        private Thread threadSelect;
        private Reg selectLastParameters;

        public ControlReg() {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e) {
            dataGridViewReg.CellClick += new DataGridViewCellEventHandler(CellClick);
        }

        public void SelectRegs() {
            Reg selectParameters = new Reg();
            textBoxLname.Invoke(new Action(() => {
                if (textBoxLname.Text.Length > 0) selectParameters.Lname = textBoxLname.Text;
                if (textBoxFname.Text.Length > 0) selectParameters.Fname = textBoxFname.Text;
                if (textBoxPname.Text.Length > 0) selectParameters.Pname = textBoxPname.Text;
            }));
            using (Database database = new Database()) {
                if (database.OpenSave()) {
                    List<Reg> regs = database.GetRegs(selectParameters);
                    selectLastParameters = selectParameters;
                    dataGridViewReg.Invoke(new Action(() => {
                        dataGridViewReg.Rows.Clear();
                        foreach (Reg reg in regs) {
                            int rowIndex = this.dataGridViewReg.Rows.Add();
                            var row = this.dataGridViewReg.Rows[rowIndex];
                            row.Cells["ColumnId"].Value = reg.Id < 10 ? "00" + reg.Id : (reg.Id < 100 ? "0" + reg.Id : reg.Id.ToString());
                            row.Cells["ColumnEdit"].Value = Properties.Resources.edit_icon15;
                            row.Cells["ColumnLname"].Value = reg.Lname;
                            row.Cells["ColumnFname"].Value = reg.Fname;
                            row.Cells["ColumnPname"].Value = reg.Pname;
                            row.Cells["ColumnBirthday"].Value = reg.Birthday.HasValue ? reg.Birthday.Value.ToShortDateString() : null;
                            row.Cells["ColumnAge"].Value = reg.Age.HasValue ? reg.Age : null;
                            if (reg.Age.HasValue && reg.Age < 10) {
                                row.Cells["ColumnAge"].Style.BackColor = Color.OrangeRed;
                            } else {
                                if (reg.Age.HasValue && reg.Age < 18) {
                                    row.Cells["ColumnAge"].Style.BackColor = Color.Yellow;
                                }
                            }
                        
                        }
                        tabPageReg.Text = $@"Регистрация ({regs.Count} из {database.CountRegs()})";
                        this.Cursor = System.Windows.Forms.Cursors.Default;
                    }));
                }
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 1) {
                MessageBox.Show("You have selected in image in " + dataGridViewReg.Rows[e.RowIndex].Cells[0].Value.ToString() + " row.");
            }
        }

        private void textBoxLname_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void textBoxPname_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private bool CheckSelectRelevance() {
            if (selectLastParameters.Lname == null) {
                if (textBoxLname.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Lname.Equals(textBoxLname.Text)) return false;
            }
            if (selectLastParameters.Fname == null) {
                if (textBoxFname.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Fname.Equals(textBoxFname.Text)) return false;
            }
            if (selectLastParameters.Pname == null) {
                if (textBoxPname.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Pname.Equals(textBoxPname.Text)) return false;
            }
            return true;
        }

        public void StartSelectRegs() {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (threadSelect != null && threadSelect.ThreadState == ThreadState.Running) threadSelect.Abort();
            threadSelect = new Thread(SelectRegs);
            threadSelect.Priority = ThreadPriority.Highest;
            threadSelect.Start();
            timerChange.Stop();
        }

        private void timerChange_Tick(object sender, EventArgs e) {
            StartSelectRegs();
        }

        private void dataGridViewReg_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridViewReg.Rows.Count > 0 && e.RowIndex >= 0) {
                MessageBox.Show("You have selected in " + dataGridViewReg.Rows[e.RowIndex].Cells[0].Value.ToString() + " row.");
            }
        }
    }
}
