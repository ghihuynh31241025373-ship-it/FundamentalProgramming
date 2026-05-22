using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Solution.Session_5
{
    internal class Baitap4_2
    {
        /// <summary>
        /// Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        /// <param name="n">positive interger</param>
        /// <returns>Giai thừa của một số</returns>
        static long CaculateFactorial(int n)
        {
            //n!=1*2*3*4*...*n
            long gt = 1;
            for (int i = 1; i <= n; i++)
                gt *= i;
            return gt;
        }
        public static void Main1(string[] args)
        {
            int n = 5;
            long gt = CaculateFactorial(5);
            Console.WriteLine($"{n}! ={gt}");
        }
    }
}
