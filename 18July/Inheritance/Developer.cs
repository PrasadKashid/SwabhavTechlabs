using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Developer : Employee
    {
        public const double PERSONALALLOWANCE = 0.4;
        public const double TRAVELALLOWANCE = 0.3;

        public double basicSalary;
        public Developer(int employeeId, string employeeName,double baseSalary) : base(employeeId, employeeName, baseSalary)
        {
            basicSalary = baseSalary;
        }

        public override string PrintEmployeeDetails()
        {
            double salary = baseSalary + (baseSalary * PERSONALALLOWANCE) + (baseSalary * TRAVELALLOWANCE);
            return "Employee Id is " + employeeId + " \nEmployee Name is " + employeeName + " \nEmployee Salary is " + salary;
        }
    }
}
