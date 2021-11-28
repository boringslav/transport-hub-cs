using System;
using TransportationHub.Vehicles;

namespace TransportationHub.AllRides.Ride
{
    public class Ride
    {
        private int peopleCount;
        private int cargoVolume;
        private int cargoWeight;
        private double ridePrice;
        private double startPrice = 0;
        private double kilometres;
        private DateTime startTime;
        private DateTime endTime;
        private Vehicle vehicle;

        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
        public int PeopleCount { get => peopleCount; set => peopleCount = value; }
        public int CargoVolume { get => cargoVolume; set => cargoVolume = value; }
        public int WeightOdTheCargo { get => this.cargoWeight; set => cargoWeight = value; }
        public double RidePrice { get => ridePrice; set => ridePrice = value; }
        public double StartPrice { get => startPrice; set => startPrice = value; }

        public double Kilometres { get => kilometres; set => kilometres = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }

        public Ride()
        {

        }

        public Ride(FreighterTransport freighter, double kilometres, DateTime startTime, DateTime endTime)
        {
            Vehicle = freighter;
            Kilometres = kilometres;
            RidePrice = Vehicle.PricePerKm * Kilometres + StartPrice;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Ride(PassangerTransport passanger, double kilometres, DateTime startTime, DateTime endTime)
        {
            Vehicle = passanger;
            Kilometres = kilometres;
            RidePrice = Vehicle.PricePerKm * Kilometres + StartPrice;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Ride(PassangerTransport passanger, double startPrice, double kilometres, DateTime startTime, DateTime endTime)
        {
            Vehicle = passanger;
            Kilometres = kilometres;
            StartPrice = startPrice;
            RidePrice = Vehicle.PricePerKm * Kilometres + StartPrice;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Ride(FreighterTransport freighter, double startPrice, double kilometres, DateTime startTime, DateTime endTime)
        {
            Vehicle = freighter;
            Kilometres = kilometres;
            StartPrice = startPrice;
            RidePrice = Vehicle.PricePerKm * Kilometres + StartPrice;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Ride(PassangerTransport passanger, int peopleCount, double startPrice, double kilometres, DateTime startTime, DateTime endTime)
        {
            Vehicle = passanger;
            PeopleCount = peopleCount;
            Kilometres = kilometres;
            StartPrice = startPrice;
            RidePrice = Vehicle.PricePerKm * Kilometres + StartPrice;
            StartTime = startTime;
            EndTime = endTime;
        }
        public Ride(FreighterTransport freighter, int cargoVolume, int cargoWeight, double startPrice, double kilometres, DateTime startTime, DateTime endTime)
        {
            Vehicle = freighter;
            CargoVolume = cargoVolume;
            WeightOdTheCargo = cargoWeight;
            Kilometres = kilometres;
            StartPrice = startPrice;
            RidePrice = Vehicle.PricePerKm * Kilometres + StartPrice;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}

