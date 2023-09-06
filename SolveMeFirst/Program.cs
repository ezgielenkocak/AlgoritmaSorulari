using System;

namespace SolveMeFirst
{
    public class Program
    {
        //iki tam sayının toplamını hesaplayın
        static void Main(string[] args)
        {
            int value1=Convert.ToInt32(Console.ReadLine());
            int value2=Convert.ToInt32(Console.ReadLine());
            
            int sum=solveMeFirst(value1,value2);
            Console.WriteLine(sum);
        }

        static int solveMeFirst(int a, int b)
        {
            int sum = a + b;
            return sum; 
        }
    }
}
