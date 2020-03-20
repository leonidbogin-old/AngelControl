using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelControl.Views {
    public partial class ControlRfid : UserControl {
        private AngelControl.Menu.RfidMenu rfidMenu;
        public Views.ControlNutrition nutrition;
        public Views.ControlStudy study;
        public Views.ControlMonitor monitor;

        public ControlRfid() {
            InitializeComponent();
            nutrition = new Views.ControlNutrition(); nutrition.Dock = DockStyle.Fill;
            study = new Views.ControlStudy(); study.Dock = DockStyle.Fill;
            monitor = new Views.ControlMonitor(); monitor.Dock = DockStyle.Fill;
            LoadRdifMenu();
        }

        private void Rfid_Load(object sender, EventArgs e) {
            
        }

        private void LoadRdifMenu() {
            rfidMenu = new AngelControl.Menu.RfidMenu();
            ChangeRfidMenu(rfidMenu.index);
        }

        private void ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex index_new) {
            int newY = 4;
            int y = 5;
            switch (rfidMenu.index) {
                case AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition:
                    labelNutrition.Location = new Point(labelNutrition.Location.X, newY);
                    panelNutritionActive.Visible = false;
                    panelNutrition.BackColor = rfidMenu.menuColor;
                    break;
                case AngelControl.Menu.RfidMenu.MenuRfidIndex.study:
                    labelStudy.Location = new Point(labelStudy.Location.X, newY);
                    panelStudyActive.Visible = false;
                    panelStudy.BackColor = rfidMenu.menuColor;
                    break;
                case AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor:
                    labelMonitor.Location = new Point(labelMonitor.Location.X, newY);
                    panelMonitorActive.Visible = false;
                    panelMonitor.BackColor = rfidMenu.menuColor;
                    break;
            }
            panelRfidContent.Controls.Clear();
            switch (index_new) {
                case AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition:
                    labelNutrition.Location = new Point(labelNutrition.Location.X, y);
                    panelRfidContent.Controls.Add(nutrition);
                    panelNutritionActive.Visible = true;
                    panelNutrition.BackColor = rfidMenu.menuColorActive;
                    break;
                case AngelControl.Menu.RfidMenu.MenuRfidIndex.study:
                    labelStudy.Location = new Point(labelStudy.Location.X, y);
                    panelRfidContent.Controls.Add(study);
                    panelStudyActive.Visible = true;
                    panelStudy.BackColor = rfidMenu.menuColorActive;
                    break;
                case AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor:
                    labelMonitor.Location = new Point(labelMonitor.Location.X, y);
                    panelRfidContent.Controls.Add(monitor);
                    panelMonitorActive.Visible = true;
                    panelMonitor.BackColor = rfidMenu.menuColorActive;
                    break;
            }
            rfidMenu.index = index_new;
        }

        private void panelNutrition_MouseEnter(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition)
                panelNutrition.BackColor = rfidMenu.menuColorHover;
        }

        private void panelNutrition_MouseLeave(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition)
                panelNutrition.BackColor = rfidMenu.menuColor;
        }

        private void labelStudy_MouseEnter(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.study)
                panelStudy.BackColor = rfidMenu.menuColorHover;
        }

        private void labelStudy_MouseLeave(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.study)
                panelStudy.BackColor = rfidMenu.menuColor;
        }

        private void labelMonitor_MouseEnter(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor)
                panelMonitor.BackColor = rfidMenu.menuColorHover;
        }

        private void labelMonitor_MouseLeave(object sender, EventArgs e)
        {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor)
                panelMonitor.BackColor = rfidMenu.menuColor;
        }

        private void labelNutrition_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition);
        }

        private void panelNutrition_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition);
        }
        private void panelNutritionActive_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.nutrition);
        }

        private void labelStudy_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.study)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.study);
        }

        private void panelStudy_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.study)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.study);
        }

        private void panelStudyActive_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.study)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.study);
        }

        private void labelMonitor_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor);
        }

        private void panelMonitor_Click(object sender, EventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor);
        }

        private void panelMonitorActive_Paint(object sender, PaintEventArgs e) {
            if (rfidMenu.index != AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor)
                ChangeRfidMenu(AngelControl.Menu.RfidMenu.MenuRfidIndex.monitor);
        }
    }
}
