﻿using AdoExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.getEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();

            }
        }

        public ActionResult Edit(int? id)
        {

            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.UpdateEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();

            }
        }

        public ActionResult Delete(int? id)
        {

            EmployeeModel emp = db.getEmployeeById(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();

            }
        }
    }
}