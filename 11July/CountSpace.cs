using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence ");
            string inputString = Console.ReadLine();
            Console.WriteLine(CountSpace(inputString));
        }
        static int CountSpace(string input)
        {
            int count = 0;
            foreach (char a in input)
            {
                if (a == ' ')
                    count++;
            }
            return count;
        }
    }

}
