            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = new int[n[0]];

            int x = 0;

            for (int i = 0; i < n[0]; i++)
            {
                m[i] = int.Parse(Console.ReadLine());
                x += m[i];
            }
            int o = n[1] / x;
            for (int i = 0; i < n[0]; i++)
            {
                Console.WriteLine(m[i] * o);
            }