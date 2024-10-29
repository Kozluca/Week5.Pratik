using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IMDB_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Filmler = new List<string>();
            List<double> IMDB = new List<double>();
        Başla:
            Console.WriteLine("Lütfen Film Adı Girin.");
            string FilmAdı = Console.ReadLine();


            Console.WriteLine("Lütfen IMDB Gir");
            double IMDBPuan = Convert.ToDouble(Console.ReadLine());


            Filmler.Add(FilmAdı);
            IMDB.Add(IMDBPuan);
            Console.WriteLine("Başka Film Eklemek İster misin?");
            string cevap = Console.ReadLine();
            string answer = cevap.ToLower();

            if (answer == "evet")
            {
                goto Başla;
            }
            Console.WriteLine("FİLMLER ADI          IMDB PUANI");

            for (int i = 0; i < Filmler.Count; i++)
            {
                Console.WriteLine($"{Filmler[i]} ------------------- {IMDB[i]} ");
            }

            Console.WriteLine("IMDB PUANI  4-9 ARASINDA OLAN FİLMLER");
            for (int i = 0; i < IMDB.Count; i++)
            {
                double a = IMDB[i];
                if (a >= 4 && a <= 9)
                {
                    Console.WriteLine($"{Filmler[i]}-------{a} ");
                }

            }
            Console.ReadKey();
        }

    }
}
