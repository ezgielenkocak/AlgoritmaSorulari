using System;
using System.Collections.Generic;

namespace Soru4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane sınıfta derse gireceğinizi söyleyiniz");
            int sinif=int.Parse(Console.ReadLine());

            for (int i = 0; i < sinif; i++)
            {
                Console.WriteLine("Sınıf mevcudunun kaç kişi olması gerektiğini giriniz");
                int mevcut = int.Parse(Console.ReadLine());

                Console.WriteLine("Sınıfta ders işlenmesi için derste olması gereken minimum öğrenci sayısını giriniz");
                int minimum = int.Parse(Console.ReadLine());

                Random rnd = new Random();
                int sayi = 0;
                List<int> listMevcut = new List<int>();

                List<int> listErken = new List<int>();
                List<int> listZamaninda = new List<int>();
                List<int> listGec = new List<int>();
                for (int k = 0; k < mevcut; k++)
                {
                    sayi = rnd.Next(-5, 5);
                    listMevcut.Add(sayi);

                }
                foreach (var item in listMevcut)
                {
                    if (item > 0)
                    {
                        listGec.Add(item);
                        Console.Write($"{item} , ");

                    }
                    else if (item == 0)
                    {
                        listZamaninda.Add(item);
                        Console.Write($"{item} , ");

                    }
                    else
                    {
                        listErken.Add(item);
                        Console.Write($"{item} , ");
                        


                    }
                }
                Console.WriteLine($"\nGeç gelenlerin sayısı: {listGec.Count}");
                Console.WriteLine($"Zamanında gelenlerin sayısı: {listZamaninda.Count}");
                Console.WriteLine($"Erken gelenlerin sayısı:{listErken.Count}");
                Console.WriteLine("\n");
                int sart = listErken.Count + listZamaninda.Count;
                if (sart >= minimum)
                {
                    Console.WriteLine($"Bu sınıfta-------------Ders işlenebilir----------------");
                    Console.WriteLine("\n");

                }
                else
                {
                    Console.WriteLine($"Bu sınıfta ders iptal------------Ders iptal oldu-----------------");
                    Console.WriteLine("\n");


                }
            }
        }
    }
}
