using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstNumbers = new HashSet<int>();
            HashSet<int> secondNumbers = new HashSet<int>();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = numbers[0];
            int m = numbers[1];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstNumbers.Add(num);

            }
            for (int j = 0; j < m; j++)
            {
                int num = int.Parse(Console.ReadLine());

                secondNumbers.Add(num);

            }
            foreach (var num in firstNumbers)
            {
                if (secondNumbers.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }




        }
    }
}
