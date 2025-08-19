            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int h = ints[0];
                int n = ints[2];

                int floor = (n - 1) % h + 1;
                int room = (n - 1) / h + 1;

                Console.WriteLine($"{floor}{room:D2}");
            }