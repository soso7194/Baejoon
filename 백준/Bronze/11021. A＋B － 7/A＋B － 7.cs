            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                Console.WriteLine($"Case #{i + 1}: {ints[0] + ints[1]}");
            }