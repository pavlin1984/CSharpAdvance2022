using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carinfo = Console.ReadLine().Split();
                //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
                var engine = new Engine(int.Parse(carinfo[1]),int.Parse(carinfo[2]));
                var cargo = new Cargo(int.Parse(carinfo[3]),carinfo[4]);
                var tire = new[]
                {
                    new Tire(double.Parse(carinfo[5]),int.Parse(carinfo[6])),
                    new Tire(double.Parse(carinfo[7]),int.Parse(carinfo[8])),
                    new Tire(double.Parse(carinfo[9]),int.Parse(carinfo[10])),
                    new Tire(double.Parse(carinfo[11]),int.Parse(carinfo[12]))
                };
                cars.Add(new Car(carinfo[0], engine, cargo, tire));
            }
            string type = Console.ReadLine();
            //            •	"fragile" - print all cars whose cargo is "fragile" and have a pressure of a single tire < 1
            //•	"flammable" - print all cars, whose cargo is "flammable" and have engine power > 250

            if (type=="fragile")
            {
                foreach (Car car in cars.Where(c=>c.Cargo.Type=="fragile" && c.Tire.Any(t=>t.Presure<1))) 
                {
                    Console.WriteLine(car.Model);
                }
            }
            if (type=="flammable")
            {
                foreach (Car car in cars.Where(c=>c.Cargo.Type=="flammable" && c.Engine.Power>250))
                {
                    Console.WriteLine(car.Model);
                }
            }

        }
    }
}
