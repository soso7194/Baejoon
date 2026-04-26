            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int m = 0;
                int k = 0;
                string input = Console.ReadLine();
                foreach (char c in input)
                {
                    if (c == 'O')
                    {
                        m++;
                        k += m;
                    }
                    else
                    {
                        m = 0;
                    }
                }
                Console.WriteLine(k);
            }