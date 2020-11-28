using HRWebApp.Models.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace HRWebApp.Models.Web
{
    public class TotalEarning
    {
        public IEnumerable<TotalEarningModel> GetAllTotalEarning()
        {
            List<TotalEarningModel> listEmp = new List<TotalEarningModel>();
            string query = "select p.Employee_ID,p.Gender,p.Shareholder_Status,p.Ethnicity,j.Department,e.Hire_Date,e.Termination_Date from Personal as p, Job_History as j,Employment as e where p.Employee_ID=j.Employee_ID and p.Employee_ID=e.Employee_ID";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                listEmp.Add(new TotalEarningModel(
                Convert.ToInt32(item["Employee_ID"]),
                Convert.ToInt32(item["Gender"]),
                Convert.ToInt32(item["Shareholder_Status"]),
                item["Ethnicity"].ToString(),
                item["Department"].ToString(),
                (DateTime?)item["Hire_Date"],
                (DateTime?)item["Termination_Date"]
                ));
            }

            return listEmp;
        }

        public int InsertTotalEarning(TotalEarningModel TotalEarningModel)
        {
            return 1;
        }

    }
}