using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Data {
    public class Ssh {

        public string lastErrorMeassage = "";
        private SshClient client;
        private ForwardedPortLocal localPort;

        public bool Open(string SshIp, string SshLogin, string SshPassword) {
            lastErrorMeassage = "";
            SshClient client = new SshClient(SshIp, SshLogin, SshPassword);
            localPort = new ForwardedPortLocal("127.0.0.1", 12140, "127.0.0.1", 3306);
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

        public bool OpenSave() {
            return Open(
                    Security.Encryption.DecryptString(Properties.Settings.Default.SshIp),
                    Security.Encryption.DecryptString(Properties.Settings.Default.SshLogin),
                    Security.Encryption.DecryptString(Properties.Settings.Default.SshPassword));
        }

        public void Close() {
            if (!client.IsConnected) {
                if (localPort.IsStarted) localPort.Stop();
                client.Disconnect();
            }
        }
    }
}
