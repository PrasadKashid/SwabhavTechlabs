using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Student : Person
    {
        public string branchName;

        public Student(int personId, string personAddress, string personDateOfBirth, string branch) : base(personId, personAddress, personDateOfBirth)
        {
            branchName = branch;
        }

        public override string PrintPersonDetails()
        {
            return base.PrintPersonDetails() + $"\nStudent branch is "+branchName;
        }
    }
}
