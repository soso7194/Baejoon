        int n = int.Parse(Console.ReadLine());
        long[] arr = { 0, 1 };

        if (n == 0)
        {
            Console.WriteLine(arr[0]);
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                long add = 0;
                long num = arr[1];

                add = arr[0] + arr[1];
                arr[1] = add;
                arr[0] = num;
            }
            Console.WriteLine(arr[1]);
        }