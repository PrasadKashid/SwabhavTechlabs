using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4]
            {
                new Player(101, "Rahul", 20),
                new Player(102, "Nitesh", 10),
                new Player(103, "Ramesh", 43),
                new Player(104, "Hitesh", 54),
            };

            Console.WriteLine("Player Details: ");

            Console.WriteLine("Enter player id to get details : ");
            int playerId = int.Parse(Console.ReadLine());
            string selectedPlayer = Player.PrintPlayerDetails(players, playerId);
            Console.WriteLine(selectedPlayer);

            Console.WriteLine(Player.WhoIsElder(players));
        }
    }
}
