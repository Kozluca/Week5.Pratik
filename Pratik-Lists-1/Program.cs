using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Lists_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;  // renk değişirdik
            Console.WriteLine(" ***  DAVETLİLER  ***");
                                                              // Davetliler adında liste oluşturduk
            List<string> Davetliler = new List<string>() { "Demet AkALIN", "Ebru GÜNDEŞ", "Ajda Pekkan", "Hülya AVŞAR", "Ferdi TAYFUR", "Orhan GENCEBAY", "Metin AKPINAR", "Kemal SUNAL" };
            int number = 0; // number adında int değer tanımladık

            for (int i = 0; i < Davetliler.Count; i++)   // for döngüsü ile davetlileri ve sıra numaralarını yazdırdık
            {
                number++;
                Console.ForegroundColor = ConsoleColor.Red;  // renk değişirdik
                Console.Write($"{number} {"-"}");

                Console.ForegroundColor = ConsoleColor.Cyan;  // renk değişirdik
                Console.WriteLine($" {Davetliler[i]}");

            }
            Console.ReadKey();

        }
    }
}
