            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] += int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Array.Reverse(arr);
            for(int i  = 0; i < n - 2; i++)
            {
                if (arr[1 + i] + arr[2 + i] > arr[i])
                {
                    Console.WriteLine(arr[1 + i] + arr[2 + i] + arr[i]);
                    return;
                }
            }
            Console.WriteLine(-1);