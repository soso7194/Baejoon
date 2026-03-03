        string[] input = Console.ReadLine().Split(' ');
        int[] n1 = input[0].ToCharArray().Select(c => c - '0').ToArray();
        int[] n2 = input[1].ToCharArray().Select(c => c - '0').ToArray();

        int maxLength = Math.Max(n1.Length, n2.Length);
        string output = "";
        for (int i = maxLength; i > 0; i--)
        {
            int digit1 = i <= n1.Length ? n1[n1.Length - i] : 0;
            int digit2 = i <= n2.Length ? n2[n2.Length - i] : 0;
            output += (digit1 + digit2).ToString();
        }
        Console.WriteLine(output);