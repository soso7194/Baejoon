        int n = int.Parse(Console.ReadLine());

        long output = 0;
        for (int i = 0; i < n; i++)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int x in input)
                output += x;
        }
        Console.WriteLine(output);