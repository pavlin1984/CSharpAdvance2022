﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
   public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }
        public Car(string model,Engine engine,double weight)
            :this(model,engine)
        {
            Weight = weight;   
        }
        public Car(string model, Engine engine, string color)
           : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            :this(model,engine)
        {
            
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public double? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string weightstr = Weight.HasValue ? Weight.ToString() : "n/a";
            string colorStr = String.IsNullOrEmpty(Color) ? "n/a": Color;
            sb
                .AppendLine($"{Model}:")
                .AppendLine($"  {Engine}")
                .AppendLine($"  Weight: {weightstr}")
                .AppendLine($"  Color: {colorStr}");

   

            return sb.ToString().TrimEnd();
        }
    }
}
