        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int k = input[0];
        int n = input[1];

        long[] arr = new long[k];
        for (int i = 0; i < k; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
        }

        long left = 1;
        long right = arr.Max();
        long answer = 0;

        while (left <= right)
        {
            long mid = (left + right) / 2;

            long count = 0;
            foreach (var a in arr)
            {
                count += a / mid;
            }

            if (count >= n)
            {
                answer = mid;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        Console.WriteLine(answer);