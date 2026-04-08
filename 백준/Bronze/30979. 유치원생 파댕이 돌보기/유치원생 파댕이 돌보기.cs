        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int add = 0;
        foreach (int i in arr)
        {
            add += i;
        }
        if (n > add)
            Console.WriteLine("Padaeng_i Cry");
        else
            Console.WriteLine("Padaeng_i Happy");