using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        long[] arr = { 0, 1 };

        if (n == 0)
        {
            Console.WriteLine(arr[0]);
        }
        else
        {
            for(int i = 2; i <= n % 1500000; i++)
            {
                long add = 0;
                long num = arr[1];

                add = (arr[0] + arr[1]) % 1000000;
                arr[1] = add;
                arr[0] = num;
            }
            Console.WriteLine(arr[1]);
        }
    }
}