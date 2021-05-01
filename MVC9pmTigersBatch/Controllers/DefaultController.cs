using MVC9pmTigersBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC9pmTigersBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index(List<EmployeeModel> emp)
        {

            return View(emp);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetail user)
        {
            EmployeeEntities1 db = new EmployeeEntities1();
            var userinfo = db.UserDetails.Where(s => s.UserName == user.UserName).FirstOrDefault();
            if (userinfo != null)
            {
                var validuser = db.UserDetails.Where(s => s.Password == user.Password).FirstOrDefault();
                if (validuser != null)
                {

                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction("UserDashBoard");
                }
                else {

                    return View();
                }
            }
            return View();
        }



        [Authorize]
        public ActionResult UserDashBoard()
        {
            return View();
        }

        [Authorize(Roles="Admin")]
        public ActionResult Contact()
        {
            return View();
        }

        [Authorize(Roles = "Manager")]
        public ActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}