            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long a = (n[0] + n[1]) * (n[0] - n[1]);

            Console.WriteLine(a);