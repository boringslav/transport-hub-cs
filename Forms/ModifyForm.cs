using System;
using System.Windows.Forms;
using TransportationHub.Vehicles;

namespace TransportationHub.Forms
{
    public partial class ModifyForm : Form
    {
        protected string LicensePlate;
        protected string MakeAndModel;

        MainForm mainForm;
        public ModifyForm()
        {
            InitializeComponent();
        }
        public ModifyForm(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void MakeAndModelValue_TextChanged(object sender, System.EventArgs e)
        {
            MakeAndModel = MakeAndModelValue.Text;
        }

        private void LicensePlateValue_TextChanged(object sender, System.EventArgs e)
        {
            LicensePlate = LicensePlateValue.Text;
        }

        private void ModifyVehicle_Click(object sender, EventArgs e)
        {
            int f = 0;
            foreach (Vehicle vehicle in mainForm.rides.Vehicles)
            {
                if (vehicle.LicensePlate.Equals(LicensePlate))
                {
                    vehicle.MakeAndModel = MakeAndModel;
                    Console.WriteLine("Changed make and model " + vehicle.MakeAndModel);
                    ++f;
                }
            }
            if (f > 0)
                MessageBox.Show("Successeful modifying");
            else
                MessageBox.Show("Modifying Error");
        }
    }
}
