            int a = 1800;

            for (int i = 0; i < 4; i++)
            {
                int o = int.Parse(Console.ReadLine());
                a -= o;
            }
            if (a >= 300)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");