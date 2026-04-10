using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int[] arr = new int[20];
        for (int i = 0; i < 20; i++)
        {
            arr[i] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            if (s[0] == "add")
            {
                int num = int.Parse(s[1]);
                arr[num - 1] = num;
            }
            else if (s[0] == "remove")
            {
                int num = int.Parse(s[1]);
                arr[num - 1] = 0;
            }
            else if (s[0] == "check")
            {
                int num = int.Parse(s[1]);
                sb.AppendLine(arr[num - 1] != 0 ? "1" : "0");
            }
            else if (s[0] == "toggle")
            {
                int num = int.Parse(s[1]);
                arr[num - 1] = arr[num - 1] != 0 ? 0 : num;
            }
            else if (s[0] == "all")
            {
                for (int j = 0; j < 20; j++)
                {
                    arr[j] = j + 1;
                }
            }
            else if (s[0] == "empty")
            {
                for (int j = 0; j < 20; j++)
                {
                    arr[j] = 0;
                }
            }
        }
        Console.Write(sb.ToString());
    }
}