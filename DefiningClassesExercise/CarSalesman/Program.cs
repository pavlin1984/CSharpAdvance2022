using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            // "{model} {power} {displacement} {efficiency}"
            HashSet<Engine> engines = new HashSet<Engine>();
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] engineElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = engineElements[0];
                int power = int.Parse(engineElements[1]);
                Engine engine = null;

                if (engineElements.Length==4)
                {
                    
                    int displacement = int.Parse(engineElements[2]);
                    string efficienty = engineElements[3];
                    engine = new Engine(model, power, displacement, efficienty);
                }
                else if (engineElements.Length==3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(engineElements[2], out displacement);
                   
                    if (isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineElements[2]);
                    }
                }
                else if (engineElements.Length==2)
                {
                    engine = new Engine(model, power);
                }
                if (engine!=null)
                {
                    engines.Add(engine);
                }
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carsElements = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                //"{model} {engine} {weight} {color}".
               
                Car car = null;

                string model = carsElements[0];
                Engine engine = engines.First(e => e.Model == carsElements[1]);
                if (carsElements.Length==4)
                {
                    int weight = int.Parse(carsElements[2]);
                    string color = carsElements[3];
                     car = new Car(model, engine, weight, color);
                }
                else if (carsElements.Length==3)
                {
                    int weight;
                    bool isWeght = int.TryParse(carsElements[2], out weight);
                    if (isWeght)
                    {
                         car = new Car(model, engine, weight);
                    }
                    else
                    {
                         car = new Car(model, engine, carsElements[2]);
                    }
                }
                else if (carsElements.Length==2)
                {
                     car = new Car(model, engine);
                }
                if (car!=null)
                {
                    cars.Add(car);
                }

            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
