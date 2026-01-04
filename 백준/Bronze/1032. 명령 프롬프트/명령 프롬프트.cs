using System.Text;

namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int line = input.Length;
            string[] x = new string[line];

            for (int i = 0; i < n - 1; i++)
            {
                if (n == 1)
                {
                    break;
                }
                string input2 = Console.ReadLine();
                for (int j = 0; j < line; j++)
                {
                    if (input[j] == input2[j])
                    {
                        if (x[j] != null)
                            continue;
                        else
                            x[j] += input[j];
                    }
                    else
                    {
                        x[j] = "?";
                    }
                }
            }
            if (n == 1)
            {
                Console.Write(input);
            }
            else
            {
                for (int i = 0; i < line; i++)
                {
                    Console.Write(x[i]);
                }
            }
        }
    }
}
