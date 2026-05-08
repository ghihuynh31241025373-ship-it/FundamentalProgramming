using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Excercise__2.Session_3
{
    internal class Ex3___2
    {
        static void Main2(string[] args)
        {
            // ================= BÀI 1 =================
            Console.WriteLine("Bai 1: Tinh toan 2 so");
            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap phep toan (+, -, *, x, /): ");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine("Ket qua: " + (a + b)); break;
                case '-': Console.WriteLine("Ket qua: " + (a - b)); break;
                case '*':
                case 'x': Console.WriteLine("Ket qua: " + (a * b)); break;
                case '/':
                    if (b != 0)
                        Console.WriteLine("Ket qua: " + (a / b));
                    else
                        Console.WriteLine("Khong the chia cho 0");
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le");
                    break;
            }

            Console.WriteLine();

            // ================= BÀI 2 =================
            Console.WriteLine("Bai 2: x = y^2 + 2y + 1");
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine("y = " + y + " => x = " + x);
            }

            Console.WriteLine();

            // ================= BÀI 3 =================
            Console.WriteLine("Bai 3: Tinh van toc");

            Console.Write("Nhap quang duong (km): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Nhap gio: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Nhap phut: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.Write("Nhap giay: ");
            int seconds = int.Parse(Console.ReadLine());

            double totalHours = hours + minutes / 60.0 + seconds / 3600.0;
            double kmh = distance / totalHours;
            double miles = distance * 0.621371;
            double mph = miles / totalHours;

            Console.WriteLine("Toc do km/h: " + kmh);
            Console.WriteLine("Toc do miles/h: " + mph);

            Console.WriteLine();

            // ================= BÀI 4 =================
            Console.WriteLine("Bai 4: Hinh cau");

            Console.Write("Nhap ban kinh: ");
            double r = double.Parse(Console.ReadLine());

            double surface = 4 * Math.PI * r * r;
            double volume = 4.0 / 3 * Math.PI * r * r * r;

            Console.WriteLine("Dien tich mat cau: " + surface);
            Console.WriteLine("The tich: " + volume);

            Console.WriteLine();

            // ================= BÀI 5 =================
            Console.WriteLine("Bai 5: Kiem tra ky tu");

            Console.Write("Nhap mot ky tu: ");
            char ch = char.Parse(Console.ReadLine());

            if ("aeiouAEIOU".IndexOf(ch) >= 0)
                Console.WriteLine("La nguyen am");
            else if (char.IsDigit(ch))
                Console.WriteLine("La chu so");
            else
                Console.WriteLine("Ky tu khac");

            Console.WriteLine();

            // ================= BÀI 6 =================
            Console.WriteLine("Bai 6: Chan le");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("So chan");
            else
                Console.WriteLine("So le");

            Console.WriteLine();

            // ================= BÀI 7 =================
            Console.WriteLine("Bai 7: So lon nhat trong 3 so");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int max = n1;
            if (n2 > max) max = n2;
            if (n3 > max) max = n3;

            Console.WriteLine("So lon nhat: " + max);

            Console.WriteLine();

            // ================= BÀI 8 =================
            Console.WriteLine("Bai 8: Goc phan tu");

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            if (x1 > 0 && y1 > 0)
                Console.WriteLine("Quadrant I");
            else if (x1 < 0 && y1 > 0)
                Console.WriteLine("Quadrant II");
            else if (x1 < 0 && y1 < 0)
                Console.WriteLine("Quadrant III");
            else if (x1 > 0 && y1 < 0)
                Console.WriteLine("Quadrant IV");
            else
                Console.WriteLine("Nam tren truc");

            Console.WriteLine();

            // ================= BÀI 9 =================
            Console.WriteLine("Bai 9: Phan loai tam giac");

            int t1 = int.Parse(Console.ReadLine());
            int t2 = int.Parse(Console.ReadLine());
            int t3 = int.Parse(Console.ReadLine());

            if (t1 == t2 && t2 == t3)
                Console.WriteLine("Equilateral");
            else if (t1 == t2 || t2 == t3 || t1 == t3)
                Console.WriteLine("Isosceles");
            else
                Console.WriteLine("Scalene");

            Console.WriteLine();

            // ================= BÀI 10 =================
            Console.WriteLine("Bai 10: Tong va trung binh 10 so");

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }

            Console.WriteLine("Tong: " + sum);
            Console.WriteLine("Trung binh: " + sum / 10.0);

            Console.WriteLine();

            // ================= BÀI 11 =================
            Console.WriteLine("Bai 11: Bang cuu chuong");

            int table = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(table + " x " + i + " = " + (table * i));

            Console.WriteLine();

            // ================= BÀI 12 =================
            Console.WriteLine("Bai 12: In tam giac so");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }

            Console.WriteLine();

            // ================= BÀI 13 =================
            Console.WriteLine("Bai 13: Harmonic series");

            int n = int.Parse(Console.ReadLine());
            double harmonic = 0;

            for (int i = 1; i <= n; i++)
                harmonic += 1.0 / i;

            Console.WriteLine("Tong = " + harmonic);

            Console.WriteLine();

            // ================= BÀI 14 =================
            Console.WriteLine("Bai 14: So hoan hao");

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int temp = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        temp += j;
                }
                if (temp == i)
                    Console.WriteLine(i);
            }

            Console.WriteLine();

            // ================= BÀI 15 =================
            Console.WriteLine("Bai 15: So nguyen to");

            int prime = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (prime <= 1) isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(prime); i++)
                {
                    if (prime % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine("La so nguyen to");
            else
                Console.WriteLine("Khong phai so nguyen to");

            Console.ReadLine();


        }

    }
}
