using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
   public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
           
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;

        }

        public Car(string make, string model, int year)
            :this()
        {
           this.Make = make;
           this.Model = model;
           this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this(make,model,year)
        {
           
           
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,Engine engine,Tire[]tires)
           : this(make, model, year,fuelQuantity,fuelConsumption)
        {


            Engine = engine;

            Tires = tires;
        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
       
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        //        •	Drive(double distance) : void – This method checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero.If it is removed from the fuel quantity the result of the multiplication between the distance and the fuel consumption.Otherwise, write on the console the following message:  
        //"Not enough fuel to perform this trip!"

        public void Drive(double distance)
        {
            double fuelToConsume = (distance * FuelConsumption);
            if (FuelQuantity-fuelToConsume>=0)
            {
                FuelQuantity -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
//        •	WhoAmI() : string – returns the following message: 
//"Make: {this.Make}
// Model: {this.Model
//    }
//    Year: {this.Year}
//    Fuel: {this.FuelQuantity:F2}"

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: { Model}\nYear: {Year}\nFuel: {FuelQuantity}";

        }
    }
}
