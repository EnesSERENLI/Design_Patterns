using BuilderPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete
{
    public class QualityAssurance : EmployeeBuilder
    {
        public QualityAssurance()
        {
            _employee = new Entity.Employee(); //When adding employees, we need to get an instance. otherwise we will get a null reference exception.
        }
        public override string Deparment() => Employee.Department = "Quality Assurace";

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
