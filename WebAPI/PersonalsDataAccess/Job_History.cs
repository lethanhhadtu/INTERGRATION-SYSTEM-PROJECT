//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalsDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job_History
    {
        public decimal ID { get; set; }
        public decimal Employee_ID { get; set; }
        public string Department { get; set; }
        public string Division { get; set; }
        public Nullable<System.DateTime> Start_Date { get; set; }
        public Nullable<System.DateTime> End_Date { get; set; }
        public string Job_Title { get; set; }
        public Nullable<decimal> Supervisor { get; set; }
        public string Job_Category { get; set; }
        public string Location { get; set; }
        public Nullable<decimal> Departmen_Code { get; set; }
        public Nullable<decimal> Salary_Type { get; set; }
        public string Pay_Period { get; set; }
        public Nullable<decimal> Hours_per_Week { get; set; }
        public Nullable<bool> Hazardous_Training { get; set; }
    }
}
