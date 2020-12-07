using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVcApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View("~/Views/New/NewIndex.cshtml");
        }

        public string GetEmployeeId(int? id)
        {

            return "My Employee Id :" + id;
        }

        public string GetEmployeesId()
        {

            return "My Employee Id :" + Request.QueryString["Id"]+" Name is "+ Request.QueryString["Name"] + " And Designation"+ Request.QueryString["Designation"];
        }

        public string GetTestShoaib(int EmpId)
        {

            return EmpId.ToString();
        }
    }
}