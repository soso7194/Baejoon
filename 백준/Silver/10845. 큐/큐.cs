            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split();
                if (s[0] == "push")
                {
                    list.Add(int.Parse(s[1]));
                }
                else if (s[0] == "pop")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(list.First());
                        list.Remove(list.First());
                    }
                }
                else if (s[0] == "size")
                {
                    Console.WriteLine(list.Count);
                }
                else if (s[0] == "empty")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }
                else if (s[0] == "front")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(list.First());
                    }
                }
                else if (s[0] == "back")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine(-1);
                    }
                    else
                    {
                        Console.WriteLine(list.Last());
                    }
                }
            }