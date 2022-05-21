using BuilderPattern.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Abstract
{
    public abstract class EmployeeBuilder
    {
        protected Employee _employee; //We have defined protected to use in the class we inherited.
        public Employee Employee { get => _employee; }
        public abstract void FirstName(string firstName);
        public abstract void LastName(string lastName);
        public abstract void Salary(decimal salary);
        public abstract void IsManager(bool isManager);
        public abstract string Deparment();
    }
}
