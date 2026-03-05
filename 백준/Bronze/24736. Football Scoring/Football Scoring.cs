        int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] n1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Console.Write(n[0] * 6 + n[1] * 3 + n[2] * 2 + n[3] * 1 + n[4] * 2);
        Console.Write(" ");
        Console.WriteLine(n1[0] * 6 + n1[1] * 3 + n1[2] * 2 + n1[3] * 1 + n1[4] * 2);