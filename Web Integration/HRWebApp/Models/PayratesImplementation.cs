using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace HRWebApp.Models
{
    public class PayratesImplementation
    {
        public List<Payrates> GetPayratesList()
        {
            List<Payrates> listProc = new List<Payrates>();
            string mainconn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(mainconn);
            string query = "SELECT * from pay_rates";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            foreach (DataRow item in dataTable.Rows)
            {
                listProc.Add(new Payrates(
                        Convert.ToInt32(item["idPay_Rates"]),
                        item["pay_Rate_Name"].ToString(),
                        Convert.ToInt32(item["value"]),
                        Convert.ToInt32(item["tax_Percentage"]),
                        Convert.ToInt32(item["pay_Type"]),
                        Convert.ToInt32(item["pay_Amount"]),
                        Convert.ToInt32(item["pT_Level_C"])
                    ));
            }

            return listProc;
        }

        public bool InsertPayRates(Benefit_Plans benefit_Plans)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(mainconn);

            string query = "INSERT INTO `pay_rates`(`idPay_Rates`, `Pay_Rate_Name`, `Value`, `Tax_Percentage`, `Pay_Type`, `Pay_Amount`, `PT_Level_C`) VALUES (" + benefit_Plans.Benefit_Plan_ID + ",'" + benefit_Plans.Plan_Name + "'," + benefit_Plans.Deductable + "," + benefit_Plans.Deductable + "," + benefit_Plans.Deductable + "," + benefit_Plans.Deductable + "," + benefit_Plans.Deductable + ")";
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePayRates(decimal idPay_Rates)
        {
            string query = "DELETE FROM `pay_rates` WHERE `idPay_Rates`=" + idPay_Rates;
            string mainconn = ConfigurationManager.ConnectionStrings["MysqlConnection"].ConnectionString;
            MySqlConnection connection = new MySqlConnection(mainconn);

            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int isDeleted = command.ExecuteNonQuery();
            connection.Close();
            if (isDeleted > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}