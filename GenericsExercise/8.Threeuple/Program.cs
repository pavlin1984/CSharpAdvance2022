using System;

namespace T8.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adam Smith Wallstreet New York
            //Mark 18 drunk
            //Karren 0.10 USBank

            string[] namesInput = Console.ReadLine().Split();
            string fuulName = $"{namesInput[0]} {namesInput[1]}";
            string street = namesInput[2];
            string town = namesInput[3];
            if (namesInput.Length==5)
            {
                town = $"{namesInput[3]} {namesInput[4]}";
            }
            Threeuple<string, string, string> names = new Threeuple<string, string,string>(fuulName,street,town);

            string[] nameBeerInput = Console.ReadLine().Split();
            string name = nameBeerInput[0];
            int litres = int.Parse(nameBeerInput[1]);
            bool isDrunk = nameBeerInput[2]=="drunk";

            Threeuple<string, int,bool> nameBeer = new Threeuple<string, int,bool>(name, litres,isDrunk);

            string[] numbersInput = Console.ReadLine().Split();
            string nameInput = numbersInput[0];
            double doubleNumber = double.Parse(numbersInput[1]);
            string bank = numbersInput[2];
            Threeuple<string, double,string> numbers = new Threeuple<string, double,string>(nameInput, doubleNumber,bank);

            

            Console.WriteLine(names.GetItems());
            Console.WriteLine(nameBeer.GetItems());
            Console.WriteLine(numbers.GetItems());
        }
    }
}
