        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = i + 1;

        while (true)
        {
            if (arr.Length == 1)
            {
                Console.WriteLine(arr[0]);
                break;
            }
            int[] temp = new int[arr.Length / 2];
            for (int i = 0; i < temp.Length; i++)
                temp[i] = arr[i * 2 + 1];
            arr = temp;
        }