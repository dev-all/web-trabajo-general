using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneratePDF.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Designation { get; set; }

        public decimal Salary { get; set; }
    }
}