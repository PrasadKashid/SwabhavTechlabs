using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class Person
    {
        public const double DEFAULT_HEIGHT = 5;
        public const double DEFAULT_WEIGHT = 50;
        public int personId { get; set; }
        public string personName { get; set; }
        public int personAge { get; set; }
        public double personHeight { get; set; }
        public double personWeight { get; set; }

        public double personBMI {  get; set; }

        public Person(int id, string name, int age) : this(id, name, age, DEFAULT_HEIGHT,DEFAULT_WEIGHT)
        {

        }
        public Person(int id, string name, int age, double height, double weight)
        {
            personId = id;
            personName = name;
            personAge = age;
            personHeight = height;
            personWeight = weight;
            personBMI = CalculateBMI();
        }
        public double CalculateBMI()
        {
            double meterHeight = personHeight * 0.3048;
            double heightSquare = Math.Pow(meterHeight, 2);
            double bmi = personWeight / heightSquare;
            return bmi;
        }

        public string BodyType(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if(bmi > 18.5 && bmi < 24.9) {
                return "Normal";
            }
            return "Overweight";
        }
        public static double PrintPersonBMI(Person[] persons)
        {
            double maxBmi = 0;
            foreach (var person in persons)
            {
                if (person.personBMI > maxBmi)
                    maxBmi = person.personBMI;
            }
            return maxBmi;
        }
    }
}
