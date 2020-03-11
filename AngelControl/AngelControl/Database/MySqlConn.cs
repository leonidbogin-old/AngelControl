using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Database {
    public static class MySqlConn {
        private static MySqlConnectionStringBuilder MySqlConnectionBuilder = new MySqlConnectionStringBuilder();

        public static void Init(string server, uint port, string userId, string password, string database) {
            MySqlConnectionBuilder = new MySqlConnectionStringBuilder() {
                Server = server,
                Port = port,
                UserID = userId,
                Password = password,
                Database = database,
            };
        }

        public static string GetString() {
            return MySqlConnectionBuilder.ConnectionString;
        }
    }
}
