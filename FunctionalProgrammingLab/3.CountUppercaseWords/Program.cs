using System;
using System.Linq;
namespace T3.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Predicate<string> isStartWithCapital = w => Char.IsUpper(w[0]);
            Console.WriteLine(string.Join("\n", words.Where(x=>isStartWithCapital(x))));
        }
    }
}
