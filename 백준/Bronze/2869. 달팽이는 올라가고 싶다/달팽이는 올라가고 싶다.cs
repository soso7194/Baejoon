            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = ints[0];
            int b = ints[1];
            int v = ints[2];

            int x = (v - b - 1) / (a - b) + 1;
            Console.WriteLine(x);