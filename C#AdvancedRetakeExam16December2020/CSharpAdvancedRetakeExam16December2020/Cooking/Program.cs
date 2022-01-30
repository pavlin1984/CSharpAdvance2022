using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {

            int bread = 0;
            int cake = 0;
            int pastiry = 0;
            int fruitPie = 0;
            bool sucses = false; 
         
           
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> ingrediants = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            while (liquids.Count>0&& ingrediants.Count>0)
            {
                int curLiquid = liquids.Dequeue();
                int curIngrediant = ingrediants.Peek();
                int sum = curLiquid + curIngrediant;
                if (sum==25)
                {
                    bread++;
                    ingrediants.Pop();
                    continue;
                }
                if (sum==50)
                {
                    cake++;
                    ingrediants.Pop();
                    continue;
                }
                if (sum==75)
                {
                    pastiry++;
                    ingrediants.Pop();
                    continue;
                }
                if (sum==100)
                {
                    fruitPie++;
                    ingrediants.Pop();
                    continue;
                }
                if (bread>0&&cake>0&& pastiry>0 &&fruitPie>0)
                {
                    sucses = true;
                    break;
                }
                else
                {
                    ingrediants.Push(ingrediants.Pop() + 3);
                }
               
            }
            if (bread > 0 && cake > 0 && pastiry > 0 && fruitPie > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count==0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquids)}");
            }
            if (ingrediants.Count==0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ",ingrediants)}");
            }
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastiry}");
            

        }
    }
}
