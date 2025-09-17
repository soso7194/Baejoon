            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int a = m[0];
                int b = m[1];
                int x = m[2];

                int o = a * (x - 1) + b;
                Console.WriteLine(o);
            }