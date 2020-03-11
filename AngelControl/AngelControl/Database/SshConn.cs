using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelControl.Database {
    public static class SshConn {
        private static SshClient client;
        private static ForwardedPortLocal localPort;
        public static string lastErrorMeassage = "";

        public static void Init(string ip, string login, string password) {
            client = new SshClient(ip, login, password);
            localPort = new ForwardedPortLocal("127.0.0.1", 12140, "127.0.0.1", 3306);
        }

        public static bool Open() {
            try {
                if (client.IsConnected) {
                    client.Disconnect();
                }
                client.Connect();
                client.AddForwardedPort(localPort);
                localPort.Start();
                return true;
            } catch (Exception err) {
                lastErrorMeassage = err.Message;
                return false;
            }
        }

        public static void Close() {
            if (!client.IsConnected) {
                if (localPort.IsStarted) localPort.Stop();
                client.Disconnect();
            }
        }
    }
}
