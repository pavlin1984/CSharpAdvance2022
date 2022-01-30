﻿using System;
using System.Linq;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SelectionSort(numbers);
            Console.WriteLine(string.Join(" ",numbers));
        }

        private static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i <numbers.Length; i++)
            {
                int index = i;
                int minNumber = int.MaxValue;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j]<numbers[i] && numbers[j]<minNumber)
                    {
                        index = j;
                        minNumber = numbers[j];
                        // 3 4 5 6 2 3-> 2 3 ...
                    }
                    
                }
                int temp = numbers[i];
                numbers[i] = numbers[index];
                numbers[index] = temp;
            }
        }
    }
}
