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
    public partial class FormDatabase : Form {
        public FormDatabase() {
            InitializeComponent();
        }

        private void FormDatabase_Load(object sender, EventArgs e) {
            textBoxDatabaseServer.Text = Encryption.DecryptString(Properties.Settings.Default.DatabaseServer);
            numericUpDownDatabasePort.Value = uint.Parse(Encryption.DecryptString(Properties.Settings.Default.DatabasePort));
            textBoxDatabaseUserId.Text = Encryption.DecryptString(Properties.Settings.Default.DatabaseUserId);
            textBoxDatabasePassword.Text = Encryption.DecryptString(Properties.Settings.Default.DatabasePassword);
            textBoxDatabaseName.Text = Encryption.DecryptString(Properties.Settings.Default.DatabaseName);
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            Database database = new Database();
            if (database.Open(
                    textBoxDatabaseServer.Text,
                    (uint)numericUpDownDatabasePort.Value,
                    textBoxDatabaseUserId.Text,
                    textBoxDatabasePassword.Text,
                    textBoxDatabaseName.Text)) {
                database.Close();
            } else {
                if (MessageBox.Show(
                        "Ошибка подключения к базе данных:\n'" + database.lastErrorMeassage + "'\nВсё равно сохранить?",
                        "Тестовое подключение к базе данных",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error) != DialogResult.Yes) {
                    return;
                }
            }
            Properties.Settings.Default.DatabaseServer = Encryption.EncryptString(textBoxDatabaseServer.Text);
            Properties.Settings.Default.DatabasePort = Encryption.EncryptString(numericUpDownDatabasePort.Value.ToString());
            Properties.Settings.Default.DatabaseUserId = Encryption.EncryptString(textBoxDatabaseUserId.Text);
            Properties.Settings.Default.DatabasePassword = Encryption.EncryptString(textBoxDatabasePassword.Text);
            Properties.Settings.Default.DatabaseName = Encryption.EncryptString(textBoxDatabaseName.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}



    
