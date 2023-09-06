using System;

namespace Alistirma2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int tutucu = 0;
            Console.WriteLine("Enter a number");
            int number =int.Parse( Console.ReadLine());
            int toplam=0;
            for (int i = 0; i < number; i++)
            {
                if (i%2==1)
                {
                   
                    toplam += i;
                }
            }
            
            Console.WriteLine($"Toplam { toplam}");
        }
    }
}
