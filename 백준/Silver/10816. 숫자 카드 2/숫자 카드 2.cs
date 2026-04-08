using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cards = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int x in cards)
        {
            if (dict.ContainsKey(x))
                dict[x]++;
            else
                dict[x] = 1;
        }

        int m = int.Parse(Console.ReadLine());
        int[] query = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        StringBuilder sb = new StringBuilder();

        foreach (int x in query)
        {
            if (dict.ContainsKey(x))
                sb.Append(dict[x] + " ");
            else
                sb.Append("0 ");
        }

        Console.Write(sb.ToString());
    }
}