using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorProject.Controllers
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
        [OutputCache(Duration =20)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
     
        public ActionResult GetSomeError(string id)
        {
            try
            {
                int a=10, b=12;
                int c = Convert.ToInt32(id) / b;

            }
            catch(Exception ex)
            {
                throw ex;
            }

            return Content("Success");
        }
    }
}