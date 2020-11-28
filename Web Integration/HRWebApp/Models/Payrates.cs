using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRWebApp.Models
{
    [Table("pay_rates")]
    public class Payrates
    {
        [Key]
        private int idPay_Rates;
        private string pay_Rate_Name;
        private int value;
        private int tax_Percentage;
        private int pay_Type;
        private int pay_Amount;
        private int pT_Level_C;

        public Payrates(int idPay_Rates, string pay_Rate_Name, int value, int tax_Percentage, int pay_Type, int pay_Amount, int pT_Level_C)
        {
            this.IdPay_Rates = idPay_Rates;
            this.Pay_Rate_Name = pay_Rate_Name;
            this.Value = value;
            this.Tax_Percentage = tax_Percentage;
            this.Pay_Type = pay_Type;
            this.Pay_Amount = pay_Amount;
            this.PT_Level_C = pT_Level_C;
        }

        public int IdPay_Rates { get => idPay_Rates; set => idPay_Rates = value; }
        public string Pay_Rate_Name { get => pay_Rate_Name; set => pay_Rate_Name = value; }
        public int Value { get => value; set => this.value = value; }
        public int Tax_Percentage { get => tax_Percentage; set => tax_Percentage = value; }
        public int Pay_Type { get => pay_Type; set => pay_Type = value; }
        public int Pay_Amount { get => pay_Amount; set => pay_Amount = value; }
        public int PT_Level_C { get => pT_Level_C; set => pT_Level_C = value; }
    }
}