using System;
using System.Linq;
namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            for (int row = 0;  row < n;  row++)
            {
                string line = Console.ReadLine();
                char[] splited = line.Split("").Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = splited[col];
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
