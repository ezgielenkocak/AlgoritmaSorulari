using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    /*AÇIKLAMA
     * Bir tamsayı dizisi verildiğinde bu dizinin elemanlarının pozitif,negatif ve sıfır oranlarını hesapla
     * Her kesrin ondalık değerini ondalık değerden sonra basamaklarla yeni bir satıra yazdır
     * */
    public class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for piece");
           int piece=int.Parse(Console.ReadLine());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            Result.plusMinus(arr);
        }

       
    }
    public class Result
    {

        public static void plusMinus(List<int> arr)
        {
            double plus = 0; double minus = 0; double zero = 0;
            foreach (int item in arr)
            {
                if (item>0)
                    plus++;
                if(item<0)
                    minus++;
                if(item==0)
                    zero++;
                
            }
            double pos = plus / arr.Count;
            double neg = minus / arr.Count;
            double zer=zero/arr.Count;
            Console.WriteLine(String.Format("{0:0.000000}", pos));
            Console.WriteLine(String.Format("{0:0.000000}", neg));
            Console.WriteLine(String.Format("{0:0.000000}", zer));


        }
    }
}
