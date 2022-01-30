using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = elements[col];
                }
            }
            int currentrow = 0;
            int currentcol = 0;
            int sum = 0;  
            while (true)
            {
                if (currentcol>=n|| currentrow>=n)
                {
                    break;
                }
                sum += matrix[currentrow, currentcol];
                currentrow++;
                currentcol++;
            }
            Console.WriteLine(sum);
        }
    }
}
