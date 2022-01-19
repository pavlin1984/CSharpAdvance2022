using System;
using System.Linq;
namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getSmallestNumber = numbers =>
               {
                   int minValue = int.MaxValue;
                   foreach (var num in numbers)
                   {
                       if (num<minValue)
                       {
                            minValue=num;
                       }
                       
                   }
                   return minValue;
               };
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(getSmallestNumber(numbers));
        }
    }
}
