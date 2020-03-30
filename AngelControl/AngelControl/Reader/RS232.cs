using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Reader {
    public class RS232 {
        private static SerialPort Connect { get; set; }
        public static ModeEnum Mode { get; set; }

        public delegate void MethodContainer(bool open);
        public static event MethodContainer OnChangeRS232;

        static RS232() {
            Mode = ModeEnum.start;
        }

        public static string GetPortName() {
            return Connect.PortName;
        }
        public static bool isOpen() {
            return Connect.IsOpen;
        }

        public static void CheckOpen() {
            if (isOpen()) OnChangeRS232(true);
            else OnChangeRS232(false);
        }

        public static bool Open(RS232Parameters param) {
            try {
                if (Connect != null && Connect.IsOpen) Close();
                Connect = new SerialPort {
                    PortName = param.PortName,
                    BaudRate = param.BaudRate,
                    DataBits = param.DataBits,
                    Handshake = param.Handshake,
                    Parity = param.Parity,
                    StopBits = param.StopBits,
                    ReadTimeout = param.ReadTimeout,
                    WriteTimeout = param.WriteTimeout
                };
                Connect.DataReceived += new SerialDataReceivedEventHandler(Read);
                Connect.Open();
                Save(param);
                //OnChangeRS232(true);
                return true;
            } catch {
                //OnChangeRS232(false);
                return false;
            }
        }
        public static bool OpenLast() {
            RS232Parameters param = new RS232Parameters() {
                PortName = Properties.Settings.Default.RS232PortName,
                BaudRate = Properties.Settings.Default.RS232BaudRate,
                DataBits = Properties.Settings.Default.RS232DataBits,
                Handshake = Properties.Settings.Default.RS232Handshake,
                Parity = Properties.Settings.Default.RS232Parity,
                StopBits = Properties.Settings.Default.RS232StopBits,
                ReadTimeout = Properties.Settings.Default.RS232ReadTimeout,
                WriteTimeout = Properties.Settings.Default.RS232WriteTimeout,
            };
            return Open(param);
        }

        public static void Save(RS232Parameters param) {
            Properties.Settings.Default.RS232PortName = param.PortName;
            Properties.Settings.Default.RS232BaudRate = param.BaudRate;
            Properties.Settings.Default.RS232DataBits = param.DataBits;
            Properties.Settings.Default.RS232Handshake = param.Handshake;
            Properties.Settings.Default.RS232Parity = param.Parity;
            Properties.Settings.Default.RS232StopBits = param.StopBits;
            Properties.Settings.Default.RS232ReadTimeout = param.ReadTimeout;
            Properties.Settings.Default.RS232WriteTimeout = param.WriteTimeout;
            Properties.Settings.Default.Save();
        }

        public static void Close() {
            Connect.Close();
            //OnChangeRS232(false);
        }

        public static void AppClose() {
            Connect.Close();
        }

        private static void Read(object sender, SerialDataReceivedEventArgs e) {
            byte[] data = new byte[14];
            string numcard = "";
            Connect.Read(data, 0, 14);
            for (int i = 1; i < 11; i++) {
                numcard += Convert.ToChar(data[i]);
            }
            System.Windows.MessageBox.Show(numcard);
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
