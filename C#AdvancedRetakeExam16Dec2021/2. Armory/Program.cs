using System;

namespace Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];
            int aRow = -1;
            int aCol = -1;
            int money = 0;
            bool outOfMatrix = false;
            bool enoughMoney = false;
            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                matrix[row] = new char[line.Length];
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row][col] = line[col];
                    if (matrix[row][col] == 'A')
                    {
                        aRow = row;
                        aCol = col;
                    }
                }
            }
            while (true)
            {
                matrix[aRow][aCol] = '-';
                int nextRow = 0;
                int nextCol = 0;
                string direction = Console.ReadLine();
                switch (direction)
                {
                    case "up":
                        nextRow = -1; 
                        break;
                    case "down":
                        nextRow = 1;  break;
                    case "left":
                        nextCol = -1; 
                        break;
                    case "right":
                        nextCol = 1; 
                         break;
                    default:
                        break;
                }
                if (IsInMatrix(matrix,aRow+nextRow,aCol+nextCol,rows))
                {
                    aRow += nextRow;
                    aCol += nextCol;
                    if (matrix[aRow][aCol]=='M')
                    {
                        matrix[aRow][aCol] = '-';
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < rows; col++)
                            {
                                if (matrix[row][col]=='M')
                                {
                                    aRow = row;
                                    aCol = col;
                                    matrix[aRow][aCol] = '-';
                                    break;
                                }
                            }
                        }
                    }
                    else if (char.IsDigit(matrix[aRow][aCol]))
                    {
                        money += matrix[aRow ][aCol ] - '0';
                        matrix[aRow ][aCol] = '-';
                        if (money>=65)
                        {
                            enoughMoney = true;
                            matrix[aRow ][aCol ] = 'A';
                            break;
                        }
                    }


                }
                else
                {
                    outOfMatrix = true;
                  
                    break;
                }
            }
            if (outOfMatrix)
            {
                Console.WriteLine("I do not need more swords!");
               
            }
            if (enoughMoney)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
             
            }
            Console.WriteLine($"The king paid {money} gold coins.");
            
            PrintMatrix(matrix, rows);
        }

        private static bool IsInMatrix(char[][] matrix, int row, int col,int rows)
        {
            return row >= 0 && row < rows && col >= 0 && col < rows;
        }

        private static void PrintMatrix(char[][] matrix, int rows)
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
