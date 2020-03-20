using AngelControl.Data;
using AngelControl.Security;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelControl {
    public partial class FormMain : Form {

        private Menu.MainMenu mainMenu;
        private Views.ControlReg reg;
        private Views.ControlRfid rfid;

        public FormMain() {
            InitializeComponent();
            reg = new Views.ControlReg {
                Dock = DockStyle.Fill
            }; rfid = new Views.ControlRfid {
                Dock = DockStyle.Fill
            };
            LoadMenu();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            Ssh.OnChange += DisplaySsh;
            //Ssh connect
            if (Ssh.OpenSave()) {
                //Test database connect
                Database database = new Database();
                if (database.OpenSave()) {
                    database.Close();
                } else {
                    FormSshDatabase formSshDatabase = new FormSshDatabase();
                    formSshDatabase.ShowDialog();
                }
            } else {
                FormSshDatabase formSshDatabase = new FormSshDatabase();
                formSshDatabase.ShowDialog();
            }
            


            //FormSshDatabase formSshDatabase = new FormSshDatabase();
            //formSshDatabase.ShowDialog();
            //this.Close();

            //if (!Reader.Rfid.OpenLast()) {
            //    FormRfidConnect formRfidConnect = new FormRfidConnect();
            //    formRfidConnect.ShowDialog();
            //}
            //if (Reader.Rfid.isOpen()) Log.New(labelLog, "RFID подключен");
            //else Log.New(labelLog, "RFID не удалось подключить");

            //SshConn.Init(Config.Ssh.Ip, Config.Ssh.Login, Config.Ssh.Password);
            //SshConn.Open();

            //MySqlConn.Init(
            //    Config.LocalDatabase.Server,
            //    Config.LocalDatabase.Port,
            //    Config.LocalDatabase.UserID,
            //    Config.LocalDatabase.Password, 
            //    Config.LocalDatabase.Database);
            //DatabaseConn database = new DatabaseConn();
            //if (database.Open(MySqlConn.GetString())) {
            //    Class.User user = database.Login("admin", "admin");
            //    if (user != null) {
            //        MessageBox.Show(user.UserType.ToString());
            //    }
            //    database.Close();
            //} else {
            //    MessageBox.Show(database.lastErrorMeassage, "Ошибка подключения базы данных");
            //}

            //SshConn.Close();

        }

        public static class Log {
            public static void New(Label label, string str) {
                label.Text = str;
            }
        }

        #region MainMenu
        private void LoadMenu() {
            mainMenu = new Menu.MainMenu();
            ChangeMenu(mainMenu.index);
        }
        private void ChangeMenu(Menu.MainMenu.MenuIndex index_new) {
            switch (mainMenu.index) {
                case AngelControl.Menu.MainMenu.MenuIndex.reg: 
                    panelMenuReg.BackColor = mainMenu.menuColor; 
                    break;
                case AngelControl.Menu.MainMenu.MenuIndex.rfid: 
                    panelMenuRfid.BackColor = mainMenu.menuColor; 
                    break;
            }
            panelContent.Controls.Clear();
            switch (index_new) {
                case AngelControl.Menu.MainMenu.MenuIndex.reg:
                    panelContent.Controls.Add(reg);
                    panelMenuReg.BackColor = mainMenu.menuColorActive; 
                    break;
                case AngelControl.Menu.MainMenu.MenuIndex.rfid:
                    panelContent.Controls.Add(rfid);
                    panelMenuRfid.BackColor = mainMenu.menuColorActive; 
                    break;
            }
            mainMenu.index = index_new;
        }
        private void pictureBoxMenuReg_MouseEnter(object sender, EventArgs e){
            if (mainMenu.index != AngelControl.Menu.MainMenu.MenuIndex.reg)
                panelMenuReg.BackColor = mainMenu.menuColorHover;
        }
        private void pictureBoxMenuReg_MouseLeave(object sender, EventArgs e) {
            if (mainMenu.index != AngelControl.Menu.MainMenu.MenuIndex.reg)
                panelMenuReg.BackColor = mainMenu.menuColor;
        }
        private void pictureBoxMenuRfid_MouseEnter(object sender, EventArgs e) {
            if (mainMenu.index != AngelControl.Menu.MainMenu.MenuIndex.rfid)
                panelMenuRfid.BackColor = mainMenu.menuColorHover;
        }
        private void pictureBoxMenuRfid_MouseLeave(object sender, EventArgs e) {
            if (mainMenu.index != AngelControl.Menu.MainMenu.MenuIndex.rfid)
                panelMenuRfid.BackColor = mainMenu.menuColor;
        }
        private void pictureBoxMenuReg_Click(object sender, EventArgs e) {
            if (mainMenu.index != AngelControl.Menu.MainMenu.MenuIndex.reg)
                ChangeMenu(AngelControl.Menu.MainMenu.MenuIndex.reg);
        }
        private void pictureBoxMenuRfid_Click(object sender, EventArgs e) {
            if (mainMenu.index != AngelControl.Menu.MainMenu.MenuIndex.rfid)
                ChangeMenu(AngelControl.Menu.MainMenu.MenuIndex.rfid);
        }
        #endregion

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
            Ssh.Close();
        }

        private void DisplaySsh() {
            if (Ssh.isOpen()) {
                pictureBoxSsh.Image = Properties.Resources.ssh_icon;
                toolTipSsh.ToolTipIcon = ToolTipIcon.None;
                toolTipSsh.SetToolTip(pictureBoxSsh, "SSH туннель работает");
            } else {
                pictureBoxSsh.Image = Properties.Resources.ssh_icon_close;
                toolTipSsh.ToolTipIcon = ToolTipIcon.Error;
                toolTipSsh.SetToolTip(pictureBoxSsh, "SSH туннель отключен");
            }
        }

        private void toolTipSsh_Popup(object sender, PopupEventArgs e) {

        }

        private void pictureBoxSsh_MouseEnter(object sender, EventArgs e) {

        }

        private void pictureBoxSsh_Click(object sender, EventArgs e) {
            
        }

        private void pictureBoxSsh_MouseDown(object sender, MouseEventArgs e) {
            if (Ssh.isOpen())
                contextMenuStripSshOpen.Show(pictureBoxSsh, pictureBoxSsh.Location.X+40, pictureBoxSsh.Location.Y-30);
            else {
                FormSshDatabase formSshDatabase = new FormSshDatabase();
                formSshDatabase.ShowDialog();
            }
                
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e) {
            Ssh.Close();
        }
    }
}



//DbDataReader reader = database.QueryEmployee("Select * from reg");
//                using (reader) {
//                    if (reader.HasRows) {
//                        while (reader.Read()) {
//                            MessageBox.Show(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString());
//                        }
//                    }
//                }