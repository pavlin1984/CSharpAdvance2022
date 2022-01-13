using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        private string v;

       

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            Model = model;
           
            Engine = engine;
            Cargo = cargo;
            Tire = tires;
        }

        public string Model { get; set; }
        public int MyProperty { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tire { get; set; }
       
       

    }
}
