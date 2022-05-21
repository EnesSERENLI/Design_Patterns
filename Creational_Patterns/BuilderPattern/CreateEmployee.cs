using BuilderPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CreateEmployee
    {
        public void AddEmployee(EmployeeBuilder employee,string firstName,string lastName,decimal salary,bool isManager)
        {
            employee.FirstName(firstName);
            employee.LastName(lastName);
            employee.Salary(salary);
            employee.IsManager(isManager);
        }
    }
}
