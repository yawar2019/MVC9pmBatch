using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

    }
}