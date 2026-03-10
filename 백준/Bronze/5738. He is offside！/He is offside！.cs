            while (true)
            {
                int[] people = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if(people[0] == 0 && people[1] == 0)
                {
                    break;
                }
                int[] attacker = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] defender = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                Array.Sort(defender);
                Array.Sort(attacker);

                if (attacker[0] < defender[1])
                    Console.WriteLine("Y");
                else
                    Console.WriteLine("N");
            }