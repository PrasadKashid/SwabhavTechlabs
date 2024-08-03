using College.Model;
using ListPOC.Model;

class Program
{
    public static void Main(string[] args)
    {
        CollegeDetails college = new CollegeDetails(1, "TEC ");

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

        Menu.MainMenu(college);
    }
    
}