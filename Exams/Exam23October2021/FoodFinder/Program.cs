using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowelsQueue = new Queue<char>(Console.ReadLine().Split(" ").Select(char.Parse).ToArray());
            var consonantStack = new Stack<char>(Console.ReadLine().Split(" ").Select(char.Parse).ToArray());
            

            var listOfPossibleWords = new Dictionary<string, HashSet<char>>()
            {
                {"pear",new HashSet<char>()},
                {"flour",new HashSet<char>()},
                {"pork", new HashSet<char>()},
                {"olive",new HashSet<char>()}
            };
            while (consonantStack.Count!=0)
            {
                
                var currenConsonant = consonantStack.Pop();
                var currentVowel = vowelsQueue.Dequeue();

                foreach (var word in listOfPossibleWords.Keys)
                {
                    if (word.Contains(currentVowel))
                    {
                        listOfPossibleWords[word].Add(currentVowel);
                    }
                    if (word.Contains(currenConsonant))
                    {
                        listOfPossibleWords[word].Add(currenConsonant);
                    }
                }
                vowelsQueue.Enqueue(currentVowel);
                
            }
            int foundedWords = listOfPossibleWords.Where(x => x.Key.Length == x.Value.Count).Count();

            Console.WriteLine($"Words found: {foundedWords}");

            foreach (var word in listOfPossibleWords)
            {
                if (word.Key.Length==word.Value.Count)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }
    }
}
