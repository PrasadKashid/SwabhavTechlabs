using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNum = RandomNumber(1, 20);

            Console.WriteLine("Guess the number between 1 to 20: ");
            int guessedNumber = int.Parse(Console.ReadLine());
            int count = 1;
            while(guessedNumber != randomNum)
            {
                if (randomNum > guessedNumber)
                {
                    Console.WriteLine("Enter a greater number: ");
                }
                else if(randomNum < guessedNumber)
                {
                    Console.WriteLine("Enter a Smaller number: ");
                }
                count++;
                Console.WriteLine("Guess the number between 1 to 20: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"You've guessed correct number after {count} attempts");
        }
        public static int RandomNumber(int start, int end)
        {
            Random rnd = new Random();
            int rndInt = rnd.Next(start, end);
            return rndInt;
        }
    }
}
