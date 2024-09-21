using System;

namespace TicTacToeOOP
{
    public class Board
    {
        private char[,] grid;

        public Board()
        {
            grid = new char[3, 3];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = ' ';
                }
            }
        }

        public bool PlaceMark(int row, int col, char mark)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2 || grid[row, col] != ' ')
            {
                return false;
            }
            grid[row, col] = mark;
            return true;
        }

        public bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CheckWin(char mark)
        {
            // Check rows, columns and diagonals
            for (int i = 0; i < 3; i++)
            {
                if ((grid[i, 0] == mark && grid[i, 1] == mark && grid[i, 2] == mark) ||
                    (grid[0, i] == mark && grid[1, i] == mark && grid[2, i] == mark))
                {
                    return true;
                }
            }
            return (grid[0, 0] == mark && grid[1, 1] == mark && grid[2, 2] == mark) ||
                   (grid[0, 2] == mark && grid[1, 1] == mark && grid[2, 0] == mark);
        }

        public void Display()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grid[i, j]);
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("  -+-+-");
            }
        }
    }
}
