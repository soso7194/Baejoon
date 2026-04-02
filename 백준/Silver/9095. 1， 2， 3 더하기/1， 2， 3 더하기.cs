            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                int[] dp = new int[m + 1];

                dp[1] = 1;
                if (m >= 2) dp[2] = 2;
                if (m >= 3) dp[3] = 4;

                for (int j = 4; j <= m; j++)
                {
                    dp[j] = dp[j - 1] + dp[j - 2] + dp[j - 3];
                }

                Console.WriteLine(dp[m]);
            }