using System;
using System.Collections.Generic;
using System.Linq;
namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;
            Action<List<int>> printIntegers=inputNumbers
                => Console.WriteLine(string.Join(" ",inputNumbers));
            

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).ToList();
           
            string evenOdd = Console.ReadLine();
            if (evenOdd=="even")
            {
                printIntegers(numbers.FindAll(isEven));
            }
            if (evenOdd=="odd")
            {
                printIntegers(numbers.FindAll(x => !isEven(x)));
            }
        }
    }
}
