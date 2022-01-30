using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int colls = input[1];

            int[,] matrix = new int[rows, colls];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int coll = 0; coll < colls; coll++)
                {
                    matrix[row, coll] = rowData[coll];
                }
            }
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < colls; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(colls);
            Console.WriteLine(sum);

        }
    }
}
