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
            if (Ssh.isOpen()) {
                Ssh.Close();
            }
            if (!Ssh.Open(
                    textBoxSshIp.Text,
                    textBoxSshLogin.Text,
                    textBoxSshPassword.Text,
                    textBoxSshBoundHost.Text,
                    (uint)numericUpDownSshBoundPort.Value,
                    textBoxSshHost.Text,
                    (uint)numericUpDownSshPort.Value)) {
                if (MessageBox.Show(
                        "Ошибка подключения по SSH:\n'" + Ssh.lastErrorMeassage + "'\nВсё равно сохранить?",
                        "Тестовое подключение по SSH",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) != DialogResult.Yes) {
                    return;
                }
            } 
            Properties.Settings.Default.SshIp = Encryption.EncryptString(textBoxSshIp.Text);
            Properties.Settings.Default.SshLogin = Encryption.EncryptString(textBoxSshLogin.Text);
            Properties.Settings.Default.SshPassword = Encryption.EncryptString(textBoxSshPassword.Text);
            Properties.Settings.Default.SshBoundHost = textBoxSshBoundHost.Text;
            Properties.Settings.Default.SshBoundPort = (uint)numericUpDownSshBoundPort.Value;
            Properties.Settings.Default.SshHost = textBoxSshHost.Text;
            Properties.Settings.Default.SshPort = (uint)numericUpDownSshPort.Value;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void FormSshDatabase_Load(object sender, EventArgs e) {
            textBoxSshIp.Text = Encryption.DecryptString(Properties.Settings.Default.SshIp);
            textBoxSshLogin.Text = Encryption.DecryptString(Properties.Settings.Default.SshLogin);
            textBoxSshPassword.Text = Encryption.DecryptString(Properties.Settings.Default.SshPassword);
            textBoxSshBoundHost.Text = Properties.Settings.Default.SshBoundHost;
            numericUpDownSshBoundPort.Value = Properties.Settings.Default.SshBoundPort;
            textBoxSshHost.Text = Properties.Settings.Default.SshHost;
            numericUpDownSshPort.Value = Properties.Settings.Default.SshPort;
        }
    }
}
