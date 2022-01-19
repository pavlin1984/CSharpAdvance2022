using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printColection=input
                => Console.WriteLine(string.Join(Environment.NewLine,input));

            string[] input = Console.ReadLine().Split();
            printColection(input);

        }
    }
}
