using System.Text;

namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.AppendLine(i.ToString());
            }
            Console.Write(sb.ToString());
        }
    }
}