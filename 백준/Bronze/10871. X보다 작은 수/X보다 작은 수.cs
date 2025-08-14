            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] b = new int[n[0]];
            int c = 0;

            for (int i = 0; i < n[0]; i++)
            {
                if (a[i] < n[1])
                {
                    b[c] = a[i];
                    c++;
                }
            }
            for (int i = 0; i < c; i++)
            {
                if (i > 0) Console.Write(" ");
                Console.Write(b[i]);
            }