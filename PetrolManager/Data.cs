using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using PetrolManager;

namespace PetrolManager
{
    class Data
    {
        #region Properties

        public static List<Vehicle> vehicles = new List<Vehicle>();
        public static List<Pump> pumps = new List<Pump>();
        public static Timer vehicleGenTimer;

        #endregion

        #region Methods

        public static void GenerateVehicles()
        {
            vehicleGenTimer = new Timer(500);
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
            for (int i = 0; i <= 8; i++)
            {
                Pump pump = new Pump(i + 1, FormSimulation.PumpPictures[i]);
                pumps.Add(pump);
            }

        }

        public static void CheckQueue()
        {
            if (vehicles.Count > 0)
            {
                foreach (Pump p in pumps)
                {
                    if (p.IsAvailable() == true)
                    {
                        p.FuelVehicle(vehicles[0]);
                        vehicles.RemoveAt(0);
                        break;
                    }
                }
            }
        }

        #endregion
    }
}
