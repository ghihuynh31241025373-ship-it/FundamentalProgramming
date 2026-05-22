using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Solution.Session_5
{
    internal class Baitap4_3
    {
        /// <summary>
        /// Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        /// <param name="number">Là số cần kiểm tra </param>
        /// <returns>true nếu là số nguyên tố, còn không trả về false</returns>
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
        public static void Main3(string[] args)
        {
            int n = 11;
            bool kq = IsPrime(n);
            if (kq)
                Console.WriteLine($"{n} la so ngto");
            else
                Console.WriteLine($"{n} khong la so ngto");
        }
    }
}
