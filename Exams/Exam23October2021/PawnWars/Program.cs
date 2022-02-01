using System;
using System.Linq;

namespace PawnWars
{
    class Program
    {
        static char[,] chessboard;
        static void Main(string[] args)
        {

            chessboard = new char[8, 8];
            for (int row = 0; row < chessboard.GetLength(0); row++)
            {
                string rows = Console.ReadLine();

                for (int col = 0; col < chessboard.GetLength(1); col++)
                {
                    chessboard[row, col] = rows[col];
                }
            }
            int wRow = 0;
            int wCol = 0;
            int bRow = 0;
            int bCol = 0;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (chessboard[row, col] == 'w')
                    {
                        wRow = row;
                        wCol = col;
                    }
                    if (chessboard[row, col] == 'b')
                    {
                        bRow = row;
                        bCol = col;
                    }
                }
            }
            while (true)
            {
                
                if (IsInChesBoard(wRow - 1, wCol - 1, 8))
                {
                    if (chessboard[wRow - 1, wCol - 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(bCol + 97)}{8 - bRow}.");
                        break;
                    }
                }
                if (IsInChesBoard(wRow - 1, wCol + 1, 8))
                {
                    if (chessboard[wRow - 1, wCol + 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(bCol + 97)}{8 - bRow}.");
                        break;
                    }
                }

                if (IsInChesBoard(wRow - 1, wCol, 8))
                {
                    wRow -= 1;
                   
                    if (wRow == 0)
                    {
                        Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(wCol + 97)}{8 - wRow}.");
                        break;
                    }
                    chessboard[wRow, wCol] = 'w';

                }
                if (IsInChesBoard(bRow + 1, bCol - 1, 8))
                {
                    if (chessboard[bRow +1, bCol - 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(wCol + 97)}{8 - wRow}.");
                        break;
                    }
                }
                if (IsInChesBoard(bRow + 1, bCol + 1, 8))
                {
                    if (chessboard[bRow + 1, bCol + 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(wCol + 97)}{8 - wRow}.");
                        break;
                    }
                }
                if (IsInChesBoard(bRow + 1, bCol, 8))
                {
                    bRow += 1;
                    if (bRow == 7)
                    {
                        Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(bCol + 97)}{8 - bRow}.");
                        break;
                    }
                    chessboard[bRow, bCol] = 'b';

                }
            }

           
        }

        private static bool IsInChesBoard(int row, int col, int v)
        {
            return row >= 0 && row < v && col >= 0 && col < v;
        }     
    }
}
