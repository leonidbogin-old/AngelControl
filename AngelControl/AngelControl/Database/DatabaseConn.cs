using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Database {
    public class Db {
        private MySqlConnection connect;
        public string lastErrorMeassage;

        public bool Open(string connectString) {
            if (connect != null && connect.State == System.Data.ConnectionState.Open) {
                connect.Close();
            }
            connect = new MySqlConnection(connectString);
            try {
                connect.Open();
                return true;
            } catch (Exception err) {
                lastErrorMeassage =  err.Message;
                return false;
            }
        }

        public void Close() {
            connect.Close();
        }

        public DbDataReader QueryEmployee(string sql) {//Select * from reg
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }
    }
}
