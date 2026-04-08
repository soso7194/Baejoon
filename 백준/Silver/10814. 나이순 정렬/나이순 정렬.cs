        int n = int.Parse(Console.ReadLine());
        List<(int, string)> list = new List<(int, string)>();
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            list.Add((int.Parse(input[0]), input[1]));
        }
        list.OrderBy(x => x.Item1).ToList().ForEach(x => Console.WriteLine($"{x.Item1} {x.Item2}"));