using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieManagerTask.Model;
using Newtonsoft.Json;

namespace MovieManagerTask
{
    public class SerializeDeserialize
    {
        static string FilePath = "MoviesData.json";

        public static void SerializeData(List<Movie> list)
        {
            File.WriteAllText("MoviesData.json", JsonConvert.SerializeObject(list));
        }

        public static List<Movie> DeserializeData()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText("MoviesData.json");
                return JsonConvert.DeserializeObject<List<Movie>>(json);
            }
            return new List<Movie>();
        }
    }
}
