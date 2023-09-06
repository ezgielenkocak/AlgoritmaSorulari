using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets
{
    public class Program
    {
        //Görev, a[0] ile b[0] , a[1] ile b[1] ve a[2] ile b[2] 'yi karşılaştırarak karşılaştırma noktalarını bulmaktır .
        static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);
            Console.WriteLine(string.Join("-", result));

        }
    }
    public class Result
    {
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int A = 0;
            int B = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    A++;
                }
                else if (a[i] < b[i])
                {
                    B++;    
                }
            }
            return new List<int> { A, B };
        }
    }
}
