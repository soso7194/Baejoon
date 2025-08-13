            string n = "";
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split();
                int r = int.Parse(s[0]);

                for (int j = 0; j < s[1].Length; j++)
                {
                    for (int k = 0; k < r; k++)
                    {
                        n += s[1][j];
                    }
                }
                Console.WriteLine(n);
                n = "";
            }