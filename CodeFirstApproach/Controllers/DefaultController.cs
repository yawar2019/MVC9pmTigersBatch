﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
namespace CodeFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        EmployeeContext db = new EmployeeContext();
   
        public ActionResult Index()
        {
            return View(db.employees.ToList());
        }
    }
}