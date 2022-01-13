using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement)
            :this(model,power)
        {
           
            Displacement = displacement;
        }
        public Engine(string model,int power,string efficiencty)
            :this(model,power)
        {
            Efficienty = efficiencty;
        }

        public Engine(string model, int power, int displacement, string efficienty)
            :this(model,power)
        {
            Displacement = displacement;
            Efficienty = efficienty;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int? Displacement { get; set; }
        public string Efficienty { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string displacementStr = Displacement.HasValue ? Displacement.ToString() : "n/a";
            string effString = string.IsNullOrEmpty(Efficienty) ?  "n/a": Efficienty;
            sb
               .AppendLine($"{Model}:")
               .AppendLine($"    Power: {Power}")
               .AppendLine($"    Displacement: {displacementStr}")
               .AppendLine($"    Efficiency: {effString}");
            return sb.ToString().TrimEnd();
        }
    }
}


