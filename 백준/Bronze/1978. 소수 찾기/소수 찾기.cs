            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int x = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 2)
                    continue;

                bool isPrime = true;
                int limit = (int)Math.Sqrt(arr[i]);

                for (int j = 2; j <= limit; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    x++;
            }

            Console.WriteLine(x);