using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp
{
    internal class CalculateCurrency
    {

        public void Currency(int amount)
        {
            int[] notesArray = new int[4] { 2000, 500, 200, 100 };
            string[] notesArray2 = new string[4] { "Two Thousand ", "Five Hundred ", "Two Hundred ", "One Hundred" };

            int[] notesCounterArray = new int[4];

            for (int i = 0; i < 4; i++)
            {
                if(amount >= notesArray[i])
                {
                    notesCounterArray[i] = amount / notesArray[i];
                    amount = amount % notesArray[i];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (notesCounterArray[i] != 0)
                {
                    Console.WriteLine(notesArray2[i] + " : " + notesCounterArray[i]);
                }
            }
        }
    }
}
