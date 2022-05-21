using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Entity
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public bool IsManager { get; set; }
        public string Department { get; set; }
    }
}
