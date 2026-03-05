using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger[] arr = { 0, 1 };

        if (n == 0)
        {
            Console.WriteLine(arr[0]);
        }
        else if (n == 1)
        {
            Console.WriteLine(arr[1]);
        }
        else
        {
            for(int i = 0; i < n - 1; i++)
            {
                BigInteger add = 0;
                BigInteger num = arr[1];

                add = arr[0] + arr[1];
                arr[1] = add;
                arr[0] = num;
            }
            Console.WriteLine(arr[1]);
        }
    }
}