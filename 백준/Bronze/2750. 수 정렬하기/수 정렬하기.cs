        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            list.Add(input);
        }
        list.Sort();
        List<int> output = list.Distinct().ToList();
        foreach (var v in output)
        {
            Console.WriteLine(v);
        }