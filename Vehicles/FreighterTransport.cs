using System;
using TransportationHub.Vehicles.interfaces;
using TransportationHub.Vehicles.TransportItems;

namespace TransportationHub.Vehicles
{
    [Serializable]
    public class FreighterTransport : Vehicle, IFreighter
    {

        public FreighterTransport(Truck truck) : base(truck.LicensePlate, truck.GasUsagePerKm, truck.TotalKm)
        {
            this.Type = "Truck";
            MaximumVolume = truck.MaximumVolume;
            MaximumWeight = truck.MaximumWeight;
            base.MakeAndModel = truck.MakeAndModel;
        }

        public FreighterTransport(Van van) : base(van.LicensePlate, van.GasUsagePerKm, van.TotalKm)
        {
            this.Type = "Van";
            this.subType = "Freighter";
            MaximumVolume = van.MaximumVolume;
            MaximumWeight = van.MaximumWeight;
            base.MakeAndModel = van.MakeAndModel;
        }

        public double MaximumWeight { get; set; }
        public double MaximumVolume { get; set; }
    }
}
