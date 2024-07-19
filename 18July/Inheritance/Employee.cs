using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Employee
    {

        public int employeeId { get; set; }
        public string employeeName { get; set; }

        public double baseSalary { get; set; }

        public Employee() { }

        public Employee(int employeeId, string employeeName, double basicSalary) {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.baseSalary = basicSalary;
        }

        public virtual string PrintEmployeeDetails()
        {
            return "";
        }
    }
}
