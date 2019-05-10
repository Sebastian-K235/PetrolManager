using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Drawing;

namespace PetrolManager
{
    class Vehicle
    {
        #region Properties
        public string FuelType { get; set; }
        public double LitresInTank { get; set; }
        public double TankVolume { get; set; }
        public string VehicleType { get; set; }
        public Image VehicleImage { get; set; }
        public bool Serviced { get; set; }

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
        public Vehicle(string vt)
        {                     
            VehicleType = vt;
            SetInitialTank();
            Serviced = false;
            SetFuel();
            CarID = nextCarID++;
            SetImages();                       
        }

        public void SetFuel()
        {
            Random random = new Random();
            int randomFuel;
            switch(VehicleType)
            {
                case "car":
                    randomFuel = random.Next(0, 3);
                    if (randomFuel == 0)
                    {
                        this.FuelType = "Unleaded";
                    }else if (randomFuel == 1)
                    {
                        this.FuelType = "LPG";
                    }else
                    {
                        this.FuelType = "Diesel";
                    }
                    break;
                case "van":
                    randomFuel = random.Next(0, 2);
                    if (randomFuel == 0)
                    {
                        this.FuelType = "Diesel";
                    }
                    else 
                    {
                        this.FuelType = "LPG";
                    }
                  
                    break;
                case "hgv":
                    this.FuelType = "Diesel";
                    break;
            }
        }
        public void SetInitialTank()
        {
            Random random = new Random();
            switch(VehicleType)
            {
                case "car":
                    TankVolume = 160;
                    LitresInTank = random.Next(0, 41);
                    break;
                case "van":
                    TankVolume = 320;
                    LitresInTank = random.Next(0, 81);
                    break;
                case "hgv":
                    TankVolume = 600;
                    LitresInTank = random.Next(0, 151);
                    break;
            }
        }
        public void AwaitService()
        {
            Random random = new Random();
            Timer timer = new Timer(random.Next(4000,18001));
            timer.AutoReset = false;
            timer.Enabled = true;
            timer.Elapsed += LeaveTheStation;
        }
        public void LeaveTheStation(object sender, ElapsedEventArgs e)
        {
            if(Serviced == false)
            {
                Data.vehicles.Remove(this);
                Counters.VehiclesUnserved++;
            }
            
        }

        public void SetImages()
        {
            switch (VehicleType)
            {
                case "car":
                    VehicleImage = Properties.Resources.picCar;                    
                    break;
                case "van":
                    VehicleImage = Properties.Resources.picVan;
                    break;
                case "hgv":
                    VehicleImage = Properties.Resources.picHGV;
                    break;
            }
        }
        #endregion
    }
}
