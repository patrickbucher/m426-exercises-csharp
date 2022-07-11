using System;

namespace TicTacToe
{
    public class Game
    {
        public static void Main()
        {
            var board = new Board();
            var player = 2;
            var symbol = 'o';
            var won = false;
            do
            {
                int row = -1, col = -1;
                var validInput = false;
                var validMove = false;
                player = player == 1 ? 2 : 1;
                symbol = symbol == 'x' ? 'o' : 'x';
                do
                {
                    Console.Write(board.ToString());
                    Console.Write($"Player {player} ({symbol}), enter row and column of empty field: ");
                    var input = Console.ReadLine();
                    var tokens = input.Split(' ');
                    try
                    {
                        if (tokens.Length == 2)
                        {
                            row = Convert.ToInt32(tokens[0]);
                            col = Convert.ToInt32(tokens[1]);
                            validInput = true;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("invalid number format");
                        validInput = false;
                    }
                    try
                    {
                        // transform to zero-based index, input is 1-based
                        won = board.Set(row - 1, col - 1, player);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("invalid field picked");
                        validMove = false;
                    }
                } while (!validInput && !validMove);
            } while (!won && board.FreeFields > 0);
            if (won)
            {
                Console.WriteLine($"Player {player}, a winner is you!");
            }
            else
            {
                Console.WriteLine("draw");
            }
        }
    }
}
