using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

namespace CodeFirstApproach.Models
{

    public class EmployeeContext : DbContext
    {
        public EmployeeContext():base("ConStr") {

        }

        public DbSet<EmployeeModel> employees { get; set; }
    }
}