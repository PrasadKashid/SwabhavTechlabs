using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Prasad", "Aurionpro", "Pune");
            Employee employee2 = new Employee("Shantanu", "FESS", "Pune");
            Employee employee3 = new Employee("Prathmesh", "Accenture", "Pune");

            PrintEmployee(employee1);
            PrintEmployee(employee2);
            PrintEmployee(employee3);

        }
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine(employee.PrintEmployeeDetails());
            Console.WriteLine();
        }
    }
}
