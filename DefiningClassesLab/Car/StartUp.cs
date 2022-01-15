using System;

namespace CarManufacturer
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            
            Engine v12 = new Engine(500, 1200);
            Tire[] tires = new Tire[]
            {
                new Tire(2018,3.2),
                new Tire(2018,3.1),
                new Tire(2018,3.4),
                new Tire(2018,3.2),
            };

            Car bmw = new Car("bmw", "x6", 1993, 5003, -50,v12,tires);
            Console.WriteLine($"Horse power: " + bmw.Engine.HorsePower);

            foreach (var tire in tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Pressure}");
            }















            return;
            Car defaultGolf = new Car();
            Console.WriteLine($"DefaultGolf: "+ defaultGolf.WhoAmI());
            Car car = new Car();
            car.Make = "Vw";
            car.Model = "Golf";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;
            car.Drive(0.5);
        }
    }
}
