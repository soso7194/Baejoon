            int a = int.Parse(Console.ReadLine());
            string x = Console.ReadLine();
            string[] n = x.Split();
            string y = Console.ReadLine();
            int b = 0;

            for(int i = 0; i < a; i++)
            {
                if (n[i] == y)
                    b++;
            }
            Console.WriteLine(b);