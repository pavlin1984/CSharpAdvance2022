using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static char[][] matrix;
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());
            int[] cordinates = Console.ReadLine().Split(new[] {","," "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int shipSecond = 0;
            int shipFirst = 0;
            int totalShip = 0;
            matrix = new char[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                char[] inputLine = Console.ReadLine().Where(x => !Char.IsWhiteSpace(x)).ToArray();
                matrix[i] = inputLine;
               
            }
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfRows; col++)
                {
                    if (matrix[row][col]=='>')
                    {
                        shipSecond++;
                    }
                    if (matrix[row][col]=='<')
                    {
                        shipFirst ++;
                    }
                }
            }
            totalShip += shipFirst;
            totalShip += shipSecond;
            for (int i = 0; i < cordinates.Length; i+=2)
            {
                int x = cordinates[i];
                int y = cordinates[i+1];
                if (!IsInMatrix(x,y))
                {
                    continue;
                }
                if (matrix[x][y]=='#')
                {
                    if (IsInMatrix( x - 1, y))
                    {
                        if (matrix[x - 1][y] == '>')
                        {
                            matrix[x - 1][y] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix( x - 1, y - 1))
                    {
                        if (matrix[x - 1][y - 1] == '>')
                        {
                            matrix[x - 1][y - 1] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix(x-1,y+1))
                    {
                        if (matrix[x - 1][y + 1] == '>')
                        {
                            matrix[x - 1][y + 1] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix(x,y-1))
                    {
                        if (matrix[x][y - 1] == '>')
                        {
                            matrix[x][y - 1] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix(x,y+1))
                    {
                        if (matrix[x][y + 1] == '>')
                        {
                            matrix[x][y + 1] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix(x+1,y))
                    {
                        if (matrix[x + 1][y] == '>')
                        {
                            matrix[x + 1][y] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix(x+1,y-1))
                    {

                        if (matrix[x + 1][y - 1] == '>')
                        {
                            matrix[x + 1][y - 1] = '*';
                            shipSecond--;
                        }
                    }
                    if (IsInMatrix(x+1,y+1))
                    {
                        if (matrix[x + 1][y + 1] == '>')
                        {
                            matrix[x + 1][y + 1] = '*';
                            shipSecond--;
                        }
                    }

                    if (IsInMatrix(x-1,y))
                    {
                        if (matrix[x - 1][y] == '<')
                        {
                            matrix[x - 1][y] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x-1,y-1))
                    {

                        if (matrix[x - 1][y - 1] == '<')
                        {
                            matrix[x - 1][y - 1] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x-1,y+1))
                    {
                        if (matrix[x - 1][y + 1] == '<')
                        {
                            matrix[x - 1][y + 1] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x,y-1))
                    {
                        if (matrix[x][y - 1] == '<')
                        {
                            matrix[x][y - 1] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x,y+1))
                    {
                        if (matrix[x][y + 1] == '<')
                        {
                            matrix[x][y + 1] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x+1,y))
                    {

                        if (matrix[x + 1][y] == '<')
                        {
                            matrix[x + 1][y] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x+1,y-1))
                    {
                        if (matrix[x + 1][y - 1] == '<')
                        {
                            matrix[x + 1][y - 1] = '*';
                            shipFirst--;
                        }
                    }
                    if (IsInMatrix(x+1,y+1))
                    {

                        if (matrix[x + 1][y + 1] == '<')
                        {
                            matrix[x + 1][y + 1] = '*';
                            shipFirst--;
                        }
                    }   
                              

                    if (shipFirst<=0||shipSecond<=0)
                    {
                        break;
                    }
                }
                if (matrix[x][y]=='>')
                {
                    matrix[x][y] = '*';
                    shipSecond--;
                    if (shipSecond<=0)
                    {
                        break;
                    }
                }
                if (matrix[x][y]=='<')
                {
                    matrix[x][y] = '*';
                    shipFirst--;
                    if (shipFirst<=0)
                    {
                        break;
                    }
                }
               

            }
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < numberOfRows; col++)
                {
                    if (matrix[row][col] == '>' || matrix[row][col] == '<')
                    {
                        totalShip--;
                    }

                }
            }
            if (shipFirst<=0)
            {
                Console.WriteLine($"Player Two has won the game! {totalShip} ships have been sunk in the battle.");
            }
            if (shipSecond<=0)
            {
                Console.WriteLine($"Player One has won the game! {totalShip} ships have been sunk in the battle.");
            }
            if (shipFirst>0 && shipSecond>0)
            {
                Console.WriteLine($"It's a draw! Player One has {shipFirst} ships left. Player Two has {shipSecond} ships left.");
            }


        }

        private static bool IsInMatrix( int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
        }
    }
}
