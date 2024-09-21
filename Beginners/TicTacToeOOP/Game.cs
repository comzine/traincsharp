using System;

namespace TicTacToeOOP
{
    public class Game
    {
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public Game()
        {
            board = new Board();
            player1 = new Player("Player 1", 'X');
            player2 = new Player("Player 2", 'O');
            currentPlayer = player1;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            while (true)
            {
                PlayRound();
                if (!PlayAgain())
                {
                    break;
                }
                ResetGame();
            }
            Console.WriteLine("Thanks for playing!");
        }

        private void PlayRound()
        {
            while (true)
            {
                Console.WriteLine($"\n{currentPlayer.Name}'s turn ({currentPlayer.Mark})");
                board.Display();

                if (MakeMove())
                {
                    if (board.CheckWin(currentPlayer.Mark))
                    {
                        board.Display();
                        Console.WriteLine($"\n{currentPlayer.Name} wins!");
                        return;
                    }
                    if (board.IsFull())
                    {
                        board.Display();
                        Console.WriteLine("\nIt's a draw!");
                        return;
                    }
                    SwitchPlayer();
                }
            }
        }

        private bool MakeMove()
        {
            while (true)
            {
                Console.Write("Enter row (0-2): ");
                if (!int.TryParse(Console.ReadLine(), out int row))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                Console.Write("Enter column (0-2): ");
                if (!int.TryParse(Console.ReadLine(), out int col))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (board.PlaceMark(row, col, currentPlayer.Mark))
                {
                    return true;
                }
                Console.WriteLine("Invalid move. Try again.");
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == player1) ? player2 : player1;
        }

        private bool PlayAgain()
        {
            while (true)
            {
                Console.Write("Do you want to play again? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response == "y") return true;
                if (response == "n") return false;
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }
        }

        private void ResetGame()
        {
            board = new Board();
            currentPlayer = player1;
        }
    }
}
