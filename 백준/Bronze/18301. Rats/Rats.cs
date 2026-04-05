        float[] arr = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
        int n = (int)Math.Truncate((arr[0] + 1) * (arr[1] + 1) / (arr[2] + 1) - 1);
        Console.WriteLine(n);