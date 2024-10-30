using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_List
{
    public class Movie
    {
        public string Name { get; set; }
        public double Point { get; set; }

        public Movie(string name, double point)
        {
            Name = name;
            Point = point;
        }

        public static void FilmList(List<Movie> movielist)
        {
            foreach (var movie in movielist)
            {
                Console.WriteLine($"Filmin Adı: {movie.Name}    Filmin IMDB Puanı: {movie.Point}");
            }
        }
        public static void GoodFilms(List<Movie> movielist)
        {
            foreach (var movie in movielist)
            {
                if (movie.Point >= 4 && movie.Point <= 9)
                {
                    Console.WriteLine($"{movie.Name} -------- {movie.Point}   ");
                }
            }
        }
        public static void FilmsStartsWithA(List<Movie> movielist)
        {
            foreach (var movie in movielist)
            {
                if (movie.Name.StartsWith("A"))
                {
                    Console.WriteLine($"{movie.Name} ------- {movie.Point}");
                }
            }
        }
    }
}

