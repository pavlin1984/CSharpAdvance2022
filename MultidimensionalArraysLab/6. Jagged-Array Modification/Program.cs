using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            string comand = Console.ReadLine();
            while (comand!="END")
            {
                string[] splited = comand.Split();
                int row = int.Parse(splited[1]);
                int col = int.Parse(splited[2]);
                int value = int.Parse(splited[3]);
                if (splited[0]=="Add")
                {
                    if (row<0||row>=n||col<0||col>=n)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[row, col] += value;
                    }
                    
                }
                else if (splited[0]=="Subtract")
                {
                    if (row < 0 || row >= n || col < 0 || col >= n)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[row, col] -= value;
                    }
                    
                }


                comand = Console.ReadLine();
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <n; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
