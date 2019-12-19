using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Praktika_2
{
    public class DBClass
    {
        public SQLiteConnection sql_conn;
        public SQLiteCommand sql_cmd;
        public SQLiteDataReader sql_read;

        public DBClass()
        {
            SetConnection();
        }

        public void SetConnection()
        {
            sql_conn = new SQLiteConnection("Data Source=PraktikaDB.db; Version = 3; New = True; Compress = True; ");

            try
            {
                sql_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: {0}", ex.ToString());
            }
        }

        public void ExecuteQueryInsert(string txtQueryInsert)
        {
            SetConnection();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQueryInsert;
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();
        }

        public string ExecuteQueryRead(string txtQueryRead)
        {
            SetConnection();
            string myreader = null;
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQueryRead;

            sql_read = sql_cmd.ExecuteReader();
            while (sql_read.Read())
            {
                myreader = sql_read.GetString(0);
            }

            return myreader;
        }

        public bool userExists(string Username, string Password)
        {
            int users = 0;

            using (SQLiteCommand sqlite_cmd = sql_conn.CreateCommand())
            {
                sqlite_cmd.CommandText = string.Format("SELECT COUNT(*) FROM Vartotojai WHERE Username='{0}' AND Password='{1}'", Username, Password);

                using (SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader())
                {
                    while (sqlite_datareader.Read())
                        users = sqlite_datareader.GetInt32(0);
                }
            }

            return users > 0 ? true : false;
        }
    }
}
