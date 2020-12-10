using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoNetProject.Models;
namespace AdoNetProject.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        public EmployeeContext db = new EmployeeContext();
        // GET: EmployeeDetails
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }
           
        }

        [HttpGet]
        public ActionResult Edit(int ? id)
        {
            EmployeeModel emp = db.GetEmployeesById(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            int i = db.SaveEmployee(emp);
            if (i > 0)
            {
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.GetEmployeesById(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            int i = db.DeleteEmployee(id);
            if (i > 0)
            {
                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }

        }
    }
}