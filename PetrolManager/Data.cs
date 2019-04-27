using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PetrolManager
{
    class Data
    {
        #region Properties

        public static FormSimulation form;
        public static List<Vehicle> vehicles = new List<Vehicle>();
        public static List<Pump> pumps = new List<Pump>();
        public static Timer vehicleGenTimer;

        #endregion

        #region Methods
        public static void AccessControls(FormSimulation frm)
        {
            form = frm;
        }

        public static void GenerateVehicles()
        {
            vehicleGenTimer = new Timer(1500);
            vehicleGenTimer.Elapsed += CreateVehicle;
            vehicleGenTimer.Start();
        }

        public static void StopGeneratingVehicles()
        {
            vehicleGenTimer.Dispose();
        }


        public static void CreateVehicle(object sender, ElapsedEventArgs e)
        {
            if (vehicles.Count < 20)
            {
                Vehicle vehicle = new Vehicle("Petrol", 5, 20);
                vehicles.Add(vehicle);
            }
        }

        public static void GeneratePumps()
        {
            for (int i = 1; i <= 9; i++)
            {
                Pump pump = new Pump(i);
                pump.Picture = form.Controls["pcbPump1"] as System.Windows.Forms.PictureBox;
                pumps.Add(pump);
            }

        }

        public static void CheckQueue()
        {

        }

        #endregion
    }
}
