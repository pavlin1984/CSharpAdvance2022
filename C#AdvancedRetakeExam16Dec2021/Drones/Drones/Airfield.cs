using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private readonly List<Drone> drones;
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            drones = new List<Drone>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public IReadOnlyCollection<Drone> Drones => drones.AsReadOnly();

        public int Count { get { return drones.Count; } }

        //        •	string AddDrone(Drone drone) - adds a drone to the drone's collection if there is room for it. Before adding a drone, check:
        //•	If the name or brand are null or empty.
        //•	If the range is NOT between 5-15 kilometers.
        //If the name, brand, or range properties are not valid, return: "Invalid drone.". If the airfield is full (there is no room for more drones), return "Airfield is full.". Otherwise, return: "Successfully added {droneName} to the airfield."

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Brand))
            {
                return "Invalid drone.";
            }
            if (string.IsNullOrEmpty(drone.Name))
            {
                return "Invalid drone.";
            }
            if (drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }
            if (Capacity <= Count)
            {
                return "Airfield is full.";
            }
            drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
        //	bool RemoveDrone(string name) - removes a drone by given name, if such exists return true, otherwise false.
        public bool RemoveDrone(string name)
        {
            var result = drones.FirstOrDefault(d => d.Name == name);
            if (result != null)
            {
                drones.Remove(result);
                return true;
            }
            return false;
        }
        //int RemoveDroneByBrand(string brand) - removes all drones by the given brand, if such exists, return how many drones were removed, otherwise 0.
        public int RemoveDroneByBrand(string brand) => drones.RemoveAll(d => d.Brand == brand);

        //	Drone FlyDrone(string name) method – fly(set its available property to false without removing it from the collection) the drone with the given name if exists.As a result return the drone, or null if does not exist.

        public Drone FlyDrone(string name)
        {
            var flydrone = drones.FirstOrDefault(d => d.Name == name);
            if (flydrone != null)
            {
                flydrone.Available = false;
                return flydrone;

            }
            return null;
        }
        //	List<Drone> FlyDronesByRange(int range) method - fly and returns all drones which have a range equal or bigger to the given.Return a list of all drones which have been flown.The range will always be valid.
        public List<Drone> FlyDronesByRange(int range)
        {
            var allDrones = drones.Where(d => d.Range >= range).ToList();
            foreach (var drone in allDrones)
            {
                FlyDrone(drone.Name);
            }
            return allDrones;
        }

        //•	Report() - returns information about the airfield and drones which are not in flight in the following format
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");
            var alldrones = drones.Where(d => d.Available == true);
            foreach (var drone in alldrones)
            {
                sb.AppendLine(drone.ToString());
            }
            return sb.ToString().TrimEnd();


        }
    }
}
