using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRWebApp.Models;
namespace HRWebApp.Controllers
{
    public class PayratesController : Controller
    {
        PayratesImplementation payrates = new PayratesImplementation();

        // GET: Payrates
        public ActionResult Index()
        {
            ModelState.Clear();
            return View(payrates.GetPayratesList());
        }

        // GET: Payrates/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Payrates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Payrates/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Payrates/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Payrates/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Payrates/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Payrates/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
