using System;

namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number=int.Parse(Console.ReadLine());

            int sembol = 1;
            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < sembol; k++)
                {
                    Console.WriteLine("*");
                    sembol++;
                }
               

            }
        }
    }
}
