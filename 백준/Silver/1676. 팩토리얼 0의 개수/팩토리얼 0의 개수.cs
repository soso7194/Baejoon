            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 5; n / i >= 1; i *= 5)
            {
                count += n / i;
            }

            Console.WriteLine(count);