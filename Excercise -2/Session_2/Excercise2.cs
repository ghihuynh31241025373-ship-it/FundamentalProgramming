using System;
namespace Excercise__2.Session_2
{
    internal class Excercise2
    {
        static void Main(string[] args)
        {
            //1. Print Hello and Name
            Console.WriteLine("Hello: Khac Ghi");
            Console.WriteLine();

            //2. Sum of Two Numbers
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Tong = " + (a + b));
            Console.WriteLine();

            // 3. Divide Two Numbers
            Console.WriteLine("Thuong = " + (a / b));
            Console.WriteLine();

            // 4. Specified Operations Results
            Console.WriteLine("-1 + 4 * 6 = " + (-1 + 4 * 6));
            Console.WriteLine("(35 + 5) % 7 = " + ((35 + 5) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 = " + (14 + -4 * 6 / 11));
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));
            Console.WriteLine();

            //5.Swap Two Numbers
            Console.WriteLine($"Truoc khi hoan doi a = {a}, b = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"Sau khi hoan doi a = {a}, b = {b}");
            //6. Multiply Three Numbers

            Console.Write("Nhap so 1: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so 2: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so 3: ");
            int m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tich = " + (m1 * m2 * m3));
            Console.WriteLine();

            //7. Arithmetic Operations
            Console.WriteLine(m1 + " + " + m2 + " = " + (m1 + m2));
            Console.WriteLine(m1 + " - " + m2 + " = " + (m1 - m2));
            Console.WriteLine(m1 + " x " + m2 + " = " + (m1 * m2));
            Console.WriteLine(m1 + " / " + m2 + " = " + (m1 / m2));
            Console.WriteLine(m1 + " mod " + m2 + " = " + (m1 % m2));
            Console.WriteLine();

            //8. Multiplication Table
            Console.Write("Nhap so de in bang cuu chuong: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(n + " * " + i + " = " + (n * i));
            }
            Console.WriteLine();

            //9.Average of Four Numbers
            Console.WriteLine("Nhap 4 so:");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int x4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Trung binh = " + (x1 + x2 + x3 + x4) / 4);
            Console.WriteLine();

            //10.Specified Formula with Three Numbers
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhap z: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("(x+y)*z = " + ((x + y) * z));
            Console.WriteLine("x*y + y*z = " + (x * y + y * z));
            Console.WriteLine();

            //11. Print Age Message
            Console.Write("Nhap tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban nhin gia hon " + tuoi);
            Console.WriteLine();

            // ===== 12. In số lặp lại =====
            Console.Write("Nhap 1 chu so: ");
            int digit = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", digit);
            Console.WriteLine("{0}{0}{0}{0}", digit);
            Console.WriteLine();

            //14. Celsius to Kelvin and Fahrenheit
            Console.WriteLine("Nhap nhiet do C:");
            int c = int.Parse(Console.ReadLine());
            int kelvin = c + 273;
            int fahrenheit = c * 9 / 5 + 32;
            Console.WriteLine("kelvin= " + kelvin);
            Console.WriteLine("fahrenheit= " + fahrenheit);

            //18. Check Positive and Negative Pair
            Console.Write("Nhap so thu nhat: ");
            int p1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int p2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mot am mot duong? " + ((p1 < 0 && p2 > 0) || (p1 > 0 && p2 < 0)));
            Console.WriteLine();

            //19.Sum or Triple Sum of Integers
            Console.Write("Nhap so thu nhat: ");
            int u = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so thu hai: ");
            int t = int.Parse(Console.ReadLine()!);

            if (u == t)
            {
                int tripleSum = 3 * (u + t);
                Console.WriteLine("Hai so bang nhau.");
                Console.WriteLine("Tong gap 3 = " + tripleSum);
            }
            else
            {
                int sum = u + t;
                Console.WriteLine("Tong = " + sum);
            }

            //20. Absolute Difference or Double It
            Console.Write("Nhap so thu nhat: ");
            int k = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so thu hai: ");
            int l = int.Parse(Console.ReadLine()!);

            int diff = Math.Abs(k - l);

            if (k > l)
                Console.WriteLine("Ket qua = " + (diff * 2));
            else
                Console.WriteLine("Ket qua = " + diff);
            Console.WriteLine();

            //21.Check for 20 or Sum Equals 20
            Console.Write("Nhap so thu nhat: ");
            int a1 = int.Parse(Console.ReadLine()!);

            Console.Write("Nhap so thu hai: ");
            int b1 = int.Parse(Console.ReadLine()!);

            if (a1 == 20 || b1 == 20 || a1 + b1 == 20)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine();
            //22. Check Within 20 of 100 or 200
            Console.Write("Nhap mot so nguyen: ");
            int n1 = int.Parse(Console.ReadLine()!);

            if (Math.Abs(n1 - 100) <= 20 || Math.Abs(n1 - 200) <= 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            //33. Check Multiple of 3 or 7
            Console.Write("Nhap mot so duong: ");
            int h = int.Parse(Console.ReadLine()!);

            if (h % 3 == 0 || n % 7 == 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine();

            //36. Check Integer in Range -10 to 10
            Console.Write("Nhap mot so: ");
            int p = int.Parse(Console.ReadLine()!);

            if (p >= -10 && p <= 10)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            Console.WriteLine();




        }
    }
}