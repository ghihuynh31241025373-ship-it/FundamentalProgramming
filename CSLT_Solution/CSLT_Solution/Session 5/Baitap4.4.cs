using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Solution.Session_5
{
    internal class Baitap4
    {
        /// <summary>
        /// all prime numbers that less than a number (enter prompt keyboard).
        /// </summary>
        /// <param name="n"> là số ...</param>
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void PrintPrimesUnderN(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i},");
            }
        }
        static void PrintFirstNPrimes(int n)
        {
            int dem = 0;
            int so = 2;
            while (dem < 100)
            {
                if (IsPrime(so))
                {
                    Console.Write($"{so},");
                    if (dem % 10 == 9) // xuống dòng sau mỗi 10 số nguyên tố 
                        Console.WriteLine();
                    dem++;
                }
            }
            so++;
        }
        public static void Main4(string[] args)
        {
            int n = 100;
            Console.WriteLine($"Cac so nguyen to nho hon{n}");
            PrintPrimesUnderN(n);
            Console.WriteLine($"{n} la so nguyen to dau tien");
            PrintFirstNPrimes(n);
        }
    }
}
