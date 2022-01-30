using System;
using System.Linq;
namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = "";
            ListyIterator<string> listy = null;
            while ((command = Console.ReadLine()) != "END")
            {
                var elements = command.Split();
                if (elements[0] == "Create")
                {
                    listy = new ListyIterator<string>(elements.Skip(1).ToArray());
                }
                else if (elements[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }
                else if (elements[0] == "Print")
                {
                    listy.Print();
                }
                else if (elements[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }
                else if (elements[0]=="PrintAll")
                {
                    foreach (string item in listy)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
