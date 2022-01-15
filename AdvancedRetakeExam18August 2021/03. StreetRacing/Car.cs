using System;
using System.Collections.Generic;
using System.Text;

namespace StreetRacing
{
    public class Car
    {
        public Car(string make, string model, string licensePlate,int horesePower, double weight)
        {
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
            HorsePower = horesePower;
            Weight = weight;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public int HorsePower { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb
                .AppendLine($"Make: {Make}")
                .AppendLine($"Model: { Model}")
                .AppendLine($"License Plate: { LicensePlate}")
                .AppendLine($"Horse Power: {HorsePower}")
                .AppendLine($"Weight: { Weight}");

            return sb.ToString().TrimEnd();
        }

    }
}
