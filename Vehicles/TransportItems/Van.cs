using System;
using TransportationHub.Vehicles.interfaces;

namespace TransportationHub.Vehicles.TransportItems
{
    [Serializable]
    public class Van : Vehicle, IFreighter, IPassanger
    {
        public double MaximumWeight { get; set; }
        public double MaximumVolume { get; set; }
        public int MaximumPassangers { get; set; }



        public Van(string licensePlate, double gasUsagePerKm, double totalKm, int maximumPassangers) : base(licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Van";
            base.subType = "Passanger";
            this.MaximumPassangers = maximumPassangers;
        }

        public Van(string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, int maximumPassangers) : base(makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Van";
            base.subType = "Passanger";
            this.MaximumPassangers = maximumPassangers;
        }

        public Van(string licensePlate, double gasUsagePerKm, double totalKm, double maximumWeight, double maximumVolume) : base(licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Van";
            base.subType = "Freighter";
            this.MaximumWeight = maximumWeight;
            this.MaximumVolume = maximumVolume;
        }

        public Van(string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm, double maximumWeight, double maximumVolume) : base(makeAndModel, licensePlate, gasUsagePerKm, totalKm)
        {
            this.Type = "Van";
            base.subType = "Freighter";
            this.MaximumWeight = maximumWeight;
            this.MaximumVolume = maximumVolume;
        }

    }
}
