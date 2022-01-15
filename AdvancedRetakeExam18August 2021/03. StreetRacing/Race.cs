using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
   public class Race
    {
        private readonly List<Car> Participants;
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get { return Participants.Count; } }

       //	Method Add(Car car) - adds the entity if there isn't a Car with the same License plate and if there is enough space in terms of race capacity and if the car meets the maximum horse power requirment of the race.

        public void Add(Car car)
        {

            if (!Participants.Any(x=>x.LicensePlate==car.LicensePlate) && Count<Capacity&& car.HorsePower<=MaxHorsePower)
            {
                Participants.Add(car);
            }
        }
        //	Method Remove(string licensePlate) - removes a Car from the race with the given License plate, if such exists and returns bool if the deletion is successful.
        public bool Remove(string licensePlate)
        {
            var carToRemove = Participants.FirstOrDefault(c => c.LicensePlate == licensePlate);
            if (carToRemove!=null)
            {
                Participants.Remove(carToRemove);
                return true;
            }
            return false;

        }
        //	Method FindParticipant(string licensePlate) - returns a Car with the given License plate.If it doesn't exist, return null.
        public Car FindParticipant(string licensePlate) => Participants.FirstOrDefault(c => c.LicensePlate == licensePlate);

        //Method GetMostPowerfulCar() – returns the Car with most HorsePower.If there are no Cars in the Race, method should return null. 
        public Car GetMostPowerfulCar() => Participants.OrderByDescending(c => c.HorsePower).FirstOrDefault();

        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var item in Participants)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();

        }

    }
}
