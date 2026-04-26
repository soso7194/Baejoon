            int[] numbers = new int[28];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            int[] n = new int[2];
            int found = 0;
            int idx = 0; 

            for (int i = 1; i <= 30; i++)
            {
                if (idx >= numbers.Length || numbers[idx] != i)
                {
                    n[found] = i;
                    found++;
                    if (found == 2) break;
                }
                else
                {
                    idx++;
                }
            }
            Console.WriteLine(n[0]);
            Console.WriteLine(n[1]);