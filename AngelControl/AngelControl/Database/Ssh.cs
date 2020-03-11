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
    public static class Ssh {
        private static SshClient client = new SshClient(Config.Ssh.Ip, Config.Ssh.Login, Config.Ssh.Password);
        private static MySqlConnectionStringBuilder connBuilderIMSoverSSH = new MySqlConnectionStringBuilder();

        public static void Open() {
            connBuilderIMSoverSSH.Server = Config.LocalDatabase.Server;     //Текуший ПК
            connBuilderIMSoverSSH.Port = Config.LocalDatabase.Port;              //Порт, который пробрасываем (Не обязательно такой. Можно пробросить любой свободный)
            connBuilderIMSoverSSH.UserID = Config.LocalDatabase.UserID;
            connBuilderIMSoverSSH.Password = Config.LocalDatabase.Password;
            connBuilderIMSoverSSH.Database = Config.LocalDatabase.Database;

            if (!client.IsConnected) {
                client.Connect();
                //Объявляем и инициализируем пробрасываемый порт
                ForwardedPortLocal port = new ForwardedPortLocal("127.0.0.1", 12140, "127.0.0.1", 3306);  //3306 - порт MySQL
                client.AddForwardedPort(port);
                //Открываем порт
                port.Start();
            }

            MySqlConnection conn = new MySqlConnection(connBuilderIMSoverSSH.ConnectionString);
            try {
                conn.Open();
                QueryEmployee(conn);
                MessageBox.Show("Connection successful!");
                conn.Close();
            } catch (Exception err) {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private static void QueryEmployee(MySqlConnection conn) {
            string sql = "Select * from reg";

            // Создать объект Command.
            MySqlCommand cmd = new MySqlCommand();

            // Сочетать Command с Connection.
            cmd.Connection = conn;
            cmd.CommandText = sql;


            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        MessageBox.Show(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString() + " " + reader.GetValue(2).ToString() + " " + reader.GetValue(3).ToString());
                    }
                }
            }
        }
    }
}
