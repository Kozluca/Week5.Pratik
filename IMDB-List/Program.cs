using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();
        Başla:
            Console.WriteLine("Lütfen Film Adı Giriniz");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen IMDB Puanı Giriniz.");
            double rating = Convert.ToDouble(Console.ReadLine());

            MovieList.Add(new Movie(name, rating));

            Console.WriteLine("Yeni Film Eklemek İster misiniz");
            string _answer = Console.ReadLine();
            string answer=_answer.ToLower();
            if (answer == "evet")
            {
                goto Başla;
            }
            Console.WriteLine("---FİLM LİSTESİ---");
            Movie.FilmList(MovieList);

            Console.WriteLine("İYİ FİLMLER");
            Movie.GoodFilms(MovieList);

            Console.WriteLine("A ile Başlayan filmler");
            Movie.FilmsStartsWithA(MovieList);
            Console.ReadKey();
        }
    }
}
