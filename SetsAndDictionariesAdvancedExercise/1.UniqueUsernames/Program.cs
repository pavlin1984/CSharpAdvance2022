using System;
using System.Collections.Generic;

namespace Problem_1._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                names.Add(text);
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
