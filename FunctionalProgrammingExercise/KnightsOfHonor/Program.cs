using System;
using System.Collections.Generic;
using System.Linq;
namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> printColection = input
                   =>input.ForEach(x=>Console.WriteLine($"Sir {x}"));

            List<string> input = Console.ReadLine().Split().ToList();
            printColection(input);
        }
    }
}
