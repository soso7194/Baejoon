        string n;
        bool can = true;
        while (true)
        {
            can = true;
            n = Console.ReadLine();
            if (n == "0")
                break;
            for(int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] != n[n.Length - 1 - i])
                {
                    can = false;
                    break;
                }
            }

            if(can)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }