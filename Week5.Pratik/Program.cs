using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[10];
            int number = 8;
            for (int i = 0; i < sayılar.Length; i++)
            {
                number += i;
                sayılar[i] = number;
            }

            Console.WriteLine("Dizideki sayılar ");
            foreach (var item in sayılar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.Write("Yeni Sayı Gir : ");
            int yeni = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref sayılar, sayılar.Length + 1);
            sayılar[sayılar.Length - 1] = yeni;
            Console.WriteLine("Yeni Dizi");
            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine(sayılar[i]);
            }
            Array.Sort(sayılar);
            Array.Reverse(sayılar);
            Console.WriteLine("Büyükten Küçüğe sıralı");
            foreach (var item in sayılar)
            {
                Console.Write(item + "-");
            }
            Console.ReadKey();
        }
    }
}