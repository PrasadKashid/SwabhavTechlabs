using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Developer(1 ," Ramesh", 30000);
            PrintData(employee1);
            Employee employee2 = new Developer(2 ," Suresh", 25000);
            PrintData(employee2);
        }

        static void PrintData(Employee employee)
        {
            string employeeData = employee.PrintEmployeeDetails();
            Console.WriteLine(employeeData);
            Console.WriteLine();
        }
    }
}
