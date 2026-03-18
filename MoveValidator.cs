using System;

public class MoveValidator
{
    private GemBoard board;

    public MoveValidator(GemBoard gameBoard)
    {
        board = gameBoard;
    }

    public bool isAdjacent(int r1, int c1, int r2, int c2)
    {
        int rowDiff = Math.Abs(r1 - r2);
        int colDiff = Math.Abs(c1 - c2);
        
        return (rowDiff + colDiff == 1);
    }

    public int findMatches()
    {                                   //Algorithm found for finding matches
        int totalMatched = 0;

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                string s1 = board.GetGem(i, j).returnShape();
                string s2 = board.GetGem(i, j + 1).returnShape();
                string s3 = board.GetGem(i, j + 2).returnShape();

                if (s1 == s2 && s2 == s3 && s1 != "")
                {
                    board.removeGem(i, j);
                    board.removeGem(i, j + 1);
                    board.removeGem(i, j + 2);
                    totalMatched += 3;
                }
            }
        }

        for (int j = 0; j < 8; j++)
        {
            for (int i = 0; i < 6; i++)
            {
                string s1 = board.GetGem(i, j).returnShape();
                string s2 = board.GetGem(i + 1, j).returnShape();
                string s3 = board.GetGem(i + 2, j).returnShape();

                if (s1 == s2 && s2 == s3 && s1 != "")
                {
                    board.removeGem(i, j);
                    board.removeGem(i + 1, j);
                    board.removeGem(i + 2, j);
                    totalMatched += 3;
                }
            }
        }
        return totalMatched;
    }
}