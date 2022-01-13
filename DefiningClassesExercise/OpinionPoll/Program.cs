using System;
using System.Collections.Generic;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family=new Family 
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split();
                string name = text[0];
                int age = int.Parse(text[1]);
                Person person = new Person(name,age);
                AddPerson(name, age);
            }
        }

        
    }
}
