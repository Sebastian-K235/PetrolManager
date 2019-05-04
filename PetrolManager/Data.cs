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
        public static Timer vehicleGenTimer = new Timer(1500);
        public static Random random = new Random();

        #endregion

        #region Methods

        public static void InitializeGeneration()
        {
            vehicleGenTimer.Elapsed += CreateVehicle;
            GeneratePumps();
        }
        public static void StartGeneratingVehicles()
        {
            vehicleGenTimer.Enabled = true;
        }

        public static void StopGeneratingVehicles()
        {
            vehicleGenTimer.Enabled = false;
        }


        public static void CreateVehicle(object sender, ElapsedEventArgs e)
        {
            if (vehicles.Count < 5)
            {                               
                Vehicle vehicle = new Vehicle(GetRandomVehicle());
                vehicles.Add(vehicle);
                vehicle.AwaitService();
                vehicleGenTimer.Interval = random.Next(1000, 3001);
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
                for (int i = 8; i >= 0; i--)
                {
                    if (PumpAvailable(pumps[i]))
                    {
                        pumps[i].FuelVehicle(vehicles[0]);
                        vehicles.RemoveAt(0);
                        break;
                    }
                }
            }
        }

        public static string GetRandomVehicle()
        {
            string v = "";
            switch(random.Next(0,3))
            {
                case 0:
                    v = "car";
                    break;
                case 1:
                    v = "van";
                    break;
                case 2:
                    v = "hgv";
                    break;
            }
            return v;
        }

        public static bool PumpAvailable(Pump p)
        {
            switch (p.PumpID)
            {
                case 7:
                    if (p.IsEmpty()) { return true; } else { return false; }
                case 4:
                    if (p.IsEmpty()) { return true; } else { return false; }
                case 1:
                    if (p.IsEmpty()) { return true; } else { return false; }
                case 8:
                    if (p.IsEmpty() && Data.pumps[6].IsEmpty()) { return true; } else { return false; }
                case 5:
                    if (p.IsEmpty() && Data.pumps[3].IsEmpty()) { return true; } else { return false; }
                case 2:
                    if (p.IsEmpty() && Data.pumps[0].IsEmpty()) { return true; } else { return false; }
                case 9:
                    if (p.IsEmpty() && Data.pumps[7].IsEmpty() && Data.pumps[6].IsEmpty()) { return true; } else { return false; }
                case 6:
                    if (p.IsEmpty() && Data.pumps[4].IsEmpty() && Data.pumps[3].IsEmpty()) { return true; } else { return false; } 
                case 3:
                    if (p.IsEmpty() && Data.pumps[1].IsEmpty() && Data.pumps[0].IsEmpty()) { return true; } else { return false; }
                default:
                    return false;
            }
        }
        #endregion
    }
}
