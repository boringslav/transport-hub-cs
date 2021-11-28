using System;
using System.Windows.Forms;
using TransportationHub.Forms;
using TransportationHub.Vehicles;
using TransportationHub.Vehicles.TransportItems;

namespace TransportationHub
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            Vehicle vehicle = new FreighterTransport(new Truck("", 1, 1, 1, 1));
            Vehicle vehicle1 = new PassangerTransport(new Van("", 1, 1, 1, 1));

        }
    }
}
