using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC9pmTigersBatch.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Display(Name = "Employee Name")]
        [ScaffoldColumn(false)]
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public bool status { get; set; }
    }
}