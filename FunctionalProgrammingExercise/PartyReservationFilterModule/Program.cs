using System;
using System.Collections.Generic;
using System.Linq;
namespace PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            var dictionary = new Dictionary<string, Predicate<string>>();

            string comand = Console.ReadLine();

            while (comand!="Print")
            {
                //Add filter; Starts with; P
                //Remove filter; Starts with; M
                string[] comandArgs = comand.Split(';');
                string actrion = comandArgs[0];
                string predicateAction = comandArgs[1];
                string value = comandArgs[2];
                string key = predicateAction + "_" + value;
                if (actrion=="Add filter")
                {
                    
                    Predicate<string> predicate = GetPredicate(predicateAction, value);
                    dictionary.Add(key, predicate);
                }
                else
                {
                    dictionary.Remove(key);
                }
               

               comand = Console.ReadLine();
            }
            foreach (var (key,predicate) in dictionary)
            {
                names.RemoveAll(predicate);
            }
            Console.WriteLine(string.Join(" ",names));

        }


        private static Predicate<string> GetPredicate(string comandInfo,string param)
        {
            if (comandInfo == "Starts with")
            {
                return x => x.StartsWith(param);
            }
            if (comandInfo=="Ends with")
            {
                return x => x.EndsWith(param);
            }
            if (comandInfo=="Contains")
            {
                return x => x.Contains(param);
            }
            int lenght = int.Parse(param);
            return x => x.Length == lenght;


        }
    }
}
