using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine(n % 20000303);
    }
}