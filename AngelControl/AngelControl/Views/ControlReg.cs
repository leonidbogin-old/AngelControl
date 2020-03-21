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

namespace AngelControl.Views {
    public partial class ControlReg : UserControl { 

        public ControlReg() {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e) {
            dataGridViewReg.CellClick += new DataGridViewCellEventHandler(CellClick);
        }

        public void Select() {
            Reg selectParameters = new Reg();
            if (textBoxLname.Text.Length > 0) selectParameters.Lname = textBoxLname.Text;
            if (textBoxFname.Text.Length > 0) selectParameters.Fname = textBoxFname.Text;
            if (textBoxPname.Text.Length > 0) selectParameters.Pname = textBoxPname.Text;

            using (Database database = new Database()) {
                if (database.OpenSave()) {
                    List<Reg> regs = database.GetRegs(selectParameters);
                    dataGridViewReg.Rows.Clear();
                    foreach (Reg reg in regs) {
                        int rowIndex = this.dataGridViewReg.Rows.Add();
                        var row = this.dataGridViewReg.Rows[rowIndex];
                        row.Cells["ColumnId"].Value = reg.Id < 10 ? "00" + reg.Id : (reg.Id < 100 ? "0" + reg.Id : reg.Id.ToString());
                        row.Cells["ColumnEdit"].Value = Properties.Resources.edit_icon15;
                        row.Cells["ColumnLname"].Value = reg.Lname;
                        row.Cells["ColumnFname"].Value = reg.Fname;
                        row.Cells["ColumnPname"].Value = reg.Pname;

                        //dataGridViewReg.Rows.Add(row);
                    }
                }
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 1) {
                MessageBox.Show("You have selected in image in " + e.RowIndex + " row.");
            }
        }

        //private void CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
        //    if (e.ColumnIndex == 1) {
        //        dataGridViewReg.UserSetCursor.
        //    }
        //}

        private void textBoxLname_TextChanged(object sender, EventArgs e) {
            Select();
        }

        private void textBoxFname_TextChanged(object sender, EventArgs e) {
            Select();
        }

        private void textBoxPname_TextChanged(object sender, EventArgs e) {
            Select();
        }
    }
}
