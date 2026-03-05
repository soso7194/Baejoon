        int n = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        int[] people = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        foreach (int i in people)
            list.Add(i);
        int m = list.Count() - list.Distinct().Count();
        Console.WriteLine(m);