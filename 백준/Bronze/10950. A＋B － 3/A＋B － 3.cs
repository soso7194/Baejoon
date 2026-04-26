namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <int[]> numbers = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                int[] number = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                numbers.Add(number);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i][0] + numbers[i][1]);
            }
        }
    }
}