using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0) Console.WriteLine("0");

        StringBuilder sb = new StringBuilder();

        while (n != 0)
        {
            int remainder = n % -2;
            n /= -2;

            if (remainder < 0)
            {
                remainder += 2;
                n += 1;
            }

            sb.Append(remainder);
        }

        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        foreach (char c in arr)
        {
            Console.Write(c);
        }
    }
}