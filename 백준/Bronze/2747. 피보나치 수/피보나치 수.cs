        int n = int.Parse(Console.ReadLine());
        int[] arr = { 0, 1 };

        if (n == 1)
        {
            Console.WriteLine(arr[1]);
        }
        else
        {
            for(int i = 0; i < n - 1; i++)
            {
                int add = 0;
                int num = arr[1];

                add = arr[0] + arr[1];
                arr[1] = add;
                arr[0] = num;
            }
            Console.WriteLine(arr[1]);
        }