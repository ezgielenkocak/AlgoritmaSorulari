using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleArraySum
{
    public class Program
    {
        //tamsayı dizisi verildiğinde, elemanların toplamını bul
        static void Main(string[] args)
        {
            int arCount=Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar =Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp=>Convert.ToInt32(arTemp)).ToList();

            int result=Result.simpleArraySum(ar);
            Console.WriteLine(result);
        }
    }
    public class Result
    {
        public static int simpleArraySum(List<int> ar)
        {
            int sum = ar.Sum();
            return sum;
        }
    }
}
