            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int minMoney = int.MaxValue;
            for (int i = 0; i < n[2]; i++)
            {
                int money = int.Parse(Console.ReadLine());
                int[] room = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                foreach (int r in room)
                {
                    if(r >= n[0])
                    {
                        if (money * n[0] < minMoney && money * n[0] < n[1])
                            minMoney = money * n[0];
                    }
                }
            }
            if(minMoney == int.MaxValue)
                Console.WriteLine("stay home");
            else
                Console.WriteLine(minMoney);