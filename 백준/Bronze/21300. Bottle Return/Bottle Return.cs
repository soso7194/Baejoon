            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int x = 0;
            for (int i = 0; i < n.Length; i++)
                x += n[i];
            Console.WriteLine(x * 5);