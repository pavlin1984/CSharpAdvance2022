using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[,] matrix = new long[n, n];
            for (int row = 0; row < n; row++)
            {
                int[] curentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = curentRow[col];
                }
            }
            string[] elements = Console.ReadLine().Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < elements.Length; i += 2)
            {
                int bombRow = int.Parse(elements[i]);
                int bombCol = int.Parse(elements[i + 1]);

                long numToRemove = matrix[bombRow, bombCol];
                if (numToRemove > 0)
                {
                    matrix[bombRow, bombCol] = 0;
                    if (bombRow - 1 >= 0)
                    {
                        if (matrix[bombRow - 1, bombCol] > 0)
                        {
                            matrix[bombRow - 1, bombCol] -= numToRemove;
                        }

                    }
                    if (bombRow - 1 >= 0 && bombCol - 1 >= 0)
                    {
                        if (matrix[bombRow - 1, bombCol - 1] > 0)
                        {
                            matrix[bombRow - 1, bombCol - 1] -= numToRemove;
                        }

                    }
                    if (bombRow - 1 >= 0 && bombCol + 1 < n)
                    {
                        if (matrix[bombRow - 1, bombCol + 1] > 0)
                        {
                            matrix[bombRow - 1, bombCol + 1] -= numToRemove;
                        }
                    }
                    if (bombCol - 1 >= 0)
                    {
                        if (matrix[bombRow, bombCol - 1] > 0)
                        {
                            matrix[bombRow, bombCol - 1] -= numToRemove;
                        }
                    }
                    if (bombCol + 1 < n)
                    {
                        if (matrix[bombRow, bombCol + 1] > 0)
                        {
                            matrix[bombRow, bombCol + 1] -= numToRemove;
                        }
                    }
                    if (bombRow + 1 < n && bombCol - 1 >= 0)
                    {
                        if (matrix[bombRow + 1, bombCol - 1] > 0)
                        {
                            matrix[bombRow + 1, bombCol - 1] -= numToRemove;
                        }
                    }
                    if (bombRow + 1 < n)
                    {
                        if (matrix[bombRow + 1, bombCol] > 0)
                        {
                            matrix[bombRow + 1, bombCol] -= numToRemove;
                        }
                    }
                    if (bombRow + 1 < n && bombCol + 1 < n)
                    {
                        if (matrix[bombRow + 1, bombCol + 1] > 0)
                        {
                            matrix[bombRow + 1, bombCol + 1] -= numToRemove;
                        }
                    }
                }


            }


            int aliveCells = 0;
            long sum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {

                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }

            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
