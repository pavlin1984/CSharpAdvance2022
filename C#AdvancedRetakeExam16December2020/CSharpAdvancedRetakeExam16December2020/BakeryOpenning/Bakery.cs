using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
   public  class Bakery
    {
        private readonly List<Employee> data;
        public Bakery(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Employee>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }
        public IReadOnlyCollection<Employee> Data => data.AsReadOnly();

        //Method Add(Employee employee) – adds an entity to the data if there is room for him/her.
        public void Add(Employee employee)
        {
            if (data.Count<Capacity)
            {
                data.Add(employee);
            }
        }
        //	Method Remove(string name) – removes an employee by given name, if such exists, and returns bool.
        public bool Remove(string name)
        {
            var curEmployee = data.FirstOrDefault(x => x.Name == name);
            if (curEmployee!=null)
            {
                data.Remove(curEmployee);
                return true;
            }
            return false;
        }
        //	Method GetOldestEmployee() – returns the oldest employee.

        public Employee GetOldestEmployee() => data.OrderByDescending(x => x.Age).FirstOrDefault();

        //	Method GetEmployee(string name) – returns the employee with the given name.

        public Employee GetEmployee(string name) => data.FirstOrDefault(x => x.Name == name);

        //        •	Report() – returns a string in the following format:
        //o	"Employees working at Bakery {bakeryName}:

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
