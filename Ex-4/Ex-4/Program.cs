internal class Program
{
    static int cong(int x, int y)
    {  return x + y;
    }
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = cong(a, b);
        Console.WriteLine($"{a} + {b} + {c}");
    }
}