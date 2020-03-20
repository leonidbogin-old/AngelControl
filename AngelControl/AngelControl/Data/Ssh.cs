using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelControl.Data {
    public static class Ssh {

        public static string lastErrorMeassage = "";
        private static SshClient client;
        private static ForwardedPortLocal localPort;

        public delegate void MethodContainer(bool open);
        public static event MethodContainer OnChangeSsh;

        public static bool isOpen() {
            return client.IsConnected;
        }

        public static bool Open(
                    string SshIp, string SshLogin, string SshPassword, 
                    string SshBoundHost, uint SshBoundPort, string SshHost, uint SshPort) {

            lastErrorMeassage = "";
            client = new SshClient(SshIp, SshLogin, SshPassword);
            localPort = new ForwardedPortLocal(SshBoundHost, SshBoundPort, SshHost, SshPort);
            try {
                if (client.IsConnected) {
                    Close();
                }
                client.Connect();
                client.AddForwardedPort(localPort);
                localPort.Start();
                OnChangeSsh(true);
                return true;
            } catch (Exception err) {
                lastErrorMeassage = err.Message;
                OnChangeSsh(false);
                return false;
            }
        }

        public static bool OpenSave() {
            return Open(
                    Security.Encryption.DecryptString(Properties.Settings.Default.SshIp),
                    Security.Encryption.DecryptString(Properties.Settings.Default.SshLogin),
                    Security.Encryption.DecryptString(Properties.Settings.Default.SshPassword),
                    Properties.Settings.Default.SshBoundHost,
                    Properties.Settings.Default.SshBoundPort,
                    Properties.Settings.Default.SshHost,
                    Properties.Settings.Default.SshPort);
        }

        public static void Close() {
            localPort.Stop();
            client.Disconnect();
            OnChangeSsh(false);
        }

        public static void AppClose() {
            localPort.Stop();
            client.Disconnect();
        }
    }
}
