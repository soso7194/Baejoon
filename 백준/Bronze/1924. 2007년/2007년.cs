        string[] day = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
        int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int m = input[1];
        for (int i = 0; i < input[0] - 1; i++)
        {
            m += month[i];
        }
        Console.WriteLine(day[(m - 1) % 7]);