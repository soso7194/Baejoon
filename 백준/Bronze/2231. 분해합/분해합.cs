int N = int.Parse(Console.ReadLine());

int start = Math.Max(1, N - 9 * N.ToString().Length);

for (int i = start; i < N; i++)
{
    int sum = i;
    int temp = i;

    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }

    if (sum == N)
    {
        Console.WriteLine(i);
        return;
    }
}

Console.WriteLine(0);