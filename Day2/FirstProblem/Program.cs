string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Gonçalo\RiderProjects\AdventofCode01\FirstProblem\input.txt");

int score = 0;

foreach (string round in lines)
{
    string opponentPlay = round.ElementAt(0).ToString();
    string ownPlay = round.ElementAt(2).ToString();

    if (ownPlay == "X")
    {
        score += 1;
        if (opponentPlay == "A")
        {
            score += 3;
        }
        else if (opponentPlay == "C")
        {
            score += 6;
        }
    }
    else if (ownPlay == "Y")
    {
        score += 2;
        if (opponentPlay == "A")
        {
            score += 6;
        }
        else if (opponentPlay == "B")
        {
            score += 3;
        }
    }
    else if (ownPlay == "Z")
    {
        score += 3;
        if (opponentPlay == "B")
        {
            score += 6;
        }
        else if (opponentPlay == "C")
        {
            score += 3;
        }
    }
}

Console.WriteLine($"Your Rock Paper Scissors score is {score}.\n");