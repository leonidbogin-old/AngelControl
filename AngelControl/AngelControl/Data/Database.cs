using AngelControl.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Data {
    public class Database {

        public string lastErrorMeassage = "";
        private MySqlConnection connect;
        
        public bool Open(string server, uint port, string userId, string password, string database) {
            lastErrorMeassage = "";
            MySqlConnectionStringBuilder mySqlConnectionBuilder = new MySqlConnectionStringBuilder() {
                Server = server,
                Port = port,
                UserID = userId,
                Password = password,
                Database = database,
            };
            if (connect != null && connect.State == System.Data.ConnectionState.Open) {
                Close();
            }
            connect = new MySqlConnection(mySqlConnectionBuilder.ConnectionString);
            try {
                connect.Open();
                return true;
            } catch (Exception err) {
                lastErrorMeassage =  err.Message;
                return false;
            }
        }

        public bool OpenSave() {
            return Open(Security.Encryption.DecryptString(Properties.Settings.Default.DatabaseServer),
                        uint.Parse(Security.Encryption.DecryptString(Properties.Settings.Default.DatabasePort)),
                        Security.Encryption.DecryptString(Properties.Settings.Default.DatabaseUserId),
                        Security.Encryption.DecryptString(Properties.Settings.Default.DatabasePassword),
                        Security.Encryption.DecryptString(Properties.Settings.Default.DatabaseName));
        }

        public void Close() {
            if (connect != null && connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

        //Selects//////////////////////////////////////////////////////////////////////////////////////

        public DbDataReader QueryEmployee(string sql) {//Select * from reg
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }

        public User Login(string login, string password) {
            User user = null;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = $@"Select userType, userPassword From user Where userLogin = '{login}'";
            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        if (Security.Hash.VerifyHashedPassword(reader.GetValue(1).ToString(), password)) {
                            user = new Class.User() {
                                UserType = Convert.ToByte(reader.GetValue(0)),
                                UserLogin = login,
                            };
                            break;
                        }
                    }
                }
            }
            return user;
        }
    }
}
