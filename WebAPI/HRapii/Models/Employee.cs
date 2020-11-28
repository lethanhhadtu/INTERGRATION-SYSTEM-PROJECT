using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HRapii.Models
{
    public class Employee
    {
        private int Employee_Number;
        private int idEmployee;
        private string Last_Name;
        private string First_Name;
        private int SSN;
        private float Pay_Rate;
        private int PayRates_id;
        private int Vacation_Days;
        private int Paid_To_Date;
        private int Paid_Last_Year;


        public Employee(int employee_Number, int idEmployee, string last_Name, string first_Name, int sSN, float pay_Rate, int priPayRates_id, int vacation_Days, int paid_To_Date, int paid_Last_Year)
        {
            this.Employee_Number = employee_Number;
            this.IdEmployee = idEmployee;
            this.Last_Name = last_Name;
            this.First_Name = first_Name;
            this.SSN = sSN;
            this.Pay_Rate = pay_Rate;
            this.PayRates_id = priPayRates_id;
            this.Vacation_Days = vacation_Days;
            this.Paid_To_Date = paid_To_Date;
            this.Paid_Last_Year = paid_Last_Year;
        }

        public Employee(MySqlDataReader row)
        {
            this.Employee_Number = Convert.ToInt32(row["Employee_Number"]);
            this.IdEmployee = (int)row["IdEmployee"];
            this.Last_Name = row["Last_Name"].ToString();
            this.First_Name = row["First_Name"].ToString();
            this.SSN = Convert.ToInt32(row["SSN"]);
            this.Pay_Rate = float.Parse(row["Pay_Rate"].ToString());
            this.PayRates_id = (int)row["PayRates_id"];
            this.Vacation_Days = (int)row["Vacation_Days"];
            this.Paid_To_Date = Convert.ToInt32(row["Paid_To_Date"]);
            this.Paid_Last_Year = Convert.ToInt32(row["Paid_Last_Year"]);
        }

        public Employee(string last_Name, string first_Name)
        {
            Last_Name = last_Name;
            First_Name = first_Name;
        }

        public int Employee_Number1 { get => Employee_Number; set => Employee_Number = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Last_Name1 { get => Last_Name; set => Last_Name = value; }
        public string First_Name1 { get => First_Name; set => First_Name = value; }
        public int SSN1 { get => SSN; set => SSN = value; }
        public float Pay_Rate1 { get => Pay_Rate; set => Pay_Rate = value; }
        public int PriPayRates_id { get => PayRates_id; set => PayRates_id = value; }
        public int Vacation_Days1 { get => Vacation_Days; set => Vacation_Days = value; }
        public int Paid_To_Date1 { get => Paid_To_Date; set => Paid_To_Date = value; }
        public int Paid_Last_Year1 { get => Paid_Last_Year; set => Paid_Last_Year = value; }
    }
}