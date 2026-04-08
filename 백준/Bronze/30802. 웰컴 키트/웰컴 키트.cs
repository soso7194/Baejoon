        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int a = 0;

        for(int i = 0; i < 6; i++)
        {
            a += (arr[i] + m[0] - 1) / m[0];
        }
        Console.WriteLine(a);
        Console.WriteLine($"{n / m[1]} {n % m[1]}");