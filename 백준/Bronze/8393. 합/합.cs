namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                x += i;
            }
            Console.WriteLine(x);
        }
    }
}
