namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (n[0] > n[1])
                Console.WriteLine(">");
            else if (n[0] < n[1])
                Console.WriteLine("<");
            else
                Console.WriteLine("==");
        }
    }
}