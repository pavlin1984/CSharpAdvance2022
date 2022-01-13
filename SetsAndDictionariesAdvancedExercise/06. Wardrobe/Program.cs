using System;
using System.Collections.Generic;
using System.Linq;
namespace Wardrobe

{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split(new[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string colour = elements[0];
                string[] allClothing = elements.Skip(1).ToArray();

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }
                // Blue->dress,jeans,hat
                foreach (string item in allClothing)
                {
                    if (!wardrobe[colour].ContainsKey(item))
                    {
                        wardrobe[colour].Add(item, 0);
                    }
                    wardrobe[colour][item]++;
                }
            }
            string[] found = Console.ReadLine().Split();

            foreach ((string color, Dictionary<string, int> colorData) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach ((string cloth, int count) in colorData)
                {
                    if (found[0] == color && found[1] == cloth)
                    {
                        Console.WriteLine($"* {cloth} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {count}");
                    }
                }
            }
        }
    }
}
