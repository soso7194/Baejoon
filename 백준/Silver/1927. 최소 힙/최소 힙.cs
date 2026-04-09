using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            int m = int.Parse(Console.ReadLine());
            if (m == 0)
            {
                if (pq.Count == 0)
                    sb.AppendLine("0");
                else
                {
                    sb.AppendLine(pq.Dequeue().ToString());
                }
            }
            else
            {
                pq.Enqueue(m, m);
            }
        }
        Console.Write(sb.ToString());
    }
}