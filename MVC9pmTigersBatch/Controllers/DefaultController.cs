﻿using MVC9pmTigersBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC9pmTigersBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(List<EmployeeModel>  emp)
        {
             
            return View(emp);
        }
    }
}