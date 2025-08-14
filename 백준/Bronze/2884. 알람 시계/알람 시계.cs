            int[] ints = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            if (ints[1] > 45)
                Console.WriteLine($"{ints[0]} {ints[1] - 45}");
            else if (ints[1] == 45)
                Console.WriteLine($"{ints[0]} 0");
            else if (ints[1] < 45)
                if(ints[0] == 0)
                    Console.WriteLine($"23 {ints[1] + 15}");
                else
                    Console.WriteLine($"{ints[0] - 1} {ints[1] + 15}");