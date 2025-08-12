            int max = 0;
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                int value = int.Parse(Console.ReadLine());
                if (value > max)
                {
                    max = value;
                    index = i + 1;
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(index);