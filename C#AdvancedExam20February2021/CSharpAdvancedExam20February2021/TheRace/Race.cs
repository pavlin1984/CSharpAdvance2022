using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private readonly List<Racer> data;
        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }
        
       
       //	Method Add(Racer Racer) – adds an entity to the data if there is room for him/her.
       public void Add(Racer Racer)
        {
            if (Count<Capacity)
            {
                data.Add(Racer);
            }
        }
        //	Method Remove(string name) – removes an Racer by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            var currentRacer = data.FirstOrDefault(x => x.Name == name);
            if (currentRacer!=null)
            {
                data.Remove(currentRacer);
                return true;
            }
            return false;
        }
        //	Method GetOldestRacer() – returns the oldest Racer.
        public Racer GetOldestRacer() => data.OrderByDescending(x => x.Age).FirstOrDefault();

        //	Method GetRacer(string name) – returns the Racer with the given name.
        public Racer GetRacer(string name) => data.FirstOrDefault(x => x.Name == name);

        //Method GetFastestRacer() – returns the Racer whose car has the highest speed.
        public Racer GetFastestRacer() => data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();

        //        •	Report() – returns a string in the following format:
        //o	"Racers participating at {RaceName}:
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}");
            foreach (var racer in data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().TrimEnd();
        }



    }
}
