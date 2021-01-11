using MVC9pmBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC9pmBatch.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public int Add()
        {
            int a = 10, b = 20;
            return a + b;

        }

        //public string getName()
        //{
        //    string Name = "Khader";
        //    return "My Name is"+Name;

        //}

        public string getEmpId()
        {
            return "My EmpId is " + Request.QueryString["eid"] + " Name is " + Request.QueryString["Name"] + " Designation:"+ Request.QueryString["designation"];
        }

        public string getName(int id,string Name)
        {
            
            return "My Id is"+ id+ " Name "+ Name;

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User u)
        {
            redchilliEntities db = new redchilliEntities();
            User details= db.Users.Where(x => x.UserName == u.UserName && x.Password == u.Password).FirstOrDefault();
            if (details != null)
            {
                FormsAuthentication.SetAuthCookie(u.UserName, true);
                return Redirect("Index");

            }
            else
            {
                return View();

            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult ContactUS() {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Aboutus()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("Index");
        }
    }
}