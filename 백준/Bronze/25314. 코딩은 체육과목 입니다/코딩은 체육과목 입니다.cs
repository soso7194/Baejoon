namespace qazddwevevgefdcv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string ftgb = "";

            for (int i = 0; i < n / 4; i++)
            {
                ftgb += "long ";
            }
            ftgb += "int";
            Console.WriteLine(ftgb);
        }
    }
}
