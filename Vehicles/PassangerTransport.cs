using System;
using TransportationHub.Vehicles.interfaces;
using TransportationHub.Vehicles.TransportItems;

namespace TransportationHub.Vehicles
{
    [Serializable]
    public class PassangerTransport : Vehicle, IPassanger
    {
        public int MaximumPassangers { get; set; }

        public PassangerTransport(Car car) : base(car.LicensePlate, car.GasUsagePerKm, car.TotalKm)
        {
            this.Type = "Car";
            this.MakeAndModel = car.MakeAndModel;
            MaximumPassangers = car.MaximumPassangers;
        }

        public PassangerTransport(Van van) : base(van.LicensePlate, van.GasUsagePerKm, van.TotalKm)
        {
            this.Type = "Van";
            this.subType = "Passanger";
            this.MakeAndModel = van.MakeAndModel;
            this.MaximumPassangers = van.MaximumPassangers;
        }
    }
}
