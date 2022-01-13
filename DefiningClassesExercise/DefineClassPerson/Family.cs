using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
   public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);

        }
        public Person[] GetPeopleOver30()
        {
            var people = People.Where(x => x.Age > 30).OrderBy(x=>x.Name).ToArray();
            return people;

            
        }

    }
}
