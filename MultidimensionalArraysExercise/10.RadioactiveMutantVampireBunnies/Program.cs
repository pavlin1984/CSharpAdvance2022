using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = matrixSize[0];
            int y = matrixSize[1];
            int playerRow = -1;
            int playerCol = -1;
            char[,] matrix = new char[x, y];
            for (int row = 0; row < x; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < y; col++)
                {
                    matrix[row, col] = line[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string directions = Console.ReadLine();
            for (int i = 0; i < directions.Length; i++)
            {
                int nextPlayerRow = 0;
                int nextPlayerCol = 0;
                char curentDirection = directions[i];
                switch (curentDirection)
                {
                    case 'U': nextPlayerRow = -1; break;
                    case 'D': nextPlayerRow = 1; break;
                    case 'L': nextPlayerCol = -1; break;
                    case 'R': nextPlayerCol = 1; break;
                    default:
                        break;
                }

                bool hasWon = false;
                bool hasDead = false;
                matrix[playerRow, playerCol] = '.';

                if (!InMatrix(matrix, playerRow + nextPlayerRow, playerCol + nextPlayerCol))
                {
                    hasWon = true;
                }
                else
                {
                    playerRow += nextPlayerRow;
                    playerCol += nextPlayerCol;
                    if (matrix[playerRow, playerCol] == 'B')
                    {
                        hasDead = true;
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = 'P';
                    }
                }

                List<int[]> buniesCordinates = new List<int[]>();
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            buniesCordinates.Add(new int[] { row, col });
                        }
                    }
                }

                foreach (var item in buniesCordinates)
                {
                    int bunyRow = item[0];
                    int bunyCol = item[1];
                    if (InMatrix(matrix, bunyRow + 1, bunyCol))
                    {
                        if (matrix[bunyRow + 1, bunyCol] == 'P')
                        {
                            hasDead = true;
                        }
                        matrix[bunyRow + 1, bunyCol] = 'B';
                    }
                    if (InMatrix(matrix, bunyRow - 1, bunyCol))
                    {
                        if (matrix[bunyRow - 1, bunyCol] == 'P')
                        {
                            hasDead = true;
                        }
                        matrix[bunyRow - 1, bunyCol] = 'B';
                    }
                    if (InMatrix(matrix, bunyRow, bunyCol - 1))
                    {
                        if (matrix[bunyRow, bunyCol - 1] == 'P')
                        {
                            hasDead = true;
                        }
                        matrix[bunyRow, bunyCol - 1] = 'B';
                    }
                    if (InMatrix(matrix, bunyRow, bunyCol + 1))
                    {
                        if (matrix[bunyRow, bunyCol + 1] == 'P')
                        {
                            hasDead = true;
                        }
                        matrix[bunyRow, bunyCol + 1] = 'B';
                    }
                }

                if (hasWon)
                {
                    PrintMatrix(x, y, matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
                if (hasDead)
                {
                    PrintMatrix(x, y, matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }


            }


        }

        private static void PrintMatrix(int x, int y, char[,] matrix)
        {
            for (int row = 0; row < x; row++)
            {
                for (int col = 0; col < y; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool InMatrix(char[,] matrix, int playerRow, int playerCol)
        {
            return playerRow >= 0 && playerRow < matrix.GetLength(0) && playerCol >= 0 && playerCol < matrix.GetLength(1);
        }
    }
}
