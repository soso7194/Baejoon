int size = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
double threshold = size * 0.05;
Dictionary<string, int> dict = new Dictionary<string, int>();
List<(string name, double score)> scores = new List<(string, double)>();
Dictionary<string, int> result = new Dictionary<string, int>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    int vote = int.Parse(input[1]);

    if (vote > threshold)
        dict[name] = vote;
}

foreach (var kv in dict)
{
    for (int i = 1; i <= 14; i++)
    {
        scores.Add((kv.Key, kv.Value / (double)i));
    }
}

scores.Sort((a, b) => b.score.CompareTo(a.score));

foreach (var key in dict.Keys)
    result[key] = 0;

for (int i = 0; i < 14; i++)
{
    string name = scores[i].name;
    result[name]++;
}

foreach (var kv in result.OrderBy(x => x.Key))
{
    Console.WriteLine($"{kv.Key} {kv.Value}");
}