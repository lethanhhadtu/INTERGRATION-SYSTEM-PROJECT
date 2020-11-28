using HRWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HRWebApp.DAO
{
    public class AccountModel
    {
        private HRDB context = null;

        public AccountModel()
        {
            context = new HRDB();
        }

        public bool Login(string userName, string password)
        {
            var arr = new object[]
            {
                new SqlParameter("@userName",userName),
                new SqlParameter("@password",password)
            };
            var res = 0;
            try
            {

                res = context.Database.SqlQuery<int>("EXEC USP_Account_Login @userName,@password", arr).SingleOrDefault();

            }
            catch (Exception)
            {

            }
            return res == 1 ? true : false;
        }
    }
}