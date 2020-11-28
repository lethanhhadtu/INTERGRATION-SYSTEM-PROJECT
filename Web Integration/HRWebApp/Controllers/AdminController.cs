using HRWebApp.Models.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRWebApp.Controllers
{
    public class AdminController : Controller
    {
        TotalEarning total = new TotalEarning();
        // GET: Admin
        public ActionResult Index()
        {
            var data = total.GetAllTotalEarning();
            return View(data);
        }
    }
}