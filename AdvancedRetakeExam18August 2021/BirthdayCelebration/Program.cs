using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> eatCapacity = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int waistedFood = 0;
            while (eatCapacity.Count>0&&plates.Count>0)
            {
                int foodCapacity = eatCapacity.Pop();
                int gestPlates = plates.Pop();
                if (gestPlates>=foodCapacity)
                {
                    waistedFood += gestPlates - foodCapacity;
                }
                else
                {
                    int foodToAdd = foodCapacity - gestPlates;
                    eatCapacity.Push(foodToAdd);
                }
            }
            if (eatCapacity.Count>0)
            {
                Console.WriteLine($"Guests: {string.Join(" ",eatCapacity)}");
            }
            if (plates.Count>0)
            {
                Console.WriteLine($"Plates: {string.Join(" ",plates)}");
            }
            Console.WriteLine($"Wasted grams of food: {waistedFood}");
                        
        }
    }
}
