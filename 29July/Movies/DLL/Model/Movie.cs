﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagerTask.Model
{
    public class Movie
    {
        public string MovieId { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public int YearOfRelease { get; set; }

        public Movie() { }

        public Movie(string movieId, string movieName, string genre, int yearOfRelease)
        {
            MovieId = movieId;
            MovieName = movieName;
            Genre = genre;
            YearOfRelease = yearOfRelease;
        }
    }

}
