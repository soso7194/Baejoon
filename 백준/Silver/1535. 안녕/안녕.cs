        int n = int.Parse(Console.ReadLine());
        int[] hp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] happy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int[] dp = new int[101];

        for (int i = 0; i < n; i++)
        {
            for (int j = 100; j > hp[i]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - hp[i]] + happy[i]);
            }
        }

        Console.WriteLine(dp[100]);