using HRWebApp.Models.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRWebApp.Models.Implementation
{
    public class EmployeeImplementation
    {
        public bool InsertPayRates(Benefit_Plans benefit_Plans)
        {
            string insertEmployee = "USP_InsertTotalEarning @Plan_Name , @Deductable , @Percentage_CoPay";
            object[] obj = new object[] { benefit_Plans.Plan_Name, benefit_Plans.Deductable, benefit_Plans.Percentage_CoPay };

            int i = DataProvider.Instance.ExecuteNonQuery(insertEmployee, obj);
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteTotalEarning(decimal id)
        {
            string query = "delete Benefit_Plans where Benefit_Plan_ID=" + id;
            int isDeleted = DataProvider.Instance.ExecuteNonQuery(query);

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