using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College;

namespace College
{
    class Professor : Person
    {
        public const double TRAVELLING_ALLOWANCE = 0.3;
        public const double HOUSE_RENT_ALLOWANCE = 0.4;
        public double basePay;
        public Professor(int personId, string personAddress, string personDateOfBirth, double basePay) : base(personId, personAddress, personDateOfBirth)
        {
            this.basePay = basePay;
        }

        public double CalculateSalary()
        {
            double salary = basePay + (basePay * TRAVELLING_ALLOWANCE) + (basePay * HOUSE_RENT_ALLOWANCE);
            return salary;
        }

        public override string PrintPersonDetails()
        {
            return (base.PrintPersonDetails() + "\nProfessor salary : " + CalculateSalary());
        }

    }
}