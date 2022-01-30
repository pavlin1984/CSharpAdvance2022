using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_1._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string, SortedSet<string>>>();

            string text = Console.ReadLine();
            while (text != "Statistics")
            {
                string[] elements = text.Split();
                string vlogarName = elements[0];
                if (elements[1] == "joined")
                {
                    //	"{vloggername}" joined The V - Logger
                    if (!app.ContainsKey(vlogarName))
                    {
                        app.Add(vlogarName, new Dictionary<string, SortedSet<string>>());
                        app[vlogarName].Add("following", new SortedSet<string>());
                        app[vlogarName].Add("followers", new SortedSet<string>());

                    }
                }
                else
                {
                    string secondVlogarName = elements[2];
                    if (app.ContainsKey(vlogarName) && app.ContainsKey(secondVlogarName) && vlogarName != secondVlogarName)

                    {
                        //Saffrona followed EmilConrad
                        app[vlogarName]["following"].Add(secondVlogarName);
                        app[secondVlogarName]["followers"].Add(vlogarName);
                    }
                }



                text = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {app.Count} vloggers in its logs.");
            var sorted = app.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["following"].Count).ToDictionary(x => x.Key, y => y.Value);
            int i = 0;
            foreach (var vloger in sorted)
            {
                i++;
                Console.WriteLine($"{i}. {vloger.Key} : {vloger.Value["followers"].Count} followers, {vloger.Value["following"].Count} following");
                if (i == 1)
                {
                    foreach (var followeres in vloger.Value["followers"])
                    {
                        Console.WriteLine($"*  {followeres}");
                    }
                }

            }


        }
    }
}
