using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base("ConStr")
        {

        }
        public DbSet<EmployeeModel> EmployeeModeles { get; set; }


    }
}