using System;
using System.Linq;

namespace _5.Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rols = dimension[0];
            int cols = dimension[1];
            char[,] matrix = new char[rols, cols];

            string snake = Console.ReadLine();
            int currentLetter = 0;
            for (int row = 0; row < rols; row++)
            {
                if (row % 2 == 0)
                {

                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
            }
            for (int row = 0; row < rols; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
