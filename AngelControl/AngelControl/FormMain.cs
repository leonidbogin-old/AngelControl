using AngelControl.Data;
using AngelControl.Data.Class;
using AngelControl.Reader;
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
        private Views.ControlReg controlReg;
        private Views.ControlRfid controlRfid;

        public FormMain() {
            InitializeComponent();
            controlReg = new Views.ControlReg { Dock = DockStyle.Fill };
            controlRfid = new Views.ControlRfid { Dock = DockStyle.Fill };
            LoadMenu();
        }

        private void FormMain_Load(object sender, EventArgs e) {
            Ssh.OnChangeSsh += DisplaySsh;
            Database.OnChangeDatabase += DisplayDatabase;
            Rfid.OnChangeRfid += DisplayRfid;
            //Ssh connect
            if (Ssh.OpenSave()) {
                //Test database connect
                using (Database database = new Database()) {
                    if (!database.OpenSave()) {
                        FormSsh formSsh = new FormSsh();
                        formSsh.ShowDialog();
                    }
                }
            } else {
                FormSsh formSsh = new FormSsh();
                formSsh.ShowDialog();
            }
            //Rfid connect
            if (!Reader.Rfid.OpenLast()) {
                FormRfidConnect formRfidConnect = new FormRfidConnect();
                formRfidConnect.ShowDialog();
            }

            //test select
            using (Database database = new Database()) {
                database.OpenSave();
                Reg reg = database.GetRegByNumcard("0005550141");
            }

        }

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.WParam.ToInt32() == Class.USB.DBT_DEVICEARRIVAL) {
                if (!Rfid.isOpen()) Rfid.OpenLast();
                else Rfid.CheckOpen();
            }
            if (m.WParam.ToInt32() == Class.USB.DBT_DEVICEREMOVECOMPLETE) {
                Rfid.CheckOpen();
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
                    panelContent.Controls.Add(controlReg);
                    panelMenuReg.BackColor = mainMenu.menuColorActive; 
                    break;
                case AngelControl.Menu.MainMenu.MenuIndex.rfid:
                    panelContent.Controls.Add(controlRfid);
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
            Ssh.AppClose();
            Rfid.AppClose();
        }

        private void DisplaySsh(bool open) {
            if (open) {
                pictureBoxSsh.Image = Properties.Resources.ssh_icon;
                toolTipSsh.ToolTipIcon = ToolTipIcon.Info;
                toolTipSsh.SetToolTip(pictureBoxSsh, "SSH туннель открыт");
            } else {
                pictureBoxSsh.Image = Properties.Resources.ssh_icon_close;
                toolTipSsh.ToolTipIcon = ToolTipIcon.Error;
                toolTipSsh.SetToolTip(pictureBoxSsh, "SSH туннель отключен");
            }
            Database database = new Database();
            if (database.OpenSave()) {
                database.Close();
                DisplayDatabase(2);
            } else {
                DisplayDatabase(0);
            }
        }

        private bool databaseError = false;
        private void DisplayDatabase(byte status) {
            switch (status) {
                case 1:
                    databaseError = false;
                    pictureBoxDatabase.Image = Properties.Resources.database_search_icon;
                    toolTipDatabase.ToolTipIcon = ToolTipIcon.Info;
                    toolTipDatabase.SetToolTip(pictureBoxDatabase, "База данных работает");
                    break;
                case 2:
                    databaseError = false;
                    pictureBoxDatabase.Image = Properties.Resources.database_ok_icon;
                    toolTipDatabase.ToolTipIcon = ToolTipIcon.Info;
                    toolTipDatabase.SetToolTip(pictureBoxDatabase, "База данных в спящем режиме");
                    break;
                default:
                    databaseError = true;
                    pictureBoxDatabase.Image = Properties.Resources.database_error_icon;
                    toolTipDatabase.ToolTipIcon = ToolTipIcon.Error;
                    toolTipDatabase.SetToolTip(pictureBoxDatabase, "Ошибка базы данных");
                    break;
            }
        }

        private void DisplayRfid(bool open) {
            if (open) {
                pictureBoxRfid.Image = Properties.Resources.rfid_open;
                toolTipRfid.ToolTipIcon = ToolTipIcon.Info;
                toolTipRfid.SetToolTip(pictureBoxRfid, "RFID подключен (" + Rfid.GetPortName() + ")");
            } else {
                pictureBoxRfid.Image = Properties.Resources.rfid_close;
                toolTipRfid.ToolTipIcon = ToolTipIcon.Error;
                toolTipRfid.SetToolTip(pictureBoxRfid, "RFID отключен");
            }
        }

        private void pictureBoxSsh_MouseDown(object sender, MouseEventArgs e) {
            if (Ssh.isOpen()) {
                contextMenuStripSshOpen.Show(pictureBoxSsh, pictureBoxSsh.Location.X + 35, pictureBoxSsh.Location.Y - 58);
            } else {
                FormSsh formSsh = new FormSsh();
                formSsh.ShowDialog();
            }
        }

        private void toolStripMenuItemSshChange_Click(object sender, EventArgs e) {
            Ssh.Close();
            FormSsh formSsh = new FormSsh();
            formSsh.ShowDialog();
        }

        private void toolStripMenuItemSshClose_Click(object sender, EventArgs e) {
            Ssh.Close();
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e) {
            FormDatabase formDatabase = new FormDatabase();
            formDatabase.ShowDialog();
        }

        private void pictureBoxDatabase_MouseDown(object sender, MouseEventArgs e) {
            if (databaseError) {
                FormDatabase formDatabase = new FormDatabase();
                formDatabase.ShowDialog();
            } else {
                contextMenuStripDatabaseOpen.Show(pictureBoxDatabase, pictureBoxDatabase.Location.X - 50, pictureBoxDatabase.Location.Y - 34);
            }
        }

        private void toolStripMenuItemRfidChange_Click(object sender, EventArgs e) {
            Rfid.Close();
            FormRfidConnect formRfidConnect = new FormRfidConnect();
            formRfidConnect.ShowDialog();
        }

        private void toolStripMenuItemCloseRfid_Click(object sender, EventArgs e) {
            Rfid.Close();
        }

        private void pictureBoxRfid_MouseDown(object sender, MouseEventArgs e) {
            if (Rfid.isOpen()) { 
                contextMenuStripRfidOpen.Show(pictureBoxRfid, pictureBoxRfid.Location.X - 85, pictureBoxRfid.Location.Y - 58);
            } else {
                FormRfidConnect formRfidConnect = new FormRfidConnect();
                formRfidConnect.ShowDialog();
            }
        }
    }
}