using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PetrolManager
{
    class Pump
    {
        #region Properties
        /// <summary>
        /// Stores currently served vehicle by a pump.
        /// </summary>
        public Vehicle CurrentVehicle { get; set; }
        public string FuelType { get; set; }

        public System.Windows.Forms.PictureBox Picture { get; set; }

        public int PumpID { get; set; }
        #endregion

        #region Methods
        public Pump(int ID)
        {
            CurrentVehicle = null;
            FuelType = "Unleaded";
            PumpID = ID;
        }

        /// <summary>
        /// Returns true if a pump is free to be used.
        /// </summary>
        /// <returns></returns>
        public bool IsAvailable()
        {
            return CurrentVehicle == null;

        }

        /// <summary>
        /// Function to fuel a vehicle which waits to be serviced
        /// </summary>
        /// <param name="v">Vehicle to be serviced</param>
        public void FuelVehicle(Vehicle v)
        {
            CurrentVehicle = v;
            Timer timer = new Timer();
            double fuelTime = ((v.TankVolume - v.LitresInTank) / 1.5) * 1000;
            timer.Interval = fuelTime + 3000;


        }
        #endregion
    }
}
