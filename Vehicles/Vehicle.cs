using System;

namespace TransportationHub.Vehicles
{
    [Serializable]
    public abstract class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(string licensePlate, double gasUsagePerKm, double totalKm)
        {
            LicensePlate = licensePlate;
            GasUsagePerKm = gasUsagePerKm;
            PricePerKm = 100 / gasUsagePerKm;
            TotalKm = totalKm;
            ConsumedFuel = TotalKm * gasUsagePerKm;
        }

        public Vehicle(string makeAndModel, string licensePlate, double gasUsagePerKm, double totalKm)
        {
            MakeAndModel = makeAndModel;
            LicensePlate = licensePlate;
            GasUsagePerKm = gasUsagePerKm;
            PricePerKm = 100 / gasUsagePerKm;
            TotalKm = totalKm;
            ConsumedFuel = TotalKm * gasUsagePerKm;
        }

        public string MakeAndModel { get; set; }
        public string LicensePlate { get; set; }
        public double GasUsagePerKm { get; set; }
        public double PricePerKm { get; set; }
        public double ConsumedFuel { get; set; }
        public double TotalKm { get; set; }
        public string Type { get; set; }
        public string subType { get; set; }

    }
}
