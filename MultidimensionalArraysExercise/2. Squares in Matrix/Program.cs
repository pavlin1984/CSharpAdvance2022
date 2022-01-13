using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = matrixDimensions[0];
            int m = matrixDimensions[1];
            char[,] matrix = new char[n, m];
            int count = 0;
            for (int row = 0; row < n; row++)
            {
                char[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            for (int row = 0; row <= n - 2; row++)
            {
                for (int col = 0; col <= m - 2; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                       matrix[row, col] == matrix[row + 1, col] &&
                       matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
