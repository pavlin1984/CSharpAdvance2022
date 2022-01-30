using System;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameTownInput = Console.ReadLine().Split();
            MyTuple<string, string> nameTown = new MyTuple<string, string>($"{nameTownInput[0]} {nameTownInput[1]}",
            $"{nameTownInput[2]}");

            string[] nameBeerInput = Console.ReadLine().Split();
            string name = nameBeerInput[0];
            int litres = int.Parse(nameBeerInput[1]);
            MyTuple<string, int> nameBeer = new MyTuple<string, int>(name,litres);

            string[] numbersInput = Console.ReadLine().Split();
            int integer = int.Parse(numbersInput[0]);
            double doubleNumber = double.Parse(numbersInput[1]);
            MyTuple<int, double> numbers = new MyTuple<int,double>(integer,doubleNumber);

            //Adam Smith California
            //Mark 2
            //23 21.23212321
            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbers.GetItems());

        }
    }
}
