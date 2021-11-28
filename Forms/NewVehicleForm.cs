using System;
using System.Windows.Forms;
using TransportationHub.Vehicles;
using TransportationHub.Vehicles.TransportItems;

namespace TransportationHub.Forms
{
    public partial class NewVehicleForm : Form
    {
        MainForm mainForm;

        protected string type;
        protected string MakeAndModel;
        protected string LicensePlate;
        protected double GasUsagePerKm;
        protected double PricePerKm;
        protected double ConsumedFuel;
        protected double TotalKm;
        protected int MaximumPassanger;
        protected double MaximumWeight;
        protected double MaximumVolume;


        public NewVehicleForm()
        {
            InitializeComponent();
        }
        public NewVehicleForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
            CarRadioButton.Checked = false;
            TruckRadioButton.Checked = false;
            VanRadioButton.Checked = false;
        }

        private void TypeRadioButtons_CheckedChanged(object sender, System.EventArgs e)
        {
            if (CarRadioButton.Checked)
                this.type = CarRadioButton.Text;
            else if (TruckRadioButton.Checked)
                this.type = TruckRadioButton.Text;
            else if (VanRadioButton.Checked)
                this.type = VanRadioButton.Text;
        }

        private void MakeAndModelValue_TextChanged(object sender, System.EventArgs e)
        {
            this.MakeAndModel = MakeAndModelValue.Text;
        }

        private void LicensePlateValue_TextChanged(object sender, System.EventArgs e)
        {
            this.LicensePlate = LicensePlateValue.Text;
        }

        private void GasPerKmValue_ValueChanged(object sender, System.EventArgs e)
        {
            this.GasUsagePerKm = Convert.ToDouble(GasPerKmValue.Value);
        }

        private void MaxPassangersValue_ValueChanged(object sender, EventArgs e)
        {
            this.MaximumPassanger = Convert.ToInt32(MaxPassangersValue.Value);
        }

        private void MaxWeightValue_ValueChanged(object sender, EventArgs e)
        {
            this.MaximumWeight = Convert.ToDouble(MaxWeightValue.Value);
        }

        private void MaxVolumeValue_ValueChanged(object sender, EventArgs e)
        {
            this.MaximumVolume = Convert.ToDouble(MaxVolumeValue.Value);
        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {
            switch (this.type)
            {
                case "Car":
                    if (MaxVolumeValue.Value == 0 && MaxWeightValue.Value == 0)
                    {
                        if (MakeAndModel != "")
                            mainForm.rides.Vehicles.Add(new PassangerTransport(new Car(this.MakeAndModel, this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumPassanger)));
                        else
                            mainForm.rides.Vehicles.Add(new PassangerTransport(new Car(this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumPassanger)));
                        MessageBox.Show("Successful adding");
                    }
                    else
                        MessageBox.Show("Invalid value");
                    break;
                case "Truck":
                    if (MaxPassangersValue.Value == 0)
                    {
                        if (MakeAndModel != null)
                            mainForm.rides.Vehicles.Add(new FreighterTransport(new Truck(this.MakeAndModel, this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumWeight, this.MaximumVolume)));
                        else
                            mainForm.rides.Vehicles.Add(new FreighterTransport(new Truck(this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumWeight, this.MaximumVolume)));
                        MessageBox.Show("Successful adding");
                    }
                    else
                        MessageBox.Show("Invalid value");
                    break;
                case "Van":
                    if (MaxPassangersValue.Value == 0 && MaxVolumeValue.Value != 0 && MaxWeightValue.Value != 0)
                    {
                        if (MakeAndModel != "")
                            mainForm.rides.Vehicles.Add(new FreighterTransport(new Van(this.MakeAndModel, this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumWeight, this.MaximumVolume)));
                        else
                            mainForm.rides.Vehicles.Add(new FreighterTransport(new Van(this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumWeight, this.MaximumVolume)));
                        MessageBox.Show("Successful adding");
                    }
                    else if (MaxPassangersValue.Value != 0 && MaxVolumeValue.Value == 0 && MaxWeightValue.Value == 0)
                    {
                        if (MakeAndModel != "")
                            mainForm.rides.Vehicles.Add(new PassangerTransport(new Van(this.MakeAndModel, this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumPassanger)));
                        else
                            mainForm.rides.Vehicles.Add(new PassangerTransport(new Van(this.LicensePlate, this.GasUsagePerKm, this.TotalKm, this.MaximumPassanger)));
                        MessageBox.Show("Invalid value");
                    }
                    else if (MaxPassangersValue.Value != 0 && MaxVolumeValue.Value != 0 && MaxWeightValue.Value != 0)
                    {
                        MessageBox.Show("Invalid value");
                    }
                    break;

                default:
                    break;
            }

            CarRadioButton.Checked = false;
            TruckRadioButton.Checked = false;
            VanRadioButton.Checked = false;
            MakeAndModelValue.ResetText();
            LicensePlateValue.ResetText();
            GasPerKmValue.Value = 0;
            MaxPassangersValue.Value = 0;
            MaxWeightValue.Value = 0;
            MaxVolumeValue.Value = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}