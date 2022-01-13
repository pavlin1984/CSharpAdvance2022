using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] comands = Console.ReadLine().Split();
            int minerRow = -1;
            int minerCol = -1;
            int coalCount = 0;
            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                char[] fieldInfo = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = fieldInfo[col];
                    if (fieldInfo[col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    if (fieldInfo[col] == 'c')
                    {
                        coalCount++;
                    }
                }
            }

            int newMinerRow = minerRow;
            int newMinerCol = minerCol;
            foreach (var comand in comands)
            {

                if (comand == "up")
                {
                    newMinerRow--;
                    if (newMinerRow < 0)
                    {
                        newMinerRow++;
                        continue;
                    }

                }
                else if (comand == "down")
                {
                    newMinerRow++;
                    if (newMinerRow == n)
                    {
                        newMinerRow--;
                        continue;
                    }
                }
                else if (comand == "left")
                {
                    newMinerCol--;
                    if (newMinerCol < 0)
                    {
                        newMinerCol++;
                        continue;
                    }
                }
                else if (comand == "right")
                {
                    newMinerCol++;
                    if (newMinerCol == n)
                    {
                        newMinerCol--;
                        continue;
                    }
                }

                matrix[minerRow, minerCol] = '*';

                if (matrix[newMinerRow, newMinerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({newMinerRow}, {newMinerCol})");
                    return;
                }
                if (matrix[newMinerRow, newMinerCol] == 'c')
                {
                    coalCount--;
                    if (coalCount == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({newMinerRow}, {newMinerCol})");
                        return;
                    }
                    matrix[newMinerRow, newMinerCol] = '*';
                }
            }


            if (coalCount > 0)
            {
                Console.WriteLine($"{coalCount} coals left. ({newMinerRow}, {newMinerCol})");
            }


        }

    }
}
