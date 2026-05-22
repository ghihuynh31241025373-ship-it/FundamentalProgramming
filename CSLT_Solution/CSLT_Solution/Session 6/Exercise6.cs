using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_Solution.Session_6
{
    internal class Exercise6
    {
        // 1. Tính trung bình mảng
        static double AverageArray(int[] a)
        {
            int sum = 0;

            foreach (int x in a)
            {
                sum += x;
            }

            return (double)sum / a.Length;
        }

        // 2. Kiểm tra mảng có chứa giá trị hay không
        static bool ContainsValue(int[] a, int value)
        {
            foreach (int x in a)
            {
                if (x == value)
                {
                    return true;
                }
            }

            return false;
        }

        // 3. Tìm vị trí phần tử trong mảng
        static int FindIndex(int[] a, int value)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        // 4. Xóa phần tử khỏi mảng
        static int[] RemoveElement(int[] a, int value)
        {
            int count = 0;

            foreach (int x in a)
            {
                if (x != value)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;

            foreach (int x in a)
            {
                if (x != value)
                {
                    result[index] = x;
                    index++;
                }
            }

            return result;
        }

        // 5. Tìm Max và Min
        static void FindMaxMin(int[] a)
        {
            int max = a[0];
            int min = a[0];

            foreach (int x in a)
            {
                if (x > max)
                {
                    max = x;
                }

                if (x < min)
                {
                    min = x;
                }
            }

            Console.WriteLine("Max = " + max);
            Console.WriteLine("Min = " + min);
        }

        // 6. Đảo ngược mảng
        static int[] ReverseArray(int[] a)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[a.Length - 1 - i];
            }

            return result;
        }

        // 7. Tìm phần tử trùng lặp
        static void FindDuplicate(int[] a)
        {
            Console.WriteLine("Duplicate values:");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.Write(a[i] + " ");
                        break;
                    }
                }
            }

            Console.WriteLine();
        }

        // 8. Xóa phần tử trùng lặp
        static int[] RemoveDuplicate(int[] a)
        {
            int[] temp = new int[a.Length];
            int count = 0;

            foreach (int x in a)
            {
                bool exists = false;

                for (int i = 0; i < count; i++)
                {
                    if (temp[i] == x)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    temp[count] = x;
                    count++;
                }
            }

            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        // Hàm in mảng
        static void PrintArray(int[] a)
        {
            foreach (int x in a)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Random rd = new Random();

            int[] arr = new int[10];

            // Tạo mảng random
            Console.WriteLine("Random Array:");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 10);
            }

            PrintArray(arr);

            // 1. Average
            Console.WriteLine("Average = " + AverageArray(arr));

            // 2. Contains
            Console.WriteLine("Contains 5: " + ContainsValue(arr, 5));

            // 3. Find Index
            Console.WriteLine("Index of 5 = " + FindIndex(arr, 5));

            // 4. Remove Element
            Console.WriteLine("Remove 5:");
            int[] removeArray = RemoveElement(arr, 5);
            PrintArray(removeArray);

            // 5. Max Min
            FindMaxMin(arr);

            // 6. Reverse Array
            Console.WriteLine("Reverse Array:");
            int[] reverse = ReverseArray(arr);
            PrintArray(reverse);

            // 7. Find Duplicate
            FindDuplicate(arr);

            // 8. Remove Duplicate
            Console.WriteLine("Remove Duplicate:");
            int[] noDuplicate = RemoveDuplicate(arr);
            PrintArray(noDuplicate);
        }
    }
}
