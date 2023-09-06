using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace Soru3
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Net;
    using System.Runtime.ConstrainedExecution;

    namespace Soru3
    {
        public class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("ADET GİRİNİZ");
                int score = 0;
                int scoreExtra = 0;
                int adet = int.Parse(Console.ReadLine());
                List<int> list = new List<int>();
                for (int i = 0; i < adet; i++)
                {

                    Console.WriteLine("Puanlarını gir");

                    score = int.Parse(Console.ReadLine());
                    list.Add(score);


                }
                list.Sort();
                list.Reverse();
                list.ForEach(lst => Console.Write($" {lst} - "));
                Console.WriteLine("  \n---------------------------------------------");
                Console.WriteLine("Extra olarak kaç adet puan girmek istiyorsun?");
                int extraAdet = int.Parse(Console.ReadLine());

                for (int j = 0; j < extraAdet; j++)
                {
                    Console.WriteLine("Puanları giriniz ");
                    scoreExtra = int.Parse(Console.ReadLine());
                    list.Add(scoreExtra);
                }
                list.Sort();
                list.Reverse();
                //list.ForEach(lst => Console.Write($" {list.IndexOf(lst)+1}. => {lst} "));

                Console.WriteLine("---------------SKORLAR--------------------");
                int sayac = 0;

                int tutucu=0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != tutucu)
                    {
                        sayac++;

                        Console.WriteLine($"{sayac}. => {list[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"{sayac}. => {list[i]}");
                    }
                    tutucu = list[i];

                }


            }

        }
    }
}







