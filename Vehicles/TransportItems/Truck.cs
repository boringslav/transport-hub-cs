using System;
using TransportationHub.Vehicles.interfaces;

namespace TransportationHub.Vehicles.TransportItems
{
    [Serializable]
    public class Truck : Vehicle, IFreighter
    {
        public double MaximumWeight { get; set; }
        public double MaximumVolume { get; set; }
        public Truck(string licensePlate, double gasUsagePerKm, double totalKm, double maximumWeight, double maximumVolume) : base(licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Track";
            this.MaximumWeight = maximumWeight;
            this.MaximumVolume = maximumVolume;
        }

        public Truck(string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, double maximumWeight, double maximumVolume) : base(makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Track";
            this.MaximumWeight = maximumWeight;
            this.MaximumVolume = maximumVolume;
        }

    }
}
