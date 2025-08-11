using System.Text;

namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sb.AppendLine(arr[i].ToString());
            }

            Console.Write(sb.ToString());
        }
    }
}
