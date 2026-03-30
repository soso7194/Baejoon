using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            HashSet<int> list1 = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            int n2 = int.Parse(Console.ReadLine());
            List<int> list2 = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n2; i++)
            {
                if (list1.Contains(list2[i]))
                {
                    sb.Append("1 ");
                }
                else
                {
                    sb.Append("0 ");
                }
            }
            Console.WriteLine(sb);
        }
    }
}