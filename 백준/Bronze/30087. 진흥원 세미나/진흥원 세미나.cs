        Dictionary<string, string> dic = new Dictionary<string, string>();
        string[] name = { "Algorithm", "DataAnalysis", "ArtificialIntelligence", "CyberSecurity", "Network", "Startup", "TestStrategy" };
        string[] floor = { "204", "207", "302", "B101", "303", "501", "105" };
        for (int i = 0; i < name.Length; i++)
        {
            dic.Add(name[i], floor[i]);
        }
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (dic.ContainsKey(input))
            {
                Console.WriteLine(dic[input]);
            }
        }