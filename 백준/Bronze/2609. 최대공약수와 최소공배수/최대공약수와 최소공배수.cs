using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int gcd = GCD(a, b);
        int lcm = a / gcd * b;

        Console.WriteLine(gcd);
        Console.WriteLine(lcm);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int t = a % b;
            a = b;
            b = t;
        }
        return a;
    }
}