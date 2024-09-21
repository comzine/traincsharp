using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zum Tic Tac Toe Spiel!");
        InitializeBoard();

        while (true)
        {
            DisplayBoard();
            GetPlayerMove();
            if (CheckWin() || CheckDraw())
            {
                break;
            }
            SwitchPlayer();
        }

        Console.WriteLine("Spiel beendet.");
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    static void DisplayBoard()
    {
        Console.Clear();
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{board[i, j]}");
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  -----");
        }
    }

    static void GetPlayerMove()
    {
        Console.WriteLine($"Spieler {currentPlayer}, bitte geben Sie Ihre Züge ein (Zeile Spalte):");
        string input = Console.ReadLine();
        if (input.Length == 3 && int.TryParse(input[0].ToString(), out int row) && int.TryParse(input[2].ToString(), out int col) && row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ')
        {
            board[row, col] = currentPlayer;
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte versuchen Sie es erneut.");
            GetPlayerMove();
        }
    }

    static bool CheckWin()
    {
        // Überprüfe Zeilen und Spalten
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
            {
                Console.WriteLine($"Spieler {currentPlayer} hat gewonnen!");
                return true;
            }
        }

        // Überprüfe Diagonalen
        if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
            (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
        {
            Console.WriteLine($"Spieler {currentPlayer} hat gewonnen!");
            return true;
        }

        return false;
    }

    static bool CheckDraw()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    return false;
                }
            }
        }
        Console.WriteLine("Das Spiel endet unentschieden!");
        return true;
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
