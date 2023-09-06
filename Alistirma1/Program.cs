using System;
using System.Collections.Generic;

namespace Alistirma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Örnek: Adınızı 100 kez ekrana yazdıran programın algoritmasını yazınız.
            #region Örnek1
            Console.WriteLine("Adınızı giriniz");
            string name = Console.ReadLine();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{i}. {name}");
            }
            #endregion

            //Örnek: Klavyeden girilen ismi, girilen sayı kadar ekrana yazdıran programın algoritmasını yazınız.
            #region Örnek2
            Console.WriteLine("İsim giriniz");
            string name2 = Console.ReadLine();

            Console.WriteLine("İsminiz kaç kere ekranda gözüksün");
            int adet = int.Parse(Console.ReadLine());

            int sayac2 = 0; 
        

            for (int i = 0; i < adet; i++)
            {
                sayac2 = i;
                sayac2++;
                
                Console.WriteLine($"{sayac2}.{name2}");
            }
            #endregion

            // Örnek: 0’dan 100’e kadar olan çift sayıları ekrana yazdıran programın algoritmasını yazınız.
            List<int> cift = new List<int>();
            List<int> tek=new List<int> ();

            int tutucu = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i%2==0)
                {
                   cift.Add(i);    
                    Console.WriteLine($"Çift sayılar; \n {cift[i]}");
                }
                else
                {
                    Console.WriteLine("tek");
                }
            }
        }
    }
}
