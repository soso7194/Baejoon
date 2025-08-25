            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Console.WriteLine($"Case #{i + 1}: {b[0]} + {b[1]} = {b[0] + b[1]}");
            }