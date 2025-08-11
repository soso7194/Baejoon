            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = new int[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                m[i] = n[i] * n[i];
            }
            int x = 0;
            for (int i = 0; i < n.Length; i++)
            {
                x += m[i];
            }
            Console.WriteLine(x % 10);