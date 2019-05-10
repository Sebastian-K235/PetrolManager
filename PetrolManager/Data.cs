using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using PetrolManager;
using System.Drawing;

namespace PetrolManager
{
    class Data
    {
        #region Properties
        /// <summary>
        /// List representing the queue of vehicles waiting to be serviced.
        /// </summary>
        public static List<Vehicle> vehicles = new List<Vehicle>();

        /// <summary>
        /// List containing the pumps in the forecourt.
        /// </summary>
        public static List<Pump> pumps = new List<Pump>();

        /// <summary>
        /// Timer triggering the creation of a new vehicle.
        /// </summary>
        public static Timer vehicleGenTimer = new Timer(100);

        public static Random random = new Random();

        #endregion

        #region Methods
        /// <summary>
        /// Method executed on the startup
        /// </summary>
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

        /// <summary>
        /// A method to randomly create a vehicle.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void CreateVehicle(object sender, ElapsedEventArgs e)
        {
            if (vehicles.Count < 10)
            {                               
                Vehicle vehicle = new Vehicle(GetRandomVehicle());
                vehicles.Add(vehicle);
                vehicle.AwaitService();
                vehicleGenTimer.Interval = random.Next(800, 2601);
            }
        }

        /// <summary>
        /// Method generating a set of 9 pumps and adding them to "pumps" list.
        /// </summary>
        public static void GeneratePumps()
        {
            for (int i = 0; i <= 8; i++)
            {
                Pump pump = new Pump(i + 1, FormSimulation.PumpPictures[i]);
                pumps.Add(pump);
            }

        }

        /// <summary>
        /// Takes the fisrt vehicle from the queue and services it at first available pump.
        /// </summary>
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

        /// <summary>
        /// Method returning a random vehicle type (car, van, hgv).
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Method checking if the referenced pump is not blocked by the pump before in the lane.
        /// </summary>
        /// <param name="p">Pump to be checked.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Method reseting the runtime of the app
        /// </summary>
        public static void ResetData()
        {
            StopGeneratingVehicles();
            foreach(Vehicle v in vehicles)
            {
                v.Serviced = true;
            }
            vehicles.Clear();
            for(int i = 0; i <9; i++)
            {
                pumps[i].Enabled = false;
                pumps[i].CurrentVehicle = null;
                pumps[i].PictureBox.Image = Properties.Resources.picPumpFree;
            }
            pumps.Clear();
            GeneratePumps();
        }
        #endregion
    }
}
