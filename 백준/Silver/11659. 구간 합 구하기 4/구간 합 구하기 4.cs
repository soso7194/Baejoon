using System.Text;

int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int[] prefix = new int[n[0] + 1];

StringBuilder sb = new StringBuilder();

for (int i = 1; i <= n[0]; i++)
{
    prefix[i] = prefix[i - 1] + arr[i - 1];
}

for (int i = 0; i < n[1]; i++)
{
    int[] q = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int result = prefix[q[1]] - prefix[q[0] - 1];
    sb.AppendLine(result.ToString());
}

Console.Write(sb.ToString());