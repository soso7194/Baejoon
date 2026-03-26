            int n = int.Parse(Console.ReadLine());
            int digit = 1, start = 1, length = 0;
            while(start <= n)
            {
                int end = start * 10 - 1;
                if(end > n)
                {
                    end = n;
                }
                length += (end - start + 1) * digit;

                digit++;
                start *= 10;
            }
            Console.WriteLine(length);