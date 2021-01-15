using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetProject.Controllers
{
    public class ViewDataExampleController : Controller
    {
        // GET: ViewDataExample
        public ActionResult Index()
        {
            //ViewData["id"] = 1211;
            //ViewBag.info2 = "hi";
            TempData["tinfo"] = "prachi";

            return RedirectToAction("Index1");
        }
        public ActionResult Index1()
        {
            //string k = TempData["tinfo"].ToString();
            //string info= ViewData["id"].ToString();
            //string s = ViewBag.info2;
            //TempData.Keep();
            string k = TempData.Peek("tinfo").ToString();

            ViewBag.infotemp = k;
            return View();
        }
    }
}