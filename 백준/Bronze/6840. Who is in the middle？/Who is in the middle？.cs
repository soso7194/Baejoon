            int i = 0;
            int[] m = new int[3];
            while (i < 3)
            {
                m[i] = int.Parse(Console.ReadLine());
                i++;
            }
            Array.Sort(m);
            Console.WriteLine(m[1]);