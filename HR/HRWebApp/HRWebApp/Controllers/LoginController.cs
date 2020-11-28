using HRWebApp.DAO;
using HRWebApp.DAO.Session;
using HRWebApp.Models.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRWebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]  //chống việc request liên tục
        //public ActionResult Login(LoginModel model)
        //{
        //    var result = new AccountModel().Login(model.UserName, model.Password);
        //    if (result && ModelState.IsValid)
        //    {
        //        SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
        //        return RedirectToAction("Index", "Admin");
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
        //    }

        //    return View(model);
        //}

        //public ActionResult Logout()
        //{
        //    //FormAuthentication.SignOut();

        //    return RedirectToAction("Login", "Login");
        //}
    }
}