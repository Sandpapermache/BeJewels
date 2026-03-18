using System;

public class GameController
{
    private GemBoard board;
    private MoveValidator validator;
    private double scoreboard;
    private bool gameStatus;

    public GameController()
    {
        board = new GemBoard();
        validator = new MoveValidator(board);
        scoreboard = 0;
        gameStatus = true;
    }

    private void calculateScore(int matchCount)
    {
        if (matchCount > 0)
        {
            double bonus = 3 + (matchCount * 0.2);
            scoreboard += (matchCount * 100) * bonus;
        }
    }

    public void makeMove(int r1, int c1, int r2, int c2)
    {
        if (validator.isAdjacent(r1, c1, r2, c2))
        {
            int matches = validator.findMatches();
            if (matches > 0)
            {
                calculateScore(matches);
                board.dropGem();
            }
        }
    }

    public double currentScore()
    {
        return scoreboard;
    }

    public bool currentStatus()
    {
        return gameStatus;
    }
}