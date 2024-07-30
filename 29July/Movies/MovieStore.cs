using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagerTask.Model;


namespace MovieApp
{
    internal class MovieStore
    {
        MovieManager movieManager = new MovieManager();

        public MovieStore()
        {
            MoviesMenu();
        }

        public void MoviesMenu()
        {
            Console.WriteLine("Welcome to Movie Store");
            Console.WriteLine("----------------------");
            char choiceContinue = 'y';
            do
            {
                Console.WriteLine("Total Number of movies available : " + MovieManager.movies.Count);
                Console.WriteLine("\n1. Add Movie \n2. Display Movie \n3. Delete Movie \n4. Exit");
                int choice = int.Parse(Console.ReadLine());
                movieManager.MainMenu(choice);
                Console.WriteLine("Do you want to continue Y/N ? ");
                choiceContinue = char.Parse(Console.ReadLine());
            } while (choiceContinue == 'y' || choiceContinue == 'Y');
        }
    }
}
