using BuilderPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete
{
    public class HumanResource : EmployeeBuilder
    {
        public HumanResource()
        {
            _employee = new Entity.Employee();
        }
        public override string Deparment() => Employee.Department = "Human Resource";

        public override void FirstName(string firstName)
        {
            Employee.Firstname = firstName;
        }

        public override void IsManager(bool isManager)
        {
            Employee.IsManager = isManager;
        }

        public override void LastName(string lastName)
        {
            Employee.LastName = lastName;
        }

        public override void Salary(decimal salary)
        {
            Employee.Salary = salary;
        }
    }
}
