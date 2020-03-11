using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Reader {
    static class Rfid {
        private static SerialPort Connect { get; set; }
        public static ModeEnum Mode { get; set; }

        static Rfid() {
            Mode = ModeEnum.start;
        }

        public static bool isOpen() {
            return Connect.IsOpen;
        }

        public static bool Open(RfidParameters rfid) {
            try {
                if (Connect != null && Connect.IsOpen) Close();
                Connect = new SerialPort();
                Connect.PortName = rfid.PortName;
                Connect.BaudRate = rfid.BaudRate; 
                Connect.DataBits = rfid.DataBits;
                Connect.Handshake = rfid.Handshake;
                Connect.Parity = rfid.Parity;
                Connect.StopBits = rfid.StopBits;
                Connect.ReadTimeout = rfid.ReadTimeout;
                Connect.WriteTimeout = rfid.WriteTimeout;
                Connect.DataReceived += new SerialDataReceivedEventHandler(Read);
                Connect.Open();
                Save(rfid);
                return true;
            }
            catch { return false; }
        }
        public static bool OpenLast() {
            RfidParameters rfid = new RfidParameters() {
                PortName = Properties.Settings.Default.PortName,
                BaudRate = Properties.Settings.Default.BaudRate,
                DataBits = Properties.Settings.Default.DataBits,
                Handshake = Properties.Settings.Default.Handshake,
                Parity = Properties.Settings.Default.Parity,
                StopBits = Properties.Settings.Default.StopBits,
                ReadTimeout = Properties.Settings.Default.ReadTimeout,
                WriteTimeout = Properties.Settings.Default.WriteTimeout,
            };
            return Open(rfid);
        }

        public static void Save(RfidParameters rfid) {
            Properties.Settings.Default.PortName = rfid.PortName;
            Properties.Settings.Default.BaudRate = rfid.BaudRate;
            Properties.Settings.Default.DataBits = rfid.DataBits;
            Properties.Settings.Default.Handshake = rfid.Handshake;
            Properties.Settings.Default.Parity = rfid.Parity;
            Properties.Settings.Default.StopBits = rfid.StopBits;
            Properties.Settings.Default.ReadTimeout = rfid.ReadTimeout;
            Properties.Settings.Default.WriteTimeout = rfid.WriteTimeout;
            Properties.Settings.Default.Save();
        }

        public static void Close() {
            Connect.Close();
        }

        private static void Read(object sender, SerialDataReceivedEventArgs e) {
            byte[] data = new byte[14];
            string numcard = "";
            Connect.Read(data, 0, 14);
            for (int i = 1; i < 11; i++) {
                numcard += Convert.ToChar(data[i]);
            }
            System.Windows.Forms.MessageBox.Show(numcard);
        }

        public enum ModeEnum {
            start,
            reg,
            nutrition,
            study,
            monitor,
        }
    }
}
