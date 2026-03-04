        int n = int.Parse(Console.ReadLine());
        int result = 0;
        int count = 0;

        int a, b;
        if(n == 0)
            count = 1;
        while (result != n)
        {
            if (count == 0)
            {
                if (n < 10)
                {
                    result = n * 10 + n;
                }
                else
                {
                    a = n / 10;
                    b = n % 10;
                    result = b * 10 + (a + b) % 10;
                }
            }
            else
            {
                a = result / 10;
                b = result % 10;
                result = b * 10 + (a + b) % 10;
            }
            count++;
        }
        Console.WriteLine(count);