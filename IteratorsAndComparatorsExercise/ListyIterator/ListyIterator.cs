using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
   public class ListyIterator<T>
    {
        private List<T> colection;
        private int currentIndex;

        public ListyIterator(params T[]data)
        {
            colection = new List<T>(data);
            currentIndex = 0;
        }

        public bool HasNext()
        {
            return currentIndex < colection.Count-1;
        }
        public bool Move()
        {
            bool CanMove = HasNext();
            if (CanMove)
            {
                currentIndex++;
            }
            return CanMove;
        }

        public void Print()
        {
            if (colection.Count==0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            Console.WriteLine($"{colection[currentIndex]}");
        }
        
       
    }
}
