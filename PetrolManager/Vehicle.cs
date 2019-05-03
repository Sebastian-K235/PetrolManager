using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolManager
{
    class Vehicle
    {
        #region Properties
        public string FuelType { get; set; }
        public double LitresInTank { get; set; }
        public double TankVolume { get; set; }
        public string VehicleType { get; set; }
        public string VehicleImage { get; set; }

        public static int nextCarID = 0;
        public int CarID { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ftp">Fuel Type</param>
        /// <param name="lit">Litres in tank</param>
        /// <param name="tv">Tank volume</param>
        public Vehicle(string ftp, double lit, double tv)
        {
            LitresInTank = lit;
            TankVolume = tv;
            FuelType = ftp;
            CarID = nextCarID++;
            VehicleImage = "picVan.png";
        }
        #endregion
    }
}
