            int[,] x = new int[9, 9];
            int max = 0;
            int maxRow = 0, maxCol = 0;

            for (int i = 0; i < 9; i++)
            {
                int[] row = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int j = 0; j < 9; j++)
                {
                    x[i, j] = row[j];
                    if (x[i, j] > max)
                    {
                        max = x[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine(max);
            Console.WriteLine($"{maxRow + 1} {maxCol + 1}");