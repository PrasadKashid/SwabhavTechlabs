using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student1 = new Student(1, "Mumbai", "28/June/2003", "Information tech");
            Person professor1 = new Professor(2, "Thane", "15/August/1978", 50000);

            PrintDetails(student1);
            PrintDetails(professor1);
        }

         static void PrintDetails(Person person)
        {
            Console.WriteLine(person.PrintPersonDetails());
            Console.WriteLine();
        }
    }
}
