        int x = 0;
        int n = int.Parse(Console.ReadLine());
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();

        string[] strings1 = Console.ReadLine().Split();
        string[] strings2 = Console.ReadLine().Split();

        foreach (string s in strings1)
            list1.Add(int.Parse(s));
        foreach (string s in strings2)
            list2.Add(int.Parse(s));

        list1.Sort();
        list2.Sort();
        list2.Reverse();

        for (int i = 0; i < n; i++)
        {
            x += list1[i] * list2[i];
        }
        Console.WriteLine(x);