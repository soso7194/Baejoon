        int n = int.Parse(Console.ReadLine());
        List<(int, int)> list = new List<(int, int)>();
        for(int i = 0; i < n; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            list.Add((input[0], input[1]));
        }
        list.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList().ForEach(x => Console.WriteLine($"{x.Item1} {x.Item2}"));