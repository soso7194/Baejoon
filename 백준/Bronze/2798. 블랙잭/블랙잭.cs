        int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int max = 0;

        for (int i = 0; i < n[0] - 2; i++)
        {
            for (int j = i + 1; j < n[0] - 1; j++)
            {
                for (int k = j + 1; k < n[0]; k++)
                {
                    int sum = arr[i] + arr[j] + arr[k];

                    if (sum <= n[1] && sum > max)
                    {
                        max = sum;
                    }
                }
            }
        }

        Console.WriteLine(max);