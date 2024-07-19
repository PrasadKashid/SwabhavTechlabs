using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = { 1, 2, 3, 4, 5 };
            PrintNumber(arrayOfInt);
            
        }
        public static void PrintNumber(int[] numbersArray)
        {
            foreach (int number in numbersArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
