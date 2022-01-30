using System;
using System.Linq;
using System.Collections.Generic;

namespace CountSymbols

{
    class Program
    {

        static void Main(string[] args)
        {

            string text = Console.ReadLine();
            Dictionary<char, int> words = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!words.ContainsKey(text[i]))
                {
                    words.Add(text[i], 0);
                }
                words[text[i]]++;
            }
            foreach (var item in words.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}