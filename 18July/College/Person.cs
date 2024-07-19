using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Person
    {

        public int personId { get; set; }
        public string personAddress { get; set; }
        public string personDateOfBirth { get; set; }

        public Person() { }

        public Person(int id, string address, string dob)
        {
            personId = id;
            personAddress = address;
            personDateOfBirth = dob;
        }

       public virtual string PrintPersonDetails()
        {
            string classType = GetType().Name;
            return $"{classType} ID is " +personId + $"\n{classType} Address is " +personAddress+ $"\n{classType} DOB is "+personDateOfBirth;
        }
    }
}
