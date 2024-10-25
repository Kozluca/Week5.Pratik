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
            int[] sayılar = new int[10]; // 10 Elemanlı bir dizi oluşturduk
            int number = 8; // for döngüsü ile rastgele  bir değer atamak için number adında int bir değer tanımladım
            for (int i = 0; i < sayılar.Length; i++) // for döngüsü ile sayılar dizisine elemanları yazdırdık.
            {
                number = number + i;
                sayılar[i] = number;   // sayılar dizisinin i. index ine number değerini atıyoruz
            }
            foreach (var item in sayılar)    // sayılar dizisindeki elemanları yazdırdık
            {
                Console.Write(item+",");
            }
            Console.WriteLine(" ");
            Console.Write("Eklenecek Sayıyı gir:");

            int yeni=Convert.ToInt32(Console.ReadLine());    // yeni eklenecek sayı için karsıdan bir sayı alıyoruz yeni adında
            Array.Resize(ref sayılar, sayılar.Length+1);     // dizinin boyutunu büyüttük
            sayılar[sayılar.Length-1] = yeni;                 // yeni eklenecek olan sayıyı dizinin son elemanı olarak atadık
            Console.WriteLine("Yeni Dizi");
            for (int i = 0; i<sayılar.Length; i++)            // dizinin yeni halini yazdırdık
            {
                Console.WriteLine(sayılar[i]);
            }
            Console.WriteLine("-----Büyükten Küçüğe sıra -----");         
            Array.Sort(sayılar);      // diziyi küçükten büyüğe sıraladık
            Array.Reverse(sayılar);   // diziyi ters çevirdik
            foreach(var item in sayılar )     // diziyi ekrana yazdırdık
            {
                Console.Write(item+" ");
            }
            Console.ReadKey();
        }
    }
}
