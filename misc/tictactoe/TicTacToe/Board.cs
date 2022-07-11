using System;
using System.Text;

namespace TicTacToe
{
    public class Board
    {
        private int[][] fields;
        private int freeFields;

        public int[][] Fields => fields;

        public int FreeFields => freeFields;

        public Board()
        {
            this.fields = new int[][]
            {
                new int[]{0, 0, 0},
                new int[]{0, 0, 0},
                new int[]{0, 0, 0},
            };
            this.freeFields = 9;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendLine("  1 2 3");
            for (int r = 0; r < this.fields.Length; r++)
            {
                output.Append($"{r + 1} ");
                for (int c = 0; c < this.fields[r].Length; c++)
                {
                    char symbol = '-';
                    switch (this.fields[r][c])
                    {
                        case 1:
                            symbol = 'x';
                            break;
                        case 2:
                            symbol = 'o';
                            break;
                    }
                    output.Append($"{symbol} ");
                }
                output.Append('\n');
            }
            return output.ToString();
        }

        public bool Set(int row, int col, int player)
        {
            ValidateParams(row, col, player);
            this.fields[row][col] = player;
            this.freeFields--;
            return HasWon(row, col, player);
        }

        private bool HasWon(int r, int c, int player)
        {
            var win = new int[3] { player, player, player };
            var row = this.fields[r];
            var col = new int[3] { this.fields[0][c], this.fields[1][c], this.fields[2][c] };
            var diagUp = new int[3] { fields[2][0], fields[1][1], fields[0][2] };
            var diagDown = new int[3] { fields[0][0], fields[1][1], fields[2][2] };
            return ArrayEqual(win, row) || ArrayEqual(win, col) ||
                   ArrayEqual(win, diagUp) || ArrayEqual(win, diagDown);
        }

        private bool ArrayEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }

        private void ValidateParams(int row, int col, int player)
        {
            if (row < 0 || row > 2)
            {
                throw new ArgumentOutOfRangeException("row must be between 0 and 3");
            }
            if (col < 0 || row > 2)
            {
                throw new ArgumentOutOfRangeException("col must be between 0 and 3");
            }
            if (player != 1 && player != 2)
            {
                throw new ArgumentOutOfRangeException("player must be 1 or 2");
            }
            if (this.fields[row][col] != 0)
            {
                throw new ArgumentException($"field[{row}][{col}] is not empty");
            }
        }
    }
}