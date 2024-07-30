using MovieManagerTask.GlobalException;

namespace MovieManagerTask.Model

{
    public class MovieManager
    {
        public static List<Movie> movies = new List<Movie>();

        public MovieManager()
        {
            movies = SerializeDeserialize.DeserializeData();
        }

        public void MainMenu(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    AddMovie();
                    break;
                case 2:
                    DisplayMovie();
                    break;
                case 3:
                    DeleteMovie();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            SerializeDeserialize.SerializeData(movies);
        }

        public void AddMovie()
        {
            try
            {
                if (movies.Count < 5)
                {
                    Console.WriteLine("Enter the name of movie : ");
                    string movieName = Console.ReadLine();

                    Console.WriteLine("Enter the genre of movie : ");
                    string movieGenre = Console.ReadLine();

                    Console.WriteLine("Enter the year of release of movie : ");
                    int yrOfRelease = int.Parse(Console.ReadLine());

                    string movieId = CreateMovieId(movieName, movieGenre, yrOfRelease);

                    Movie movie = new Movie(movieId, movieName, movieGenre, yrOfRelease);
                    movies.Add(movie);
                    Console.WriteLine("Movie Added Successfully ");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Capacity of movie store is full");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string CreateMovieId(string movieName, string movieGenre, int yrOfRelease)
        {
            string yrOfReleaseStr = yrOfRelease.ToString();
            string stringId = movieName.Substring(0, 2) + movieGenre.Substring(0, 2) + yrOfReleaseStr.Substring(2, 2);
            return stringId;
        }

        public void DisplayMovie()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies to display.");
                return;
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"| {"MovieId",-10}  | {"Movie Name",-10} | {"Genre",-10} | {"Year of Release",10} |");
            Console.WriteLine("-----------------------------------------------------------");


            foreach (Movie movie in movies)
            {
                Console.WriteLine($"| {movie.MovieId,-10}  | {movie.MovieName,-10} | {movie.Genre,-10} | {movie.YearOfRelease,10} |");
                Console.WriteLine("-----------------------------------------------------------");


                //Console.WriteLine("Movie id : " + movie.MovieId);
                //Console.WriteLine("Movie name : " + movie.MovieName);
                //Console.WriteLine("Movie Genre : " + movie.Genre);
                //Console.WriteLine("Year of Release : " + movie.YearOfRelease);
                //Console.WriteLine("-----------------------------");
            }

            //Console.WriteLine("-----------------------------------------------------------");

            //Console.WriteLine($"| {"Total Bill",-10}  | {"",-10} | {"",-10} | {movies.Count,10} |");
            //Console.WriteLine("-----------------------------------------------------------");


        }


        public void DeleteMovie()
        {
            try
            {
                if (movies.Count != 0)
                {
                    Console.WriteLine("Enter the ID of movie : ");
                    string input = Console.ReadLine();

                    int indexToRemove = movies.FindIndex(m => m.MovieId == input);

                    if (indexToRemove != -1)
                    {
                        movies.RemoveAt(indexToRemove);
                        Console.WriteLine("Movie deleted successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Movie not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Movie store is empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
