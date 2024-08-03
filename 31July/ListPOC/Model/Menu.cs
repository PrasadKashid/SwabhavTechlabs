using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College.Model;

namespace ListPOC.Model
{
    public class Menu
    {
        public static void MainMenu(CollegeDetails college)
        {
            bool checkTrue = true;
            while (checkTrue)
            {
                Console.WriteLine("Choose an option \n1.Add the Data \n2.Delete the data \n3.Update the data \n4.Print the Data \n5.Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddDetails(college);
                        break;
                    case 2:
                        DeleteDetails(college);
                        break;
                    case 3:
                        UpdateDetails(college);
                        break;
                    case 4:
                        PrintDetails(college, college.students, college.professors, college.departments);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        public static void AddDetails(CollegeDetails college)
        {
            Console.WriteLine("Enter the entity to Add \n1.Student \n2.Professor \n3.Department ");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.WriteLine("Enter student ID ");
                    int studId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter student Name ");
                    string studName = Console.ReadLine();

                    college.students.Add(new Student(studId, studName));
                    Console.WriteLine("Student Added successfully ");
                    break;

                case 2:
                    Console.WriteLine("Enter professor ID ");
                    int profId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter student Name ");
                    string profName = Console.ReadLine();

                    college.professors.Add(new Professor(profId, profName));
                    Console.WriteLine("Professor Added successfully ");
                    break;
                case 3:
                    Console.WriteLine("Enter Department ID ");
                    int deptId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter department Name ");
                    string deptName = Console.ReadLine();

                    college.departments.Add(new Department(deptId,deptName));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break ;
            }
        }

        public static void UpdateDetails(CollegeDetails college)
        {
            Console.WriteLine("Enter the type of detail to update \n1.Student \n2.Professor \n3.Department");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ID to update: ");
            int entityId = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Student studentToUpdate = null;
                    foreach (var student in college.students)
                    {
                        if (student.StudentId == entityId)
                        {
                            studentToUpdate = student;
                            break;
                        }
                    }
                    if (studentToUpdate != null)
                    {
                        Console.WriteLine("Enter new name for Student with ID " + entityId + ":");
                        studentToUpdate.StudentName = Console.ReadLine();
                        Console.WriteLine("Student details updated.");
                    }
                    else
                    {
                        Console.WriteLine($"Student with ID {entityId} not found.");
                    }
                    break;

                case 2:
                    Professor professorToUpdate = null;
                    foreach (var professor in college.professors)
                    {
                        if (professor.ProfessorId == entityId)
                        {
                            professorToUpdate = professor;
                            break;
                        }
                    }
                    if (professorToUpdate != null)
                    {
                        Console.WriteLine("Enter new name for Professor with ID " + entityId + ":");
                        professorToUpdate.ProfessorName = Console.ReadLine();
                        Console.WriteLine("Professor details updated.");
                    }
                    else
                    {
                        Console.WriteLine("Professor with ID " + entityId + " not found.");
                    }
                    break;

                case 3:
                    Department departmentToUpdate = null;
                    foreach (var department in college.departments)
                    {
                        if (department.DeptId == entityId)
                        {
                            departmentToUpdate = department;
                            break;
                        }
                    }
                    if (departmentToUpdate != null)
                    {
                        Console.WriteLine("Enter new name for Department with ID " + entityId + ":");
                        departmentToUpdate.DeptName = Console.ReadLine();
                        Console.WriteLine("Department details updated.");
                    }
                    else
                    {
                        Console.WriteLine("Department with ID " + entityId + " not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid type entered.");
                    break;
            }
        }
        public static void DeleteDetails(CollegeDetails college)
        {
            Console.WriteLine("Enter the type of detail to delete \n1.Student \n2.Professor \n3.Department ");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ID of the detail to delete:");
            int id = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    Student studentToRemove = null;
                    foreach (var student in college.students)
                    {
                        if (student.StudentId == id)
                        {
                            studentToRemove = student;
                            break;
                        }
                    }
                    if (studentToRemove != null)
                    {
                        college.students.Remove(studentToRemove);
                        Console.WriteLine("Student with ID " + id + " has been removed.");
                    }
                    else
                    {
                        Console.WriteLine("Student with ID " + id + " not found.");
                    }
                    break;

                case 2:
                    Professor professorToRemove = null;
                    foreach (var professor in college.professors)
                    {
                        if (professor.ProfessorId == id)
                        {
                            professorToRemove = professor;
                            break;
                        }
                    }
                    if (professorToRemove != null)
                    {
                        college.professors.Remove(professorToRemove);
                        Console.WriteLine("Professor with ID " + id + " has been removed.");
                    }
                    else
                    {
                        Console.WriteLine("Professor with ID " + id + " not found.");
                    }
                    break;

                case 3:
                    Department departmentToRemove = null;
                    foreach (var department in college.departments)
                    {
                        if (department.DeptId == id)
                        {
                            departmentToRemove = department;
                            break;
                        }
                    }
                    if (departmentToRemove != null)
                    {
                        college.departments.Remove(departmentToRemove);
                        Console.WriteLine("Department with ID " + id + " has been removed.");
                    }
                    else
                    {
                        Console.WriteLine("Department with ID " + id + " not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid type entered.");
                    break;
            }
        }

        public static void PrintDetails(CollegeDetails college, List<Student> students, List<Professor> professors, List<Department> departments)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{"College Id ",-10} | {"College Name ",-10} |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"{college.Id,-11} | {college.Name,-13} |");
            Console.WriteLine("-----------------------------");

            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Number of students : " + students.Count);
            Console.WriteLine("Number of Professors : " + professors.Count);
            Console.WriteLine("Number of Departments : " + departments.Count);
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"| {"Student Id ",-10} | { "Student Name ", -10} |");
            Console.WriteLine("-------------------------------");
            foreach (Student student in students)
            {
                Console.WriteLine($"| {student.StudentId, -11} | { student.StudentName, -13} |");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"| {"Professor Id ",-10} | { "Professor Name ", -10} |");
            Console.WriteLine("-----------------------------------");
            foreach (Professor prof in professors)
            {
                Console.WriteLine($"| {prof.ProfessorId,-13} | {prof.ProfessorName,-15} |");
            }
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"| {"Department Id ",-10} | {"Department Name ",-10} |");
            Console.WriteLine("-------------------------------------");
            foreach (Department dept in departments)
            {
                Console.WriteLine($"| {dept.DeptId,-14} | {dept.DeptName,-16} |");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }
    }

}
