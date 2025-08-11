            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int x = (int)Math.Floor(n * 0.15 + 0.5);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            List<int> list = new List<int>(arr);

            list.Sort();
            list = list.Skip(x).Take(n - x * 2).ToList();

            double y = (double)list.Sum() / list.Count;
            int z = (int)Math.Floor(y + 0.5);

            Console.WriteLine(z);