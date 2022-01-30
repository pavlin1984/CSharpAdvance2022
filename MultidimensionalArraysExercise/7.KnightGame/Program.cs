using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] chessBoard = new char[n, n];
            FillMatrix(chessBoard, n);

            int countReplaced = 0;
            int rowKiler = 0;
            int colKiler = 0;

            while (true)
            {
                int maxAttacks = 0;
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int countAtacks = 0;
                        if (currentSymbol == 'K')
                        {
                            //1 row +2   col-1 done
                            //2 row + 2  col + 1 done
                            //3 row - 2  col + 1 done
                            //4 row - 2  col - 1 done
                            //5 row - 1 col - 2 done
                            //6 row - 1 col + 2 
                            //7 row + 1 col - 2
                            //8 row + 1 col + 2
                            countAtacks = GetAttacks(chessBoard, row, col, countAtacks);
                            if (countAtacks > maxAttacks)
                            {
                                maxAttacks = countAtacks;
                                rowKiler = row;
                                colKiler = col;
                            }

                        }
                    }
                }




                if (maxAttacks > 0)
                {
                    chessBoard[rowKiler, colKiler] = '0';
                    countReplaced++;

                }
                else
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
            }

        }

        private static int GetAttacks(char[,] chessBoard, int row, int col, int countAtacks)
        {
            if (IsInside(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
            {
                countAtacks++;
            }
            if (IsInside(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
            {
                countAtacks++;
            }

            return countAtacks;
        }

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0) && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
        }

        private static void FillMatrix(char[,] chessBoard, int n)
        {

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    chessBoard[row, col] = currentRow[col];
                }
            }
        }
    }
}
