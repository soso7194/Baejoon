            int n = int.Parse(Console.ReadLine()!);
            int m = int.Parse(Console.ReadLine()!);

            if(n > 0 && m > 0)
            {
                Console.WriteLine(1);
            }
            else if (n < 0 && m > 0)
            {
                Console.WriteLine(2);
            }
            else if (n < 0 && m < 0)
            {
                Console.WriteLine(3);
            }
            else if (n > 0 && m < 0)
            {
                Console.WriteLine(4);
            }