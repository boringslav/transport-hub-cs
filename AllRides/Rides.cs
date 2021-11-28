using System.Collections.Generic;
using TransportationHub.Vehicles;

namespace TransportationHub.AllRides
{
    public class Rides
    {
        private List<Ride.Ride> allRides;
        private List<Ride.Ride> completedRides;
        private List<Vehicle> vehicles;
        private List<Vehicle> vehiclesOnRide;
        public List<Ride.Ride> AllRides { get => this.allRides; set => this.allRides = value; }
        public List<Ride.Ride> CompletedRides { get => this.completedRides; set => this.completedRides = value; }
        public List<Vehicle> Vehicles { get => this.vehicles; set => this.vehicles = value; }
        public List<Vehicle> VehiclesOnRide { get => this.vehiclesOnRide; set => this.vehiclesOnRide = value; }

        public Rides()
        {
            this.allRides = new List<Ride.Ride>();
            this.completedRides = new List<Ride.Ride>();
            this.vehicles = new List<Vehicle>();
            this.vehiclesOnRide = new List<Vehicle>();
        }

        public Rides(List<Ride.Ride> rides, List<Ride.Ride> completedRides, List<Vehicle> vehicles, List<Vehicle> vehiclesOnRide)
        {
            this.allRides = rides;
            this.completedRides = completedRides;
            this.vehicles = vehicles;
            this.vehiclesOnRide = vehiclesOnRide;
        }

    }
}
