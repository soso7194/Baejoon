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
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();

                switch (s[0])
                {
                    case "push":
                        list.Add(int.Parse(s[1]));
                        break;

                    case "pop":
                        if (list.Count == 0)
                            sb.AppendLine("-1");
                        else
                        {
                            sb.AppendLine(list[list.Count - 1].ToString());
                            list.RemoveAt(list.Count - 1);
                        }
                        break;

                    case "size":
                        sb.AppendLine(list.Count.ToString());
                        break;

                    case "empty":
                        sb.AppendLine(list.Count == 0 ? "1" : "0");
                        break;

                    case "top":
                        sb.AppendLine(list.Count == 0 ? "-1" : list[list.Count - 1].ToString());
                        break;
                }
            }

            Console.Write(sb.ToString());
        }
    }
}