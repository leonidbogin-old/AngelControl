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
                PortName = Properties.Settings.Default.RfidPortName,
                BaudRate = Properties.Settings.Default.RfidBaudRate,
                DataBits = Properties.Settings.Default.RfidDataBits,
                Handshake = Properties.Settings.Default.RfidHandshake,
                Parity = Properties.Settings.Default.RfidParity,
                StopBits = Properties.Settings.Default.RfidStopBits,
                ReadTimeout = Properties.Settings.Default.RfidReadTimeout,
                WriteTimeout = Properties.Settings.Default.RfidWriteTimeout,
            };
            return Open(rfid);
        }

        public static void Save(RfidParameters rfid) {
            Properties.Settings.Default.RfidPortName = rfid.PortName;
            Properties.Settings.Default.RfidBaudRate = rfid.BaudRate;
            Properties.Settings.Default.RfidDataBits = rfid.DataBits;
            Properties.Settings.Default.RfidHandshake = rfid.Handshake;
            Properties.Settings.Default.RfidParity = rfid.Parity;
            Properties.Settings.Default.RfidStopBits = rfid.StopBits;
            Properties.Settings.Default.RfidReadTimeout = rfid.ReadTimeout;
            Properties.Settings.Default.RfidWriteTimeout = rfid.WriteTimeout;
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
