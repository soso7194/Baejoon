            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if(n == 0) break;
                int m = 0;

                for (int i = n; i > 0; i--)
                {
                    m += i;
                }
                Console.WriteLine(m);
            }