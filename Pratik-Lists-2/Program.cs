using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Lists_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            List<string> Coffeelist = new List<string>();   // CoffeeList Adında Liste oluşturduk

            for (int i = 0; i < 5; i++)     // for döngüsünü yazdık 5 kere kahve adı almak için
            {
                Console.WriteLine("Lütfen Kahve İsimlerini Girin.");
                string Coffe = Convert.ToString(Console.ReadLine());             // Kahve isimlerini yazdırdık
                string Coffee = Coffe.ToUpper();                                // Girilen Kahve İsimlerini büyük yazdırdık
                Coffeelist.Add(Coffee);                                        // Girilien kahve isimlerini CoffeeList e ekledik

            }
            Console.ForegroundColor = ConsoleColor.Cyan;                        // Renk Değiştirdik
            Console.WriteLine("***** KAHVE LİSTESİ *****");
            foreach (string Kahve in Coffeelist)  
            {
                number++;                                                       // Kahve Numarasını Belirlemek için number ı 1 er 1 er arttırdık.
                Console.ForegroundColor = ConsoleColor.Red;                     // Renk Değiştirdik
                Console.Write($"Kahve - {number}");                             // Kahve numarasını yazdırdık
                Console.ForegroundColor = ConsoleColor.Green;                   // Renk  Değiştirdik.
                Console.WriteLine($" {Kahve}");                                 // Kahve adını yazdırdık.

            }
            Console.ReadKey();



        }
    }
}
