        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int N = arr[0];
        int M = arr[1];

        string[] board = new string[N];
        for (int i = 0; i < N; i++)
        {
            board[i] = Console.ReadLine();
        }

        int answer = int.MaxValue;

        for (int i = 0; i <= N - 8; i++)
        {
            for (int j = 0; j <= M - 8; j++)
            {
                int count1 = 0;
                int count2 = 0;

                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        char current = board[i + x][j + y];

                        if ((x + y) % 2 == 0)
                        {
                            if (current != 'B') count1++;
                            if (current != 'W') count2++;
                        }
                        else
                        {
                            if (current != 'W') count1++;
                            if (current != 'B') count2++;
                        }
                    }
                }

                answer = Math.Min(answer, Math.Min(count1, count2));
            }
        }

        Console.WriteLine(answer);