using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = demensions[0];
            int m = demensions[1];
            string[,] matrix = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                string[] data = Console.ReadLine().Split();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = data[col];
                }
            }


            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "END")
                {
                    break;
                }
                string[] comandData = comand.Split();
                if (comandData.Length != 5 || comandData[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int rowOne = int.Parse(comandData[1]);
                int colOne = int.Parse(comandData[2]);
                int rowTwo = int.Parse(comandData[3]);
                int colTwo = int.Parse(comandData[4]);

                bool isValidOne = IsValidCell(rowOne, colOne, n, m);
                bool isValidTwo = IsValidCell(rowTwo, colTwo, n, m);

                if (!isValidOne || !isValidTwo)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string valueOne = matrix[rowOne, colOne];
                string valueTwo = matrix[rowTwo, colTwo];

                matrix[rowOne, colOne] = valueTwo;
                matrix[rowTwo, colTwo] = valueOne;

                PrintMatrix(matrix, n, m);
            }
        }

        private static void PrintMatrix(string[,] matrix, int n, int m)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
        }
    }
}
