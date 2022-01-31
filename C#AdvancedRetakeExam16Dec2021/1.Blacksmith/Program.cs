using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<int, string> swords = new Dictionary<int, string>
            {
                {70, "Gladius"},
                {80,"Shamshir" },
                {90,"Katana" },
                {110, "Sabre" },
                {150,"Broadsword" }
            };

            Dictionary<string, int> quantity = new Dictionary<string, int>();
            int totalSwards = 0;
            while (steel.Count>0 && carbon.Any())
            {
                int currentSteel = steel.Dequeue();
                int currentCarbon = carbon.Peek();
                int sum = currentSteel + currentCarbon;
               
                if (swords.ContainsKey(sum))
                {
                    totalSwards++;
                    if (!quantity.ContainsKey(swords[sum]))
                    {
                        quantity.Add(swords[sum], 0);
                    }
                    quantity[swords[sum]]++;
                  
                    carbon.Pop();
                }
                else
                {
                    carbon.Push(carbon.Pop()+5);
                }
            }
            if (quantity.Count==0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }   
            else
            {   
                Console.WriteLine($"You have forged {totalSwards} swords.");
            }
            if (steel.Count==0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            }
            if (carbon.Count==0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",carbon)}");
            }
            foreach (var item in quantity.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{ item.Key}: { item.Value}");
            }

            
               
        }
    }
}
