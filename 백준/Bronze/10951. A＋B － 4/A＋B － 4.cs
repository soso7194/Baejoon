            while (true)
            {
                string n = Console.ReadLine();
                if (n == null)
                    break;
                string[] m = n.Split(' ');
                int n1 = int.Parse(m[0]);
                int n2 = int.Parse(m[1]);
                Console.WriteLine(n1 + n2);
            }