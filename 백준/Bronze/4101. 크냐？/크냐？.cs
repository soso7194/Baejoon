            while(true)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (n[0] == 0 && n[1] == 0) break;
                if (n[0] > n[1])
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }