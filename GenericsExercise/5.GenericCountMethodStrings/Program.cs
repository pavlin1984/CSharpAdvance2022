using System;

namespace GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            Box<string> box = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input =Console.ReadLine();
                box.Add(input);
            }
            string itemToCompare = Console.ReadLine();

           int result= box.CountGreaterThan(itemToCompare);
            Console.WriteLine(result);
        }
    }
}
