using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition addition = new Addition();
            double doubleSum =  addition.Add(12.5, 15.6, 10.5);
            int intsum = addition.Add(15, 20);
            Console.WriteLine("Overloading:");
            Console.WriteLine("Double sum "+doubleSum);
            Console.WriteLine("int sum" +intsum);
        }
    }

    public class Addition
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public double Add(double number1, double number2, double number3)
        { 
            return number1 + number2 + number3 ;
        }
    }
}
