using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        string[] n = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        BigInteger x = 0;
        int y = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        char[] z = input.ToCharArray();

        for (int i = 0; i < y; i++)
        {
            int index = Array.IndexOf(n, z[i].ToString());
            x += (index + 1) * (BigInteger)Math.Pow(31, i);
        }
        Console.WriteLine(x);
    }
}