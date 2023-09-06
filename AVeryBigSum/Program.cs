using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace AVeryBigSum
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter number for piece");
            int piece = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), x => Convert.ToInt64(x));

            long result = Result.aVeryBigSum(ar);
            Console.WriteLine(result);
        }
    }

    public class Result
    {
        public static long aVeryBigSum(long[] ar)
        {
            return ar.Sum();
        }
            
    }
}
