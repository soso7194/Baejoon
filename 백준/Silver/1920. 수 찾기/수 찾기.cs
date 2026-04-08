using System;
using System.Reflection;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        int a = int.Parse(Console.ReadLine());
        HashSet<int> set1 = new HashSet<int>(
            Array.ConvertAll(Console.ReadLine().Split(), int.Parse)
        );

        int b = int.Parse(Console.ReadLine());
        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        foreach (int x in arr2)
        {
            if (set1.Contains(x))
                sb.AppendLine("1");
            else
                sb.AppendLine("0");
        }

        Console.Write(sb.ToString());
    }
}