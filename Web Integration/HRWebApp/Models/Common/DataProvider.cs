using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRWebApp.Models.Common
{
    public class DataProvider
    {
        public static string connectionSTR = @"Data Source=DESKTOP-RNJR8J1\SQLEXPRESS;Initial Catalog=HRAndPayroll;Integrated Security=True";

        private static DataProvider instance;
        public DataProvider()
        {

        }

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set => instance = value;
        }

        public DataTable ExecuteQuery(string query, object[] param = null)
        {
            DataTable dataTable = new DataTable();

            int i = 0;
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {
                connect.Open();

                SqlCommand command = new SqlCommand(query, connect);

                if (param != null)
                {
                    command.CommandType = CommandType.Text;
                    string[] arrParam = query.Split(' ');
                    foreach (string item in arrParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                connect.Close();
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int i = 0;
            int data;
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (param != null)
                {
                    command.CommandType = CommandType.Text;
                    string[] arrParam = query.Split(' ');
                    foreach (string item in arrParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connect.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            int i = 0;
            object data;
            using (SqlConnection connect = new SqlConnection(connectionSTR))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);

                if (param != null)
                {
                    command.CommandType = CommandType.Text;
                    string[] arrParam = query.Split(' ');
                    foreach (string item in arrParam)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, param[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connect.Close();
            }
            return data;
        }
    }
}