using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixElements = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            int N = matrixElements[0];
            int M = matrixElements[1];

            int[,] matrix = new int[N, M];
            for (int row = 0; row < N; row++)
            {
                int[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int maxSum = int.MinValue;
            int rowindex = 0;
            int colindex = 0;

            for (int row = 0; row < N - 2; row++)
            {
                for (int col = 0; col < M - 2; col++)
                {
                    int sum = matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        rowindex = row;
                        colindex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = rowindex; row < rowindex + 3; row++)
            {
                for (int col = colindex; col < colindex + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
