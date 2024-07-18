using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to count number of characters ");
            string inputString = Console.ReadLine();
            Console.WriteLine(CountWord(inputString));

        }
        static string CountWord(string inputString)
        {
            
            string[] inputArray = inputString.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return ("Number of words : " + inputArray.Length);

        }
    }
}
