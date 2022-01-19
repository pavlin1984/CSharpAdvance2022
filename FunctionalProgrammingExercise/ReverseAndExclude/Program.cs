using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDivisible = (n, m) => n % m == 0;
            int[] numbres = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divNumber = int.Parse(Console.ReadLine());

            int[] result = numbres.Where(x => !isDivisible(x, divNumber))
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
