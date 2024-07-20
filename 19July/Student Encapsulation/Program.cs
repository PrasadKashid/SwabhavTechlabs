using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetStudentRollNumber(-1);
            student.SetStudentName("Prasad");
            student.SetStudentCgpa(0.3);

            Console.WriteLine("Student Roll Number: " + student.GetStudentRollNumber());
            Console.WriteLine("Student Name: " + student.GetStudentName());
            Console.WriteLine("Student Percentage: " + student.GetStudentCgpa() +" %");
        }
    }
}
