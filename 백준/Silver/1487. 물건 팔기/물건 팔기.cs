            int n = int.Parse(Console.ReadLine());
            List<(int P, int Q)> m = new List<(int, int)>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                m.Add((input[0], input[1]));
            }

            var priceCandidates = m.Select(x => x.P).Distinct().OrderBy(x => x).ToList();

            long maxTotalProfit = 0;
            int answerPrice = 0;

            foreach (int currentPrice in priceCandidates)
            {
                long currentTotalProfit = 0;

                foreach (var customer in m)
                {
                    if (customer.P >= currentPrice)
                    {
                        int profitFromCustomer = currentPrice - customer.Q;
                        if (profitFromCustomer > 0)
                        {
                            currentTotalProfit += profitFromCustomer;
                        }
                    }
                }

                if (currentTotalProfit > maxTotalProfit)
                {
                    maxTotalProfit = currentTotalProfit;
                    answerPrice = currentPrice;
                }
            }

            Console.WriteLine(maxTotalProfit <= 0 ? 0 : answerPrice);