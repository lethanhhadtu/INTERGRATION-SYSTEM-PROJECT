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
    
    public partial class Benefit_Plans
    {
        public decimal Benefit_Plan_ID { get; set; }
        public string Plan_Name { get; set; }
        public Nullable<decimal> Deductable { get; set; }
        public Nullable<int> Percentage_CoPay { get; set; }
    }
}