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

        public ActionResult SendinfoByModel() {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Akshay";
            obj.EmpSalary = 21000;

            //object model=obj;
            return View(obj);

        }

        public ActionResult SendMultipleinfoByModel()
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
            obj2.EmpName = "Chaitanya";
            obj2.EmpSalary = 61000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            //object model=obj;
            return View(listObj);

        }

        public ViewResult SendMultipleinfoByModel2()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();
            List<DepartmentModel> listdeptObj = new List<DepartmentModel>();

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
            obj2.EmpName = "Chaitanya";
            obj2.EmpSalary = 61000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Network";

            listdeptObj.Add(dept);
            listdeptObj.Add(dept1);

            EmpDept eobj = new Models.EmpDept();
            eobj.emp = listObj;
            eobj.dept = listdeptObj;

            //object model=obj;
            return View(eobj);

        }

        public RedirectToRouteResult GetMeToGarden()
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

            //return RedirectToAction("Index","Default",new {id=1211 });
            return RedirectToAction("Index", "Default", listObj);
        }


        public RedirectResult getmeHome()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult getmeHome2()
        {
            return Redirect("~/new/SendMultipleinfoByModel2");
        }

        public RedirectToRouteResult getmeHome3()
        {
            return RedirectToRoute("Default1");
        }
        public JsonResult getmeHome4()
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


            return Json(listObj,JsonRequestBehavior.AllowGet);
        }

        public FileResult getmeHome5()
        {
            return File("~/Web.config","text/plain");
        }
        public FileResult getmeHome6()
        {
            return File("~/ActionResult.pdf", "application/pdf");
        }
        public FileResult getmeHome7()
        {
            return File("~/ActionResult.pdf", "application/pdf", "ActionResult.pdf");
        }
        public ActionResult getmeHome8()
        {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Akshay";
            obj.EmpSalary = 21000;

            return View(obj);
        }

        public PartialViewResult getmeHome9()
        {

            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Akshay";
            obj.EmpSalary = 21000;

            return PartialView("_myPartialView", obj);
        }

        public ContentResult getmeMyContent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");


            }
            else if(id==2)
            {
                return Content("<p style='color:red'>Hello World</p>");

            }
            else
            {
                return Content("<script>alert('welcome to my dem')</script>");

            }


        }
    }
}