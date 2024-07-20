using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Prasad ", 20);
            Person person2 = new Person(2, "Shantanu", 22, 5.1, 80);
            Person person3 = new Person(3, "Prathmesh", 25, 5.11, 68);
            Person person4 = new Person(4, "Aditya", 22, 5.1, 45);

            
            Person[] persons = new Person[4] { person1, person2, person3,person4 };

            PrintBodyType(person1);
            PrintBodyType(person2);
            PrintBodyType(person3);
            PrintBodyType(person4);
            Console.WriteLine("Highest BMI is "+Person.PrintPersonBMI(persons));
        }



        public static void PrintBodyType(Person person)
        {
            double bmiResult = person.CalculateBMI();
            Console.WriteLine("Your BMI is "+bmiResult);
            Console.WriteLine("Body type : "+person.BodyType(person.CalculateBMI()));
        }
        

    }
}
