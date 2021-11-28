using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using TransportationHub.AllRides;
using TransportationHub.AllRides.Ride;
using TransportationHub.Vehicles;

namespace TransportationHub.Forms
{
    public partial class MainForm : Form
    {
        public Rides rides = new Rides();
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddNewVehicleButton_Click(object sender, EventArgs e)
        {
            NewVehicleForm form = new NewVehicleForm(this);
            form.Show();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            rides.Vehicles = rides.Vehicles.OrderBy(t => t.LicensePlate).ToList();

            rides.AllRides = rides.AllRides.OrderBy(t => t.StartTime).ToList();
            rides.AllRides = rides.AllRides.OrderBy(t => t.Kilometres).ToList();
        }

        private void PresentVehicleDataButtonToFile_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Vehicles.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, rides.Vehicles);
                MessageBox.Show("Serialize completed!");
            }

        }

        private void PresidentVehicalDataButtonFromFile_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Vehicles.dat", FileMode.OpenOrCreate))
            {
                rides.Vehicles = (List<Vehicle>)formatter.Deserialize(fs);
                MessageBox.Show("Deserialize completed!");
            }
        }

        private void ModifyVehicleButton_Click(object sender, EventArgs e)
        {
            ModifyForm form = new ModifyForm(this);
            form.Show();
        }

        private void ReserveRideButton_Click(object sender, EventArgs e)
        {
            RideForm form = new RideForm(this);
            form.Show();
        }

        private void InfoAboutRides_Click(object sender, EventArgs e)
        {
            
            foreach (Ride ride in this.rides.CompletedRides)
            {
                OutTextBox.AppendText("\n---------------------------------------------\n\r\n");
                OutTextBox.AppendText($" Vehicle (LicensePlate) {ride.Vehicle?.LicensePlate}\r\n");
                OutTextBox.AppendText($" Kilometres {ride?.Kilometres}\r\n");
                OutTextBox.AppendText($" Start price {ride?.StartPrice}\r\n");
                OutTextBox.AppendText($" Ride price {ride?.RidePrice}\r\n");
                OutTextBox.AppendText($" Start time {ride?.StartTime}\r\n");
                OutTextBox.AppendText($" End time {ride?.EndTime}\r\n");
                OutTextBox.AppendText("\n---------------------------------------------\n\r\n");
            }
        }

        private void AllRidesToFileButton_Click(object sender, EventArgs e)
        {

            try
            {

                using (StreamWriter sw = new StreamWriter("InfoAnoutRides.txt", false, System.Text.Encoding.Default))
                {
                    foreach (Ride ride in this.rides.CompletedRides)
                    {
                        sw.Write("\n---------------------------------------------\n\r\n");
                        sw.Write($" Vehicle(LicensePlate) {ride.Vehicle.LicensePlate}\r\n");
                        sw.Write($" Kilometres {ride.Kilometres}\r\n");
                        sw.Write($" Start price {ride.StartPrice}\r\n");
                        sw.Write($" Price of the ride {ride.RidePrice}\r\n");
                        sw.Write($" Start time {ride.StartTime}\r\n");
                        sw.Write($" End time {ride.EndTime}\r\n");
                        sw.Write("\n---------------------------------------------\n\r\n");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error writing the file!");
            }

        }

        private void InfoAboutRidesFromFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("InfoAnoutRides.txt", System.Text.Encoding.Default))
                {

                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        OutTextBox.AppendText(line + "\r\n");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error reading the file!");
            }

        }
    }
}
