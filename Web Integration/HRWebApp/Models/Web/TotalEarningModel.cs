using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRWebApp.Models.Web
{

    public class TotalEarningModel
    {
        [Key]
        private int Employee_ID;
        private int Gender;
        private int Shareholder_Status;
        private string Ethnicity;
        private string Department;
        private DateTime? Hire_Date;
        private DateTime? Termination_Date;

        public TotalEarningModel(int employee_ID, int gender, int shareholder_Status, string ethnicity, string department, DateTime? hire_Date, DateTime? termination_Date)
        {
            Employee_ID1 = employee_ID;
            Gender1 = gender;
            Shareholder_Status1 = shareholder_Status;
            Ethnicity1 = ethnicity;
            Department1 = department;
            Hire_Date1 = hire_Date;
            Termination_Date1 = termination_Date;
        }

        public int Employee_ID1 { get => Employee_ID; set => Employee_ID = value; }
        public int Gender1 { get => Gender; set => Gender = value; }
        public int Shareholder_Status1 { get => Shareholder_Status; set => Shareholder_Status = value; }
        public string Ethnicity1 { get => Ethnicity; set => Ethnicity = value; }
        public string Department1 { get => Department; set => Department = value; }
        public DateTime? Hire_Date1 { get => Hire_Date; set => Hire_Date = value; }
        public DateTime? Termination_Date1 { get => Termination_Date; set => Termination_Date = value; }
    }
}