namespace qazddwevevgefdcv
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            List<int[]> numbers = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                numbers.Add(arr);
            }
            for (int i = 0; i < n; i++)
            {
                sb.AppendLine((numbers[i][0] + numbers[i][1]).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}
