public class Board
{
    public char[,] Spielfeld { get; private set; }

    public Board()
    {
        Spielfeld = new char[3, 3];
        for (int i = 0; i < Spielfeld.GetLength(0); i++)
        {
            for (int j = 0; j < Spielfeld.GetLength(1); j++)
            {
                Spielfeld[i, j] = ' ';
            }
        }
    }

    public override string ToString()
    {
        string s = "";

        s += Spielfeld[0, 0] + " | " + Spielfeld[1, 0] + " | " + Spielfeld[2, 0];
        s += "\n---------\n";
        s += Spielfeld[0, 1] + " | " + Spielfeld[1, 1] + " | " + Spielfeld[2, 1];
        s += "\n---------\n";
        s += Spielfeld[0, 2] + " | " + Spielfeld[1, 2] + " | " + Spielfeld[2, 2];

        //  X |   | O
        //  ---------
        //    | O | X
        //  ---------
        //  X | O |  

        return s;
    }

    public bool IsValid(int[] zug)
    {
        if (zug[0] < 0 || zug[0] > 2 || zug[1] < 0 || zug[1] > 2)
        {
            return false;
        }
        if (Spielfeld[zug[0], zug[1]] == ' ')
        {
            return true;
        }
        return false;
    }

    public void Set(int[] zug, char zeichen)
    {
        Spielfeld[zug[0], zug[1]] = zeichen;
    }

    public char Won()
    {
        // Zeilen
        for (int row = 0; row < 3; row++)
        {
            if (Spielfeld[row, 0] != ' ' && Spielfeld[row, 0] == Spielfeld[row, 1] && Spielfeld[row, 0] == Spielfeld[row, 2])
            {
                return Spielfeld[row, 0];
            }
        }

        // Spalten
        for (int column = 0; column < 3; column++)
        {
            if (Spielfeld[0, column] != ' ' && Spielfeld[0, column] == Spielfeld[1, column] && Spielfeld[0, column] == Spielfeld[2, column])
            {
                return Spielfeld[0, column];
            }
        }

        if (Spielfeld[0, 0] != ' ' && Spielfeld[0, 0] == Spielfeld[1, 1] && Spielfeld[0, 0] == Spielfeld[2, 2])
        {
            return Spielfeld[0, 0];
        }

        if (Spielfeld[2, 0] != ' ' && Spielfeld[2, 0] == Spielfeld[1, 1] && Spielfeld[2, 0] == Spielfeld[0, 2])
        {
            return Spielfeld[2, 0];
        }

        return ' ';
    }

    public bool Unentschieden()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (Spielfeld[i, j] == ' ')
                {
                    return false;
                }
            }
        }
        return Won() == ' ';
    }
}