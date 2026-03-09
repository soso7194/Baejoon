            int n = int.Parse(Console.ReadLine());
            int dasom = int.Parse(Console.ReadLine());

            List<int> others = new List<int>();
            for (int i = 0; i < n - 1; i++)
            {
                others.Add(int.Parse(Console.ReadLine()));
            }

            if (n == 1)
            {
                Console.WriteLine(0);
                return;
            }

            int count = 0;

            while (true)
            {
                int maxVal = others.Max();

                if (dasom > maxVal)
                {
                    break;
                }

                int maxIdx = others.IndexOf(maxVal);
                others[maxIdx]--;
                dasom++;
                count++;
            }

            Console.WriteLine(count);