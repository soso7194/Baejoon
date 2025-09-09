            int n = int.Parse(Console.ReadLine());

            int a = 0;
            double b = 0, c = 0;

            for (int i = 1; i <= n; i++)
            {
                a += i;
            }
            Console.WriteLine(a);
            
            b = Math.Pow(a, 2);
            Console.WriteLine(b);

            for(int i = 1; i <= n; i++)
            {
                c += Math.Pow(i, 3);
            }
            Console.WriteLine(c);