using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
namespace HRapii.Controllers
{
    public class Connection
    {
        private static Connection instance;
        public Connection()
        {

        }

        public static Connection Instance
        {
            get { if (instance == null) instance = new Connection(); return instance; }
            private set => instance = value;
        }


        public MySqlConnection ConnectPayrollDB()
        {
            string connectionSTR = "server=127.0.0.1;user id=root;database=payroll";
            MySqlConnection connect = new MySqlConnection(connectionSTR);
            return connect;
        }

        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            string connectionSTR = "server=127.0.0.1;user id=root;database=payroll";
            DataTable data = new DataTable();

            using (MySqlConnection connect = new MySqlConnection(connectionSTR))
            {
                connect.Open();

                MySqlCommand command = new MySqlCommand(query, connect);

                if (param != null)
                {
                    int i = 0;
                    string[] crQuery = query.Split(' ');

                    foreach (string item in crQuery)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);

                connect.Close();
            }

            return data;
        }

        public MySqlDataReader ExecuteDataReader(string query, object[] param = null)
        {
            string connectionSTR = "server=127.0.0.1;user id=root;database=payroll";
            MySqlDataReader dataReader;

            using (MySqlConnection connect = new MySqlConnection(connectionSTR))
            {
                connect.Open();

                MySqlCommand command = new MySqlCommand(query, connect);

                if (param != null)
                {
                    int i = 0;
                    string[] crQuery = query.Split(' ');

                    foreach (string item in crQuery)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                dataReader = command.ExecuteReader();
                connect.Close();
            }

            return dataReader;
        }
    }
}