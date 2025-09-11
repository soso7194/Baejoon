            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int a = n[0] * n[1];
            int b = a - n[2];
            if (b < 0) b = 0;

            Console.WriteLine(b);