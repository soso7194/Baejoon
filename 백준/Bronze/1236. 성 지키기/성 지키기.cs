        int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        string[,] s = new string[n[0], n[1]];

        for (int i = 0; i < n[0]; i++)
        {
            string input = Console.ReadLine();
            for (int j = 0; j < n[1]; j++)
            {
                s[i, j] = input[j].ToString();
            }
        }
        int w_count = n[0], l_count = n[1];
        for (int i = 0; i < n[0]; i++)
        {
            for (int j = 0; j < n[1]; j++)
            {
                if (s[i, j] == "X")
                {
                    w_count--;
                    break;
                }
            }
        }
        for (int i = 0; i < n[1]; i++)
        {
            for (int j = 0; j < n[0]; j++)
            {
                if (s[j, i] == "X")
                {
                    l_count--;
                    break;
                }
            }
        }

        Console.WriteLine(Math.Max(w_count, l_count));