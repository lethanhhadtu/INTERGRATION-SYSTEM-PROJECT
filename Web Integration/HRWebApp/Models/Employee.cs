using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApp.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        private int Employee_Number;
        private int idEmployee;
        private string Last_Name;
        private string First_Name;
        private float SSN;
        private string Pay_Rate;
        private int PayRates_id;
        private int Vacation_Days;
        private float Paid_To_Date;
        private float Paid_Last_Year;

        public Employee(int employee_Number, int idEmployee, string last_Name, string first_Name, float sSN, string pay_Rate, int payRates_id, int vacation_Days, float paid_To_Date, float paid_Last_Year)
        {
            Employee_Number1 = employee_Number;
            this.IdEmployee = idEmployee;
            Last_Name1 = last_Name;
            First_Name1 = first_Name;
            SSN1 = sSN;
            Pay_Rate1 = pay_Rate;
            PayRates_id1 = payRates_id;
            Vacation_Days1 = vacation_Days;
            Paid_To_Date1 = paid_To_Date;
            Paid_Last_Year1 = paid_Last_Year;
        }

        public int Employee_Number1 { get => Employee_Number; set => Employee_Number = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Last_Name1 { get => Last_Name; set => Last_Name = value; }
        public string First_Name1 { get => First_Name; set => First_Name = value; }
        public float SSN1 { get => SSN; set => SSN = value; }
        public string Pay_Rate1 { get => Pay_Rate; set => Pay_Rate = value; }
        public int PayRates_id1 { get => PayRates_id; set => PayRates_id = value; }
        public int Vacation_Days1 { get => Vacation_Days; set => Vacation_Days = value; }
        public float Paid_To_Date1 { get => Paid_To_Date; set => Paid_To_Date = value; }
        public float Paid_Last_Year1 { get => Paid_Last_Year; set => Paid_Last_Year = value; }
    }
}