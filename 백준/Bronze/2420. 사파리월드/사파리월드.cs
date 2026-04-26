            string input = Console.ReadLine() ;
            long[] ints = Array.ConvertAll(input.Split(' '), long.Parse);
            long x = 0;

            x = ints[0] - ints[1];
            if(x < 0)
            {
                x = -x;
            }
            Console.WriteLine(x);