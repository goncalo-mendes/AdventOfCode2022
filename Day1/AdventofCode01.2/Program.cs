        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Gonçalo\RiderProjects\AdventofCode01\AdventofCode01\input.txt");
        List<long> elves= new();
        long current = 0;
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                elves.Add(current);
                current = 0;
            }
            else
            {
                var calories = long.Parse(line);
                current += calories;
            }
        }
        elves.Add(current);
        var result = elves.OrderByDescending(i => i).Take(3).Sum();

        Console.WriteLine(result);
        System.Console.ReadKey();