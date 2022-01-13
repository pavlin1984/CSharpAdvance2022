using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
   public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                // "{model} {fuelAmount} {fuelConsumptionFor1km}"
                string model = elements[0];
                double fuelAmount = double.Parse(elements[1]);
                double fuelConsumptionFor1km = double.Parse(elements[2]);
                Car car = new Car(model,fuelAmount,fuelConsumptionFor1km);
                cars.Add(car);
            }
            string comand = Console.ReadLine();
            while (comand!="End")
            {
                //Drive { carModel} { amountOfKm}
                string[] tokens = comand.Split();
               
                string carModel = tokens[1];
                int amountOfKm = int.Parse(tokens[2]);
                Car car = GetCar(cars, carModel);

                car.Drive(amountOfKm);
                comand = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        private static Car GetCar(List<Car> cars, string carModel) => cars.FirstOrDefault(c => c.Model == carModel);
       
    }
}
