        string[] input = Console.ReadLine().Split('-');
        int output = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int sum = input[i].Split('+').Select(int.Parse).Sum();
            if(i == 0) output += sum;
            else output -= sum;
        }
        Console.WriteLine(output);