using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.Model
{
    public class CollegeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Professor> professors = new List<Professor>();
        public List<Department> departments = new List<Department>();
        public List<Student> students = new List<Student>();
        public CollegeDetails(int collegeId, string collegeName)
        {
            Id= collegeId;
            Name= collegeName;
        }
    }
}
