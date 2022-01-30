using System;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int index = BinarySearch(numbers, element);
            Console.WriteLine(index);
        }

        private static int BinarySearch(int[] numbers, int element)
        {
            int low = 0;
            int high=numbers.Length - 1;
            while (low<=high)
            {
                int mid = low + (high - low) / 2;
                if (element>numbers[mid])
                {
                    low = mid + 1;
                }
                else if (element<numbers[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
