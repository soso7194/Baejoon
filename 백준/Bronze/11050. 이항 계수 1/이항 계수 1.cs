using System.Text;

namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int a = Factorial(ints[0]);
            int b = Factorial(ints[1]);
            int c = Factorial(ints[0] - ints[1]);

            int x = a / (b * c);

            Console.WriteLine(x);
        }

        static int Factorial(int n)
        {
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                x = x * i;
            }
            return x;
        }
    }
}   