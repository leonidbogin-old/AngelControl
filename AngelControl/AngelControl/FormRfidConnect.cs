using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelControl {
    public partial class FormRfidConnect : Form {
        public FormRfidConnect() {
            InitializeComponent();
        }

        private void FormRfidConnect_Load(object sender, EventArgs e) {
            PortRefresh();
            comboBoxHandshake.SelectedItem = Properties.Settings.Default.RfidHandshake.ToString();
            comboBoxParity.SelectedItem = Properties.Settings.Default.RfidParity.ToString();
            comboBoxStopBits.SelectedItem = Properties.Settings.Default.RfidStopBits.ToString();
            comboBoxBaudRate.Text = Properties.Settings.Default.RfidBaudRate.ToString();
            comboBoxDataBits.Text = Properties.Settings.Default.RfidDataBits.ToString();
            comboBoxReadTimeout.Text = Properties.Settings.Default.RfidReadTimeout.ToString();
            comboBoxWriteTimeout.Text = Properties.Settings.Default.RfidWriteTimeout.ToString();
            comboBoxBaudRate.SelectedItem = Properties.Settings.Default.RfidPortName;
        }

        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);
            if (m.WParam.ToInt32() == Class.USB.DBT_DEVICEARRIVAL || m.WParam.ToInt32() == Class.USB.DBT_DEVICEREMOVECOMPLETE) {
                PortRefresh();
            }
        }

        private void comboBoxReaderPort_MouseDoubleClick(object sender, MouseEventArgs e) {
            PortRefresh();
        }

        public void PortRefresh() {
            comboBoxPortName.Items.Clear();
            foreach (string portname in System.IO.Ports.SerialPort.GetPortNames()) {
                comboBoxPortName.Items.Add(portname); //добавить порт в список 
            }
            if (comboBoxPortName.Items.Count > 0) comboBoxPortName.SelectedIndex = comboBoxPortName.Items.Count-1;
        }

        private void buttonReaderOpen_Click(object sender, EventArgs e) {
            ReaderOpen();
        }

        private void ReaderOpen() {
            int error = 0;
            int baudRate = 0;
            if (comboBoxPortName.SelectedIndex < 0) {
                MessageBox.Show("'PortName' не выбран.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error++;
            }
            if (!int.TryParse(comboBoxBaudRate.Text, out baudRate)) {
                MessageBox.Show("Значение в 'BaudRate' должно быть числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error++;
            }
            int databits = 0;
            if (!int.TryParse(comboBoxDataBits.Text, out databits)) {
                MessageBox.Show("Значение в 'DataBits' должно быть числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error++;
            }
            Handshake handshake = Convert.Handshake(comboBoxHandshake.Text);
            Parity parity = Convert.Parity(comboBoxParity.Text);
            StopBits stopbits = Convert.StopBits(comboBoxStopBits.Text);
            int readtimeout = 0;
            if (!int.TryParse(comboBoxReadTimeout.Text, out readtimeout)) {
                MessageBox.Show("Значение в 'ReadTime' должно быть числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error++;
            }
            int writetimeout = 0;
            if (!int.TryParse(comboBoxWriteTimeout.Text, out writetimeout)) {
                MessageBox.Show("Значение в 'WriteTime' должно быть числом.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error++;
            }

            Reader.RfidParameters rfid = new Reader.RfidParameters() {
                PortName = comboBoxPortName.Text,
                BaudRate = baudRate,
                DataBits = databits,
                Handshake = handshake,
                Parity = parity,
                StopBits = stopbits,
                ReadTimeout = readtimeout,
                WriteTimeout = writetimeout,
            };
            if (error == 0) {
                if (Reader.Rfid.Open(rfid)) {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else {
                    MessageBox.Show("Ошибка при открытии порта. Проверьте выставленные параметры считывателя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static class Convert {
            public static Handshake Handshake(string str) {
                Handshake handshake;
                switch (str) {
                    case "None": handshake = System.IO.Ports.Handshake.None; break;
                    case "RequestToSend": handshake = System.IO.Ports.Handshake.RequestToSend; break;
                    case "RequestToSendXOnXOff": handshake = System.IO.Ports.Handshake.RequestToSendXOnXOff; break;
                    case "XOnXOff": handshake = System.IO.Ports.Handshake.XOnXOff; break;
                    default: handshake = System.IO.Ports.Handshake.None; break;
                }
                return handshake;
            }

            public static Parity Parity(string str) {
                Parity parity;
                switch (str) {
                    case "None": parity = System.IO.Ports.Parity.None; break;
                    case "Even": parity = System.IO.Ports.Parity.Even; break;
                    case "Mark": parity = System.IO.Ports.Parity.Mark; break;
                    case "Odd": parity = System.IO.Ports.Parity.Odd; break;
                    case "Space": parity = System.IO.Ports.Parity.Space; break;
                    default: parity = System.IO.Ports.Parity.None; break;
                }
                return parity;
            }

            public static StopBits StopBits(string str) {
                StopBits stopBits;
                switch (str) {
                    case "None": stopBits = System.IO.Ports.StopBits.None; break;
                    case "One": stopBits = System.IO.Ports.StopBits.One; break;
                    case "OnePointFive": stopBits = System.IO.Ports.StopBits.OnePointFive; break;
                    case "Two": stopBits = System.IO.Ports.StopBits.Two; break;
                    default: stopBits = System.IO.Ports.StopBits.None; break;
                }
                return stopBits;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //380; 151
        private void linkLabelMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabelMore.Visible = false;
            this.Height = 395;
            label1.Location = new Point(86, 25);
            comboBoxPortName.Location = new Point(170, 26);
            buttonClose.Location = new Point(18, 310);
            buttonReaderOpen.Location = new Point(106, 310);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            comboBoxBaudRate.Visible = true;
            comboBoxDataBits.Visible = true;
            comboBoxHandshake.Visible = true;
            comboBoxParity.Visible = true;
            comboBoxReadTimeout.Visible = true;
            comboBoxWriteTimeout.Visible = true;
            comboBoxStopBits.Visible = true;
        }
    }
}
