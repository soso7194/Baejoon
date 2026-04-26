namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            string c = Console.ReadLine();
            for (int i = 0; i < a; i++)
            {
                b[i] = int.Parse(c.Split(' ')[i]);
            }
            int d = int.Parse(Console.ReadLine());
            int e = 0;

            for (int i = 0; i < a; i++)
            {
                if (b[i] == d)
                {
                    e++;
                }
            }
            Console.WriteLine(e);
        }
    }
}
