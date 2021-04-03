using MVC9pmTigersBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC9pmTigersBatch.Controllers
{
    public class NewController : Controller
    {
       public string HelloWorld()
        {
            return "Hello To All";
        }
        public int Age()
        {
            return 52;
        }

        [Route("Mens/Playinggames")]
        [Route("Boys/Playinggames")]
        public ActionResult Toy()
        {
            return View("HappyTest");
        }
        public ActionResult Toy2()
        {
            return View("~/Views/Default/Index.cshtml");
        }
        public string Toy3(int? id)
        {
            return "Welcome to Employee bearing Id:" + id;//domain/controller/actionmethod/id
        }
        public ActionResult SendData()
        {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Pawan";
            obj.EmpSalary = 21000;

            ViewBag.info = obj;

            return View();
        }

        public ActionResult SendMultipleEmployeeData()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Akshay";
            obj.EmpSalary = 21000;


            EmployeeModel obj1 = new Models.EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Vithal";
            obj1.EmpSalary = 31000;

            EmployeeModel obj2 = new Models.EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "VT";
            obj2.EmpSalary = 61000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            ViewBag.info = listObj;
        

            return View();
        }

    }
}