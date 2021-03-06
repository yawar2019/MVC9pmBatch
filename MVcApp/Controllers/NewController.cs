﻿using MVcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVcApp.MyFilter;
namespace MVcApp.Controllers
{
    [MyCustomFilter]
    public class NewController : Controller
    {
        // GET: New
        public ActionResult NewIndex()
        {
            return Content("Tiger is Alive");
        }
        public ViewResult NewIndex2()
        {
            return View("NewIndex");
        }

        public ViewResult NewIndex3()
        {
            return View("NewIndex");
        }

        private ActionResult NewIndex4() {

            return View();
        }
        public ViewResult NewIndex5()
        {
            string Name = "Prachi";
            ViewBag.info = Name;
            return View();
        }
        public ViewResult NewIndex6()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shoaeib";
            obj.EmpSalary = 90003;

            ViewBag.info = obj;
            return View();
        }

        public ViewResult NewIndex7()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shoaeib";
            obj.EmpSalary = 90003;

         
            return View(obj);// object model = obj;
        }

        public ViewResult NewIndex8()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shoaeib";
            obj.EmpSalary = 90003;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "prachi";
            obj1.EmpSalary = 2345;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1213;
            obj3.EmpName = "khader";
            obj3.EmpSalary = 56003;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj3);

            return View(listObj);// object model = obj;
        }



        public ViewResult NewIndex9(int? id)
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shoaeib";
            obj.EmpSalary = 90003;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "prachi";
            obj1.EmpSalary = 2345;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1213;
            obj3.EmpName = "khader";
            obj3.EmpSalary = 56003;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj3);
            // --------------------------
            List<DepartmentModel> deptlist = new List<DepartmentModel>();
            DepartmentModel dept = new Models.DepartmentModel();
            dept.DeptId = 1;
            dept.DeptName = "IT";

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 2;
            dept1.DeptName = "Network";

            deptlist.Add(dept);
            deptlist.Add(dept1);

            EmpDept empdeptObj = new Models.EmpDept();
            empdeptObj.emp = listObj;
            empdeptObj.dept = deptlist;

            return View(empdeptObj);// object model = obj;
        }

        public RedirectResult gotoYahoo()
        {

            //return Redirect("http://www.yahoo.com");
            return Redirect("~/new/NewIndex9?id=1");
        }
        public JsonResult getJsonData()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Shoaeib";
            obj.EmpSalary = 90003;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 1212;
            obj1.EmpName = "prachi";
            obj1.EmpSalary = 2345;

            EmployeeModel obj3 = new EmployeeModel();
            obj3.EmpId = 1213;
            obj3.EmpName = "khader";
            obj3.EmpSalary = 56003;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj3);


            return Json(listObj,JsonRequestBehavior.AllowGet);

        }

        public ActionResult getmePartialView() {
            StudentModel st = new Models.StudentModel();
            st.sname = "Shoaib";
            StudentModel st1 = new Models.StudentModel();
            st1.sname = "prachi";
            StudentModel st2 = new Models.StudentModel();
            st2.sname = "Khader";

            List<StudentModel> list = new List<Models.StudentModel>();
            list.Add(st);
            list.Add(st1);
            list.Add(st2);

            return View(list);
        }

        public PartialViewResult getmePartialView1()
        {

            return PartialView("_MyPrartialView");
        }

        public FileResult getmeFile() {

            return File("~/Web.config","application/xml","test");
        }

       
        public ActionResult GetMyMethod()
        {
            ViewBag.Player = "Virat";
            
            return View();
        }
    }
}
