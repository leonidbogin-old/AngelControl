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
            //dataGridViewReg.Sort(dataGridViewReg.Columns[0], ListSortDirection.Ascending);
        }

        private void Reg_Load(object sender, EventArgs e) {
            dataGridViewReg.CellClick += new DataGridViewCellEventHandler(CellClick);
        }

        public void SelectRegs() {
            Reg selectParameters = new Reg();
            textBoxLname.Invoke(new Action(() => {
                if (textBoxSelectLname.Text.Length > 0) selectParameters.Lname = textBoxSelectLname.Text;
                if (textBoxSelectFname.Text.Length > 0) selectParameters.Fname = textBoxSelectFname.Text;
                if (textBoxSelectPname.Text.Length > 0) selectParameters.Pname = textBoxSelectPname.Text;
                if (textBoxSelectCountry.Text.Length > 0) selectParameters.Country = textBoxSelectCountry.Text;
                if (textBoxSelectCity.Text.Length > 0) selectParameters.City = textBoxSelectCity.Text;
                if (textBoxSelectPhone.Text.Length > 0) selectParameters.Phone = textBoxSelectPhone.Text;
                if (comboBoxSelectStayWhere.Text.Length > 0) selectParameters.StayWhere = comboBoxSelectStayWhere.Text;
                if (comboBoxSelectStayLength.Text.Length > 0) selectParameters.StayLength = comboBoxSelectStayLength.Text;
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
                            row.Cells["ColumnReg"].Value = Properties.Resources.ok_icon15;
                            row.Cells["ColumnReg"].ToolTipText = "Завершить регистрацию";
                            row.Cells["ColumnEdit"].Value = Properties.Resources.edit_icon15;
                            row.Cells["ColumnEdit"].ToolTipText = "Редактировать регистрацию";
                            row.Cells["ColumnLname"].Value = reg.Lname;
                            row.Cells["ColumnFname"].Value = reg.Fname;
                            row.Cells["ColumnPname"].Value = reg.Pname;
                            row.Cells["ColumnPhone"].Value = reg.Phone;
                            if (reg.Phone == null || reg.Phone.Length == 0) {
                                row.Cells["ColumnPhone"].Style.BackColor = Color.Red;
                            }
                            //row.Cells["ColumnBirthday"].Value = reg.Birthday.HasValue ? reg.Birthday.Value.ToShortDateString() : null;
                            row.Cells["ColumnAge"].Value = reg.Age.HasValue ? reg.Age : null;
                            if (reg.Age.HasValue && reg.Age < 10) {
                                row.Cells["ColumnAge"].Style.BackColor = Color.OrangeRed;
                                row.Cells["ColumnAge"].Style.SelectionBackColor = Color.OrangeRed;
                                row.Cells["ColumnAge"].Style.SelectionForeColor = Color.Black;
                            } else {
                                if (reg.Age.HasValue && reg.Age < 18) {
                                    row.Cells["ColumnAge"].Style.BackColor = Color.Yellow;
                                    row.Cells["ColumnAge"].Style.SelectionBackColor = Color.Yellow;
                                    row.Cells["ColumnAge"].Style.SelectionForeColor = Color.Black;
                                }
                            }
                            row.Cells["ColumnCountry"].Value = reg.Country;
                            if (reg.Country != null && reg.Country != "Беларусь") {
                                row.Cells["ColumnCountry"].Style.BackColor = Color.Yellow;
                                row.Cells["ColumnCountry"].Style.SelectionBackColor = Color.Yellow;
                                row.Cells["ColumnCountry"].Style.SelectionForeColor = Color.Black;
                            }
                            row.Cells["ColumnCity"].Value = reg.City;
                            row.Cells["ColumnStayWhereId"].Value = reg.StayWhereId;
                            row.Cells["ColumnStayWhere"].Value = reg.StayWhere;
                            if (reg.StayWhere == null || reg.StayWhere == "Нет") {
                                row.Cells["ColumnStayWhere"].Style.BackColor = Color.Red;
                                row.Cells["ColumnStayWhere"].Style.SelectionBackColor = Color.Red;
                                row.Cells["ColumnStayWhere"].Style.SelectionForeColor = Color.Black;
                            } else
                                if (reg.StayWhere == "В личной палатке") {
                                row.Cells["ColumnStayWhere"].Style.BackColor = Color.Yellow;
                                row.Cells["ColumnStayWhere"].Style.SelectionBackColor = Color.Yellow;
                                row.Cells["ColumnStayWhere"].Style.SelectionForeColor = Color.Black;
                            } else if (reg.StayWhere == "В корпусе (ребенок, общее койко-место с родителем)") {
                                row.Cells["ColumnStayWhere"].Style.BackColor = Color.OrangeRed;
                                row.Cells["ColumnStayWhere"].Style.SelectionBackColor = Color.OrangeRed;
                                row.Cells["ColumnStayWhere"].Style.SelectionForeColor = Color.Black;
                            }
                            row.Cells["ColumnStayLengthId"].Value = reg.StayLengthId;
                            row.Cells["ColumnStayLength"].Value = reg.StayLength;
                            row.Cells["ColumnMealId"].Value = reg.NutritionId;
                            row.Cells["ColumnMeal"].Value = reg.Nutrition;
                        }
                        tabPageReg.Text = $@"Регистрация ({regs.Count} из {database.CountRegs()})";
                        this.Cursor = Cursors.Default;
                    }));
                }
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 1) {
                MessageBox.Show("ok " + dataGridViewReg.Rows[e.RowIndex].Cells[0].Value.ToString());
            } else {
                if (e.ColumnIndex == 2) {
                    MessageBox.Show("edit " + dataGridViewReg.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        private bool CheckSelectRelevance() {
            if (selectLastParameters.Lname == null) {
                if (textBoxSelectLname.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Lname.Equals(textBoxSelectLname.Text)) return false;
            }

            if (selectLastParameters.Fname == null) {
                if (textBoxSelectFname.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Fname.Equals(textBoxSelectFname.Text)) return false;
            }

            if (selectLastParameters.Pname == null) {
                if (textBoxSelectPname.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Pname.Equals(textBoxSelectPname.Text)) return false;
            }

            if (selectLastParameters.Country == null) {
                if (textBoxSelectCountry.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Country.Equals(textBoxSelectCountry.Text)) return false;
            }

            if (selectLastParameters.City == null) {
                if (textBoxSelectCity.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.City.Equals(textBoxSelectCity.Text)) return false;
            }

            if (selectLastParameters.Phone == null) {
                if (textBoxSelectPhone.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.Phone.Equals(textBoxSelectPhone.Text)) return false;
            }

            if (selectLastParameters.StayWhere == null) {
                if (comboBoxSelectStayWhere.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.StayWhere.Equals(comboBoxSelectStayWhere.Text)) return false;
            }

            if (selectLastParameters.StayLength == null) {
                if (comboBoxSelectStayLength.Text.Length > 0) return false;
            } else {
                if (!selectLastParameters.StayLength.Equals(comboBoxSelectStayLength.Text)) return false;
            }

            return true;
        }

        public void StartLoad() {
            using (Database database = new Database()) {
                if (database.OpenSave()) {
                    List<StayWhere> stayWheres = database.GetStayWheres();
                    comboBoxSelectStayWhere.Items.Clear();
                    comboBoxSelectStayWhere.Items.Add("");
                    foreach (StayWhere stayWhere in stayWheres) {
                        comboBoxSelectStayWhere.Items.Add(stayWhere.Name);
                    }

                    List<StayLength> stayLengths = database.GetStayLengths();
                    comboBoxSelectStayLength.Items.Clear();
                    comboBoxSelectStayLength.Items.Add("");
                    foreach (StayLength stayLength in stayLengths) {
                        comboBoxSelectStayLength.Items.Add(stayLength.Name);
                    }
                }
            }
            StartSelectRegs();
        }

        private void StartSelectRegs() {
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            if (threadSelect != null && threadSelect.ThreadState == ThreadState.Running) threadSelect.Abort();
            threadSelect = new Thread(SelectRegs);
            threadSelect.Priority = ThreadPriority.Highest;
            threadSelect.Start();
        }

        private void timerChange_Tick(object sender, EventArgs e) {
            timerChange.Stop();
            StartSelectRegs();
        }

        private void dataGridViewReg_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dataGridViewReg.Rows.Count > 0 && e.RowIndex >= 0) {
                MessageBox.Show("edit " + dataGridViewReg.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void textBoxSelectLname_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void textBoxSelectFname_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void textBoxSelectPname_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void textBoxSelectPhone_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void comboBoxSelectStayWhere_SelectedIndexChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                StartSelectRegs();
            } else timerChange.Stop();
        }

        private void comboBoxSelectStayLength_SelectedIndexChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                StartSelectRegs();
            } else timerChange.Stop();
        }

        private void textBoxSelectCountry_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }

        private void textBoxSelectCity_TextChanged(object sender, EventArgs e) {
            if (!CheckSelectRelevance()) {
                timerChange.Stop();
                timerChange.Start();
            } else timerChange.Stop();
        }
    }
}
