using AngelControl.Database;
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
            if (!Reader.Rfid.OpenLast()) {
                FormRfidConnect formRfidConnect = new FormRfidConnect();
                formRfidConnect.ShowDialog();
            }
            if (Reader.Rfid.isOpen()) Log.New(labelLog, "RFID подключен");
            else Log.New(labelLog, "RFID не удалось подключить");

            SshConnect.Open();
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
    }
}
