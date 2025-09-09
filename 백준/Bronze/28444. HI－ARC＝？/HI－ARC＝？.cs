            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int a = n[0] * n[1], b = n[2] * n[3] * n[4];

            Console.WriteLine(a - b);