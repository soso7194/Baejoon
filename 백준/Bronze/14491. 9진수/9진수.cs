        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        while (n / 9 != 0)
        {
            list.Add(n % 9);
            n /= 9;
        }
        list.Add(n % 9);
        list.Reverse();
        string result = string.Join("", list);
        Console.WriteLine(result);