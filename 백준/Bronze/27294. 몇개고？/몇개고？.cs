            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            if (n[1] == 0)
            {
                if (12 <= n[0] && n[0] <= 16)
                    Console.WriteLine("320");
                else
                    Console.WriteLine("280");
            }
            else
                Console.WriteLine("280");