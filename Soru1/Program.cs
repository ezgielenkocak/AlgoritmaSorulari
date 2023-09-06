using System;

namespace Soru1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sınavınızın notunu giriniz");
            double examOne = double.Parse(Console.ReadLine());

            Console.WriteLine("2.Sınavınızın notunu giriniz");
            double examTwo = double.Parse(Console.ReadLine());

            double averageround = (examOne + examTwo) / 2;
            if (averageround < 50)
            {
                Console.WriteLine("3.Sınavınızın notunu giriniz");
                double examThree = double.Parse(Console.ReadLine());

                double averageroundTwo = (examOne + examTwo + examThree) / 3;
                if (averageroundTwo < 50)
                {
                    Console.WriteLine($"{averageround} ile Başarısız oldunuz");
                }
                else
                {
                    Console.WriteLine($"Tebrikler {averageroundTwo} ile geçtiniz");
                }
            }
            else
            {
                Console.WriteLine($"Tebrikler {averageround} ile geçtiniz");
            }

        }
    }
}
