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


        /// <summary>
        /// A queue to store vehicles ready to be served
        /// </summary>
        public static List<Vehicle> vehicles = new List<Vehicle>();
        public static List<Pump> pumps = new List<Pump>();


        static Timer vehicleGenTimer;

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
            for( int i = 1; i <= 9; i++)
            {
                Pump pump = new Pump(i);
                pumps.Add(pump);
            }
        }
        
        public static void CheckQueue()
        {

        }
    }
}
