using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }
            int curentRow = 0;
            int curentCol = 0;
            int sum1 = 0;
            int counter = n - 1;
            int sum2 = 0;
            for (int row = 0; row < n; row++)
            {
                sum1 += matrix[row, row];
                sum2 += matrix[row, counter];
                counter--;
            }
            int diferents = Math.Abs(sum1 - sum2);
            Console.WriteLine(diferents);


        }
    }
}
