using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using College.Model;

class Program
{
    public static void Main(string[] args)
    {
        CollegeDetails college = new CollegeDetails(1, "Terna Engineering College : ");

        Student student1 = new Student(1, "Prathmesh");
        Student student2 = new Student(2, "Shantanu");

        college.students.Add(student1);
        college.students.Add(student2);

        Professor professor1 = new Professor(101, "Rohit");
        Professor professor2 = new Professor(102, "Samruddhi");

        college.professors.Add(professor1);
        college.professors.Add(professor2);


        Department department1 = new Department(1001, "Computer");
        Department department2 = new Department(1002, "IT");

        college.departments.Add(department1);
        college.departments.Add(department2);


        PrintDetails(college, college.students, college.professors, college.departments);
    }

    public static void PrintDetails(CollegeDetails college, List<Student> students, List<Professor> professors, List<Department> departments)
    {
        Console.WriteLine("College ID : " + college.Id);
        Console.WriteLine("College Name : " + college.Name);

        Console.WriteLine();

        Console.WriteLine("Number of students : " + students.Count);
        Console.WriteLine("Number of Professors : " + professors.Count);
        Console.WriteLine("Number of Departments : " + departments.Count);

        Console.WriteLine();

        foreach (Student student in students)
        {
            Console.WriteLine("Student Id : " + student.StudentId + " Student Name : " + student.StudentName);
        }
        Console.WriteLine();
        foreach (Professor prof in professors)
        {
            Console.WriteLine("Professor Id : " + prof.ProfessorId + " Professor Name : " + prof.ProfessorName);
        }
        Console.WriteLine();
        foreach (Department dept in departments)
        {
            Console.WriteLine("Department Id : " + dept.DeptId + " Department Name : " + dept.DeptName);
        }


       
    }
    public static void PrintList(List<CollegeDetails> colleges)
    {
        foreach(CollegeDetails college in colleges)
        {
            Console.WriteLine($"{college.GetType().Name} Name is " + college.Name + $"{college.GetType().Name} " +college.Id);
        }
    }
}