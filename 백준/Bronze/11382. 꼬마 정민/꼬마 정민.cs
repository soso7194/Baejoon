            string input = Console.ReadLine();
            long[] parts = input.ToString().Split(' ').Select(long.Parse).ToArray();
            long x = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                x += parts[i];
            }
            Console.WriteLine(x);