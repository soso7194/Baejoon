namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            List<int[]> numbers = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] row = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                numbers.Add(row);
            }
            for (int i = 0; i < n; i++)
            {
                x += numbers[i][0] * numbers[i][1];
            }
            if (x == m)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
