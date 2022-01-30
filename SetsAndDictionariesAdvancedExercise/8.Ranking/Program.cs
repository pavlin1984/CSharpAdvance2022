using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_8._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            //contest, password
            var students = new Dictionary<string, Dictionary<string, int>>();
            // name,           contest,points         

            string input = Console.ReadLine();
            while (input != "end of contests")
            {
                string[] splited = input.Split(":");
                string contest = splited[0];
                string password = splited[1];
                contests.Add(contest, password);

                input = Console.ReadLine();
            }
            string line = Console.ReadLine();
            while (line != "end of submissions")
            {
                string[] splited = line.Split("=>");
                string contest = splited[0];
                string password = splited[1];
                string name = splited[2];
                int currentpoints = int.Parse(splited[3]);
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (!students.ContainsKey(name))
                    {
                        students.Add(name, new Dictionary<string, int>());
                    }
                    if (!students[name].ContainsKey(contest))
                    {
                        students[name].Add(contest, currentpoints);
                    }
                    if (students[name][contest] < currentpoints)
                    {
                        students[name][contest] = currentpoints;
                    }

                }


                line = Console.ReadLine();
            }
            var topStudent = students.OrderByDescending(x => x.Value.Sum(x => x.Value)).FirstOrDefault();
            Console.WriteLine($"Best candidate is {topStudent.Key} with total {topStudent.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking:");
            var sortedStudents = students.OrderBy(x => x.Key);
            foreach (var kvp in sortedStudents)
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }

        }
    }
}
