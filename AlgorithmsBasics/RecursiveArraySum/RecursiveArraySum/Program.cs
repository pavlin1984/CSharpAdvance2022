using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integer = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = SumArray(integer, 0);
            Console.WriteLine(sum);
        }

        private static int SumArray(int[] integer, int index)
        {
            if (index==integer.Length)
            {
                return 0;
            }
            int sum = integer[index] + SumArray(integer, index + 1);
            return sum;
        }
    }
}
