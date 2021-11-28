using System;
using TransportationHub.Vehicles.interfaces;

namespace TransportationHub.Vehicles.TransportItems
{
    [Serializable]
    public class Car : Vehicle, IPassanger
    {
        public int MaximumPassangers { get; set; }
        public Car(string licensePlate, double gasUsagePerKm, double totalKm, int maximumPassangers) : base(licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Car";
            this.MaximumPassangers = maximumPassangers;
        }

        public Car(string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, int maximumPassangers) : base(makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Car";
            this.MaximumPassangers = maximumPassangers;
        }
    }
}
