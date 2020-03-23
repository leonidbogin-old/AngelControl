using AngelControl.Class;
using AngelControl.Data.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelControl.Data {
    public class Database : IDisposable {

        public string lastErrorMeassage = "";
        private MySqlConnection connect;

        public delegate void MethodContainerDabase(byte status);
        public static event MethodContainerDabase OnChangeDatabase;

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
                OnChangeDatabase(1);
                return true;
            } catch (Exception err) {
                lastErrorMeassage =  err.Message;
                OnChangeDatabase(0);
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
            if (connect != null && connect.State == System.Data.ConnectionState.Open) {
                connect.Close();
                OnChangeDatabase(2);
            }
        }

        private bool disposed = false;

        // реализация интерфейса IDisposable.
        public void Dispose() {
            Dispose(true);
            // подавляем финализацию
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (!disposed) {
                if (disposing) {
                    if (connect != null && connect.State == System.Data.ConnectionState.Open) {
                        Close();
                        connect.Dispose();
                    }
                }
                // освобождаем неуправляемые объекты
                disposed = true;
            }
        }

        // Деструктор
        ~Database() {
            Dispose(false);
        }

        //Selects////////////////////////////////////////////////////////////////////////////////////// 
        public Reg GetRegByNumcard (string whereNumcard) {
            Reg reg = null;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = $@"SELECT id, lname, fname, pname FROM reg WHERE numcard = '{whereNumcard}'";
            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    reader.Read();
                    reg = new Data.Class.Reg() {
                        Id = reader.GetInt32(0),
                        Numcard = whereNumcard,
                        Lname = reader.GetValue(1).ToString(),
                        Fname = reader.GetValue(2).ToString(),
                        Pname = reader.GetValue(3).ToString(),
                    };
                }
            }
            return reg;
        }

        public List<Reg> GetRegs(Reg selectParameters) {
            string where = "";
            if (selectParameters.Lname != null) where += $@" UPPER(lname) LIKE '{selectParameters.Lname.ToUpper()}%'";
            if (selectParameters.Fname != null) where += $@" UPPER(fname) LIKE '{selectParameters.Fname.ToUpper()}%'";
            if (selectParameters.Pname != null) where += $@" UPPER(pname) LIKE '{selectParameters.Pname.ToUpper()}%'";
            if (where.Length > 0) where = "WHERE " + where;

            List<Reg> regs = new List<Reg>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = $@"SELECT id, numcard, lname, fname, pname, birthday FROM reg " + where;
            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        object birthday = reader.GetValue(5);
                        Reg reg = new Reg() {
                            Id = reader.GetInt32(0),
                            Numcard = reader.GetValue(1).ToString(),
                            Lname = reader.GetValue(2).ToString(),
                            Fname = reader.GetValue(3).ToString(),
                            Pname = reader.GetValue(4).ToString(),  
                            Birthday = reader.GetValue(5) != DBNull.Value ? reader.GetDateTime(5) : (DateTime?)null,
                            Age = reader.GetValue(5) != DBNull.Value ? Reg.GetAge(reader.GetDateTime(5)) : null,
                        };
                        regs.Add(reg);
                    }
                }
            }
            return regs;
        }

        public int CountRegs() {
            int count = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = $@"SELECT COUNT(id) FROM reg";
            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    reader.Read();
                    count = reader.GetInt32(0);
                }
            }
            return count;
        }

        public DbDataReader QueryEmployee(string sql) {//Select * from reg
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = sql;
            return cmd.ExecuteReader();
        }

        //public User Login(string login, string password) {
        //    User user = null;
        //    MySqlCommand cmd = new MySqlCommand();
        //    cmd.Connection = connect;
        //    cmd.CommandText = $@"Select userType, userPassword From user Where userLogin = '{login}'";
        //    using (DbDataReader reader = cmd.ExecuteReader()) {
        //        if (reader.HasRows) {
        //            while (reader.Read()) {
        //                if (Security.Hash.VerifyHashedPassword(reader.GetValue(1).ToString(), password)) {
        //                    user = new Class.User() {
        //                        UserType = Convert.ToByte(reader.GetValue(0)),
        //                        UserLogin = login,
        //                    };
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //    return user;
        //}
    }
}
