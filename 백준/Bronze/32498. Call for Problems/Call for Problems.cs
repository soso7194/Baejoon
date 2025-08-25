            int n = int.Parse(Console.ReadLine());
            int m = 0;

            for (int i = 0; i < n; i++)
            {
                int o = int.Parse(Console.ReadLine());
                if(o % 2 != 0)
                {
                    m++;
                }
            }
            Console.WriteLine(m);