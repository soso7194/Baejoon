            int n = int.Parse(Console.ReadLine());
            int z = 0, m = 0, o = 0;

            if(n >= 1)
            {
                z = (n - 1) * 7;
                m = z / 12;
                o = z % 12;
            }

            int a = 2024 + m;
            int b = 8 + o;
            if(b > 12)
            {
                a++;
                b -= 12;
            }

            Console.WriteLine($"{a} {b}");