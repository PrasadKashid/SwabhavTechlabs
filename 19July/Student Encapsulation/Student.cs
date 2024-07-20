using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncap
{
    internal class Student
    {
        private int _studentRollNo;
        private string _studentName;
        private double _studentCgpa;



        public int GetStudentRollNumber() { return _studentRollNo; }

        public string GetStudentName() { return _studentName; }

        public double GetStudentCgpa() { return _studentCgpa * 9.5; }

        public void SetStudentRollNumber(int studentRollNo)
        {
            if (studentRollNo > 0)
            {
                _studentRollNo = studentRollNo;
            }
            else
            {
                Console.WriteLine("Roll number must be positive ");
            }
        }

        public void SetStudentName(string studentName)
        {
            if(studentName.Length < 5)
            {
                _studentName = " ";
            }
            else
            {
                _studentName = studentName;
            }
        }

        public void SetStudentCgpa(double studentCgpa)
        {
            if (1 <= studentCgpa && studentCgpa <= 10)
            {
                _studentCgpa = studentCgpa;
            }
            else
            {
                Console.WriteLine("Enter Valid CGPA");
            }
        }
        public double Percentage()
        {
            return _studentCgpa * 9.5;
        }

    }
}
