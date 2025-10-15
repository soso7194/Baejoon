            int[] ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = ints.Max();

            if (ints[0] == ints[1] && ints[1] == ints[2])
                Console.WriteLine(10000 + ints[0] * 1000);
            else if (ints[0] == ints[1])
                Console.WriteLine(1000 + ints[0] * 100);
            else if (ints[1] == ints[2])
                Console.WriteLine(1000 + ints[1] * 100);
            else if (ints[0] == ints[2])
                Console.WriteLine(1000 + ints[0] * 100);
            else
                Console.WriteLine(n * 100);