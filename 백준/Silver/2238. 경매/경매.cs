        int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();
        for (int i = 0; i < n[1]; i++)
        {
            string[] s = Console.ReadLine().Split();
            string name = s[0];
            int price = int.Parse(s[1]);
            if (!dict.ContainsKey(price))
            {
                dict[price] = new List<string>();
            }
            dict[price].Add(name);
        }
        var result = dict.OrderBy(x => x.Value.Count).ThenBy(x => x.Key).First();
        Console.WriteLine(result.Value[0] + " " + result.Key);