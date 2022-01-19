using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> add = numbers =>
           {
               for (int i = 0; i < numbers.Length; i++)
               {
                   numbers[i] += 1;
               }
               
           };
            Action<int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }
                
            }; 
            Action<int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }
                
            };
           
            Action<int[]> printNumbers = numbers 
                => Console.WriteLine(string.Join(" ",numbers));

            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string comand = Console.ReadLine();

            while (comand!="end")
            {
                if (comand=="add")
                {
                    add(inputNumbers);
                }
                else if (comand=="multiply")
                {
                    multiply(inputNumbers);
                }
                else if (comand=="subtract")
                {
                    subtract(inputNumbers);
                }
                else if (comand=="print")
                {
                    printNumbers(inputNumbers);
                }


                comand = Console.ReadLine();
            }
        }
    }
}
