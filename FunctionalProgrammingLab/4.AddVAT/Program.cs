using System;
using System.Collections.Generic;
using System.Linq;

namespace Т4.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> price = Console.ReadLine().Split(", ").Select(double.Parse).ToList();

            Func<double, double> vatAdder = n => n + n * 0.2;
            price = price.Select(vatAdder).ToList();

            foreach (var item in price)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
