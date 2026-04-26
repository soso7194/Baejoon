        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int current = arr[0];
        int answer = arr[0];

        for (int i = 1; i < n; i++)
        {
            current = Math.Max(arr[i], current + arr[i]);
            answer = Math.Max(answer, current);
        }

        Console.WriteLine(answer);