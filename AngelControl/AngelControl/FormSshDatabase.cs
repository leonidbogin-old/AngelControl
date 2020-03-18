using AngelControl.Data;
using AngelControl.Security;
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

            Properties.Settings.Default.SshIp = Encryption.EncryptString(textBoxSshIp.Text);
            Properties.Settings.Default.SshLogin = Encryption.EncryptString(textBoxSshLogin.Text);
            Properties.Settings.Default.SshPassword = Encryption.EncryptString(textBoxSshPassword.Text);
            Properties.Settings.Default.DatabaseServer = Encryption.EncryptString(textBoxDatabaseServer.Text);
            Properties.Settings.Default.DatabasePort = Encryption.EncryptString(numericUpDownDatabasePort.Value.ToString());
            Properties.Settings.Default.DatabaseUserId = Encryption.EncryptString(textBoxDatabaseUserId.Text);
            Properties.Settings.Default.DatabasePassword = Encryption.EncryptString(textBoxDatabasePassword.Text);
            Properties.Settings.Default.DatabaseName = Encryption.EncryptString(textBoxDatabaseName.Text);
            Properties.Settings.Default.Save();
        }

        private void buttonTest_Click(object sender, EventArgs e) {
            Ssh ssh = new Ssh();
            Database database = new Database();
            if (ssh.OpenSave() && database.OpenSave()) {
                MessageBox.Show(
                    "Успешно",
                    "Тестовое подключение к базе данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } else {
                MessageBox.Show(
                    "Ошибка подключения к базе данных:\n" + ssh.lastErrorMeassage + database.lastErrorMeassage,
                    "Тестовое подключение к базе данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
