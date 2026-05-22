using System;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT_Solution.Session_5
{
    internal class Baitap_4_1
    {
        /// <summary>
        /// Write a C# function to find the maximum of three numbers.
        /// </summary>
        /// <param name="a">first params</param>
        /// <param name="b">second params</param>
        /// <param name="c">thỉrd params</param>
        /// <returns></returns>
        static int MaxThreeNumbers(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        static int MaxNumbers(params int[] a)
        {
            int max = a[0];
            foreach (int x in a)
                if (x > max)
                    max = x;
            return max;

        }
        public static void Main(string[] args)
        {
            int max3 = MaxThreeNumbers(5, 9, 3);
            Console.WriteLine("Max of 3 numbers: " + max3);

            int m1 = MaxNumbers(1, 2, 3);
            int m2 = MaxNumbers(1, 4, 8, 5);
            int m3 = MaxNumbers(100);

            Console.WriteLine("Max (1,2,3): " + m1);
            Console.WriteLine("Max (1,4,5,): " + m2);
            Console.WriteLine("Max (100): " + m3);
        }
    }
}