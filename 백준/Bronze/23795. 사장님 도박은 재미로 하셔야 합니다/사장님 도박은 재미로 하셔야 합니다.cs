    int n = 0;

    while (true)
    {
        int input = int.Parse(Console.ReadLine());
        if (input == -1)
            break;
        n += input;
    }
    Console.WriteLine(n);