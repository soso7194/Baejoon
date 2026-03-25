            int n = int.Parse(Console.ReadLine());
            char[,] arr = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = input[j];
                }
            }

            int[] dx = { 0, 1, 1, 1 };
            int[] dy = { 1, 0, 1, -1 };

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == '.') continue;

                    for (int d = 0; d < 4; d++)
                    {
                        int count = 1;
                        int x = i;
                        int y = j;

                        for (int k = 1; k < 3; k++)
                        {
                            int nx = x + dx[d] * k;
                            int ny = y + dy[d] * k;

                            if (nx < 0 || ny < 0 || nx >= n || ny >= n)
                                break;

                            if (arr[nx, ny] == arr[i, j])
                                count++;
                        }

                        if (count >= 3)
                        {
                            Console.WriteLine(arr[i, j]);
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("ongoing");