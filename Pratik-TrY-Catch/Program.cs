using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_TrY_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsInt = false;    
            while (!IsInt)                              // while döngüsü başlattık bool doğru olana kadar tekrar edecek
            {
                try
                {
                    Console.WriteLine("Bir Sayı Gir.");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int result = number * number;                   // girilen sayının karesini yazdırdık

                    Console.WriteLine($"Sonuç : {result}");
                    IsInt = true;
                }
                catch (Exception ex)             // hatalı giriş durumunda geri verilecek mesajı yazdırdık
                {
                    Console.WriteLine("Hatalı Veri Girdiniz.");
                }

            }

            Console.ReadKey();
        }

    }
}
