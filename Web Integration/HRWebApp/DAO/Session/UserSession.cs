using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HRWebApp.DAO.Session
{
    [Serializable] //tuàn tự hóa ra nhị phân
    public class UserSession
    {
        public string UserName { set; get; }
    }
}