            int n = int.Parse(Console.ReadLine());
            int player1 = 0, player2 = 0;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                if(a > b)
                {
                    player1++;
                }
                else if(a < b)
                {
                    player2++;
                }
            }
            Console.WriteLine(player1 + " " + player2);