using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            int samRow = -1;
            int samCol = -1;
            int money = 0;
            bool outOfBakery = false;
            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                matrix[row] = new char[line.Length];
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row][col] = line[col];
                    if (matrix[row][col] == 'S')
                    {
                        samRow = row;
                        samCol = col;
                    }
                }
            }
            while (true)
            {
                string direction = Console.ReadLine();
                int nextRow = 0;
                int nexCol = 0;
                
                switch (direction)
                {
                    case "up": nextRow = -1; break;
                    case "down": nextRow = 1; break;
                    case "left": nexCol = -1; break;
                    case "right": nexCol = 1;break;
                    default:
                        break;
                }
                if (InMatrix(matrix, samRow + nextRow, samCol + nexCol, rows))
                {
                    matrix[samRow][samCol] = '-';
                    samRow += nextRow;
                    samCol += nexCol;
                    if (matrix[samRow][samCol]=='O')
                    {
                        matrix[samRow][samCol] = '-';
                    }
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < rows; col++)
                        {
                            if (matrix[row][col]=='O')
                            {
                                samRow = row;
                                samCol = col;
                            }
                        }
                    }

                    if (char.IsDigit(matrix[samRow][samCol]))
                    {
                        money += (int)(matrix[samRow][samCol]-48);
                       
                        if (money>=50)
                        {
                            matrix[samRow][samCol] = 'S';
                            break;
                        }
                        matrix[samRow][samCol] = '-';
                    }
                }
                else
                {
                    matrix[samRow][samCol] = '-';
                    outOfBakery = true;
                    break;
                }
            }
            if (outOfBakery)
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            else
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }
            
            
            Console.WriteLine($"Money: {money}");
            PrintMatrix(rows, matrix);
        }

        private static bool InMatrix(char[][] matrix, int row, int col, int rows)
        {
            return row >= 0 && col >= 0 && row < rows && col < rows;
        }

        private static void PrintMatrix(int rows, char[][] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
