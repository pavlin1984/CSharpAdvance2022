using System;
using System.Collections.Generic;

namespace Problem_3._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> pereodicTable = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    pereodicTable.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ", pereodicTable));
        }
    }
}
