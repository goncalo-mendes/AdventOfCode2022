string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Gonçalo\RiderProjects\AdventofCode01\FirstProblem\input.txt");

int score = 0;

foreach (string round in lines)
{
    string opponentPlay = round.ElementAt(0).ToString();
    string loseDrawWin = round.ElementAt(2).ToString();

    if (loseDrawWin == "X")
    {
        if (opponentPlay == "A")
        {
            score += 3;
        }
        else if (opponentPlay == "B")
        {
            score += 1;
        }
        else if (opponentPlay == "C")
        {
            score += 2;
        }
    }
    else if (loseDrawWin == "Y")
    {
        score += 3;
        if (opponentPlay == "A")
        {
            score += 1;
        }
        else if (opponentPlay == "B")
        {
            score += 2;
        }
        else if (opponentPlay == "C")
        {
            score += 3;
        }
    }
    else if (loseDrawWin == "Z")
    {
        score += 6;
        if (opponentPlay == "A")
        {
            score += 2;
        }
        else if (opponentPlay == "B")
        {
            score += 3;
        }
        else if (opponentPlay == "C")
        {
            score += 1;
        }
    }
}

Console.WriteLine($"Your Rock Paper Scissors score is {score}.\n");
