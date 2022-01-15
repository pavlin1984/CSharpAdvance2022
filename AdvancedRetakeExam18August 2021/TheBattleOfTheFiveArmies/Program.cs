using System;

namespace TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int armyRow = -1;
            int armyCol = -1;
            char[][] matrix = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                matrix[row] = new char[line.Length];
                for (int col = 0; col < line.Length; col++)
                {
                    matrix[row][col] = line[col];
                    if (matrix[row][col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }
            while (true)
            {
                n--;
                string[] input = Console.ReadLine().Split();
                string direction = input[0];
                int oRow = int.Parse(input[1]);
                int oCol = int.Parse(input[2]);
                if (InMatrix(matrix, oRow, oCol, rows))
                {
                    matrix[oRow][oCol] = 'O';
                }
                matrix[armyRow][armyCol] = '-';
                if (direction == "up")
                {
                    if (InMatrix(matrix, armyRow - 1, armyCol, rows))
                    {
                        armyRow--;
                    }
                }
                if (direction == "down")
                {
                    if (InMatrix(matrix, armyRow + 1, armyCol, rows))
                    {
                        armyRow++;
                    }
                }
                if (direction == "right")
                {
                    if (InMatrix(matrix, armyRow, armyCol + 1, rows))
                    {
                        armyCol++;
                    }
                }
                if (direction == "left")
                {
                    if (InMatrix(matrix, armyRow, armyCol - 1, rows))
                    {
                        armyCol--;
                    }
                }

                if (matrix[armyRow][armyCol] == 'O')
                {
                    n -= 2;
                    if (n <= 0)
                    {
                        Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                        matrix[armyRow][armyCol] = 'X';
                        break;
                    }



                }
                if (matrix[armyRow][armyCol] == 'M')
                {
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {n}");
                    matrix[armyRow][armyCol] = '-';
                    break;
                }
                if (n<=0)
                {
                    Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                    matrix[armyRow][armyCol] = 'X';
                    break;
                }
                matrix[armyRow][armyCol] = 'A';


            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }

        }

        private static bool InMatrix(char[][] matrix, int armyRow, int armyCol, int rows)
        {
            return armyRow >= 0 && armyRow < rows && armyCol >= 0 && armyCol < matrix[armyRow].Length;
        }
    }
}
