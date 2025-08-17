int[] input = new int[3];
int x = 0;

for(int i = 0; i < input.Length; i++)
{
    input[i] = int.Parse(Console.ReadLine());
}

x = input[0] * input[1] * input[2];
string result = x.ToString();
int[] n = new int[10];

for(int i = 0; i < result.Length; i++)
{
    for(int j = 0; j < n.Length; j++)
    {
        if ((int)char.GetNumericValue(result[i]) == j)
        {
            n[j]++;
        }
    }
}

for(int i = 0; i < n.Length; i++)
{
    Console.WriteLine(n[i]);
}