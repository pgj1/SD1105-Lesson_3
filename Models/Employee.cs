using System;
using System.Collections.Generic;

namespace Sakila.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Gender { get; set; }
        public string StateCode { get; set; }
        public decimal Salary { get; set; }
    }
}
