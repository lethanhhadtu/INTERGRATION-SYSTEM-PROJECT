using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRapii.Models
{
    public class Payrate
    {
        private int idPay_Rates;
        private string Pay_Rate_Name;
        private int Value;
        private int Tax_Percentage;
        private int Pay_Type;
        private int Pay_Amount;
        private int PT_Level_C;

        public int IdPay_Rates { get => idPay_Rates; set => idPay_Rates = value; }
        public string Pay_Rate_Name1 { get => Pay_Rate_Name; set => Pay_Rate_Name = value; }
        public int Value1 { get => Value; set => Value = value; }
        public int Tax_Percentage1 { get => Tax_Percentage; set => Tax_Percentage = value; }
        public int Pay_Type1 { get => Pay_Type; set => Pay_Type = value; }
        public int Pay_Amount1 { get => Pay_Amount; set => Pay_Amount = value; }
        public int PT_Level_C1 { get => PT_Level_C; set => PT_Level_C = value; }

        public Payrate(int idPay_Rates, string pay_Rate_Name, int value, int tax_Percentage, int pay_Type, int pay_Amount, int pT_Level_C)
        {
            this.IdPay_Rates = idPay_Rates;
            Pay_Rate_Name1 = pay_Rate_Name;
            Value1 = value;
            Tax_Percentage1 = tax_Percentage;
            Pay_Type1 = pay_Type;
            Pay_Amount1 = pay_Amount;
            PT_Level_C1 = pT_Level_C;
        }

        public Payrate(MySqlDataReader row)
        {
            this.IdPay_Rates = Convert.ToInt32(row["idPay_Rates"]);
            this.Pay_Rate_Name1 = row["Pay_Rate_Name"].ToString();
            this.Value1 = Convert.ToInt32(row["Value"]);
            this.Tax_Percentage1 = Convert.ToInt32(row["Tax_Percentage"]);
            this.Pay_Type1 = Convert.ToInt32(row["Pay_Type"]);
            this.Pay_Amount1 = Convert.ToInt32(row["Pay_Amount"]);
            this.PT_Level_C1 = Convert.ToInt32(row["PT_Level_C"]);
        }
    }
}