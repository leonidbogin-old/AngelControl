using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelControl {
    public partial class FormSshDatabase : Form {
        public FormSshDatabase() {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            //Properties.Settings.Default.SshIp = textBoxSshIp.Text;
        }
    }
}
