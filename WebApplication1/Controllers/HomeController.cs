using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //[HandleError(View= "InputStringFormatErrorPage")]
        public ActionResult ErrorExample(string id)
        {
            try
            {
                int i = Convert.ToInt32(id);
            }
            catch(Exception ex) {

                throw ex;
            }
            return View();
        }
    }
}