namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine((n[0] + n[1]) % n[2]);
            Console.WriteLine(((n[0] % n[2]) + (n[1] % n[2])) % n[2]);
            Console.WriteLine((n[0] * n[1]) % n[2]);
            Console.WriteLine(((n[0] % n[2]) * (n[1] % n[2])) % n[2]);
        }
    }
}
