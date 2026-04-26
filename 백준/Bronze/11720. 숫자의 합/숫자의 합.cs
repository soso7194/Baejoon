namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string m = Console.ReadLine();
            int q = 0;

            for (int i = 0; i < n; i++)
            {
                q += int.Parse(m.Substring(i, 1));
            }
            Console.WriteLine(q);
        }
    }
}
