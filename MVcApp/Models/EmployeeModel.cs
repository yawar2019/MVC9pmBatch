using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVcApp.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
    }

    public class DepartmentModel
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
         
    }

    public class EmpDept
    {
        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }

    }
}