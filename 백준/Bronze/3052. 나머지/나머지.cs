            int[] i = new int[10];
            for (int j = 0; j < i.Length; j++)
            {
                i[j] = int.Parse(Console.ReadLine());
            }
            int[] n = new int[10];
            for (int j = 0; j < i.Length; j++)
            {
                n[j] = i[j] % 42;
            }
            int[] x = n.Distinct().ToArray();
            Console.WriteLine(x.Length);