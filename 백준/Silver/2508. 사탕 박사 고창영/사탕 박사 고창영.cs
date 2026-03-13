            int n = int.Parse(Console.ReadLine());
            for(int m = 0; m < n; m++)
            {
                int count = 0;
                Console.ReadLine();
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                string[,] strings = new string[arr[0], arr[1]];
                for (int i = 0; i < arr[0]; i++)
                {
                    string s = Console.ReadLine();
                    for (int j = 0; j < arr[1]; j++)
                    {
                        strings[i, j] = s[j].ToString();
                    }
                }
                for (int i = 0; i < arr[0]; i++)
                {
                    for (int j = 0; j < arr[1]; j++)
                    {
                        if (j + 2 < arr[1])
                            if (strings[i, j] == ">" && strings[i, j + 1] == "o" && strings[i, j + 2] == "<")
                                count++;

                        if (i + 2 < arr[0])
                            if (strings[i, j] == "v" && strings[i + 1, j] == "o" && strings[i + 2, j] == "^")
                                count++;
                    }
                }
                Console.WriteLine(count);
            }