using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            string inputString = Console.ReadLine();
            inputString = inputString.ToLower();
            Console.WriteLine(IsPalindrome(inputString));
        }
        static string IsPalindrome(string input)
        {
            char[] inputString = input.ToCharArray();
            Array.Reverse(inputString);
            string reverseString = new string(inputString);
            return input == reverseString ? "It's a Palindrome" : "It's not a Palindrome";
        }
    }
}
