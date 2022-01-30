﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4.GenericSwapMethodIntegers
{
   public class Box<T>
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T item = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = item;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
