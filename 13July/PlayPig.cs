using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayPig
{
    internal class Program
    {
        public const int TARGET_SCORE = 20;
        static void Main(string[] args)
        {
            int turnNumber = 0, playerScore = 0;

            while (playerScore < TARGET_SCORE)
            {
                turnNumber += 1;
                int turnScore = 0;
                Console.WriteLine($"TURN {turnNumber}");
                int newPlayerScore = InnerLoop(turnScore, playerScore, turnNumber);
                if (newPlayerScore >= TARGET_SCORE)
                {
                    Console.WriteLine($"You win! You finished in {turnNumber} turns!");
                    Console.WriteLine("Game Over");
                    break;
                }
            }

        }

        public static int InnerLoop(int turnScore, int playerScore, int turnNumber)
        {
            char actionRoll = 'r';
            char actionHold = 'h';
            while (true)
            {
                Console.WriteLine("Enter 'r' to roll again, 'h' to hold.");
                char action = Convert.ToChar(Console.ReadLine());
                if (action == actionRoll)
                {
                    int rolledDiceScore = RandomNumber(1, 7);
                    Console.WriteLine($"You rolled: {rolledDiceScore}");

                    // no score condition
                    if (rolledDiceScore == 1)
                    {
                        Console.WriteLine("Turn over. No score");
                        turnScore = 0;
                        break;
                    }
                    else
                    {
                        //score uodate if greater than 1
                        turnScore += rolledDiceScore;
                        Console.WriteLine($"Your turn score is {turnScore} and your total score is {playerScore}");
                        if (turnScore >= TARGET_SCORE)
                        {
                            playerScore += turnScore;
                            break;
                        }
                    }
                }

                //action hold score add in main score and turn++
                else if (action == actionHold)
                {
                    turnNumber += 1;
                    playerScore += turnScore;
                    Console.WriteLine($"Your turn score is {turnScore} and your total score is {playerScore}");
                    Console.WriteLine($"TURN {turnNumber}");
                }

            }
            return playerScore;
        }
        public static int RandomNumber(int start, int end)
        {
            Random rnd = new Random();
            int rndInt = rnd.Next(start, end);
            return rndInt;
        }
    }
}