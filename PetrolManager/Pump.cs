using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;
using System.Drawing;


namespace PetrolManager
{
    class Pump
    {
        #region Properties
     
        public Vehicle CurrentVehicle { get; set; }

        public string FuelType { get; set; }

        public double FuellingRate { get; set; }

        public System.Windows.Forms.PictureBox PictureBox = new System.Windows.Forms.PictureBox();

        public int PumpID { get; set; }
        #endregion

        #region Methods
        public Pump(int ID, System.Windows.Forms.PictureBox pb)
        {
            CurrentVehicle = null;
            FuelType = "Unleaded";
            PictureBox = pb;
            FuellingRate = 15;
            PumpID = ID;
        }

        /// <summary>
        /// Returns true if a pump is free to be used.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
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
            v.Serviced = true;
            Timer timer = new Timer();
            double fuelTime = ((v.TankVolume - v.LitresInTank) / FuellingRate) * 1000;
            timer.Interval = fuelTime + 3000;
            switch (v.VehicleType)
            {
                case "car":
                    PictureBox.Image = Image.FromFile("picPumpCar.png");
                    break;
                case "van":
                    PictureBox.Image = Image.FromFile("picPumpVan.png");
                    break;
                case "hgv":
                    PictureBox.Image = Image.FromFile("picPumpHGV.png");
                    break;
            }           
            timer.AutoReset = false;
            timer.Start();
            timer.Elapsed += (sender, e) => FinishTransaction(sender, e , v, this, v.TankVolume - v.LitresInTank);
        }

        public static void FinishTransaction(object sender, ElapsedEventArgs e, Vehicle v, Pump p, double l)
        {
            Transaction transaction = new Transaction(v, p, l);
            p.PictureBox.Image = Image.FromFile("picPumpFree.png");
            p.CurrentVehicle = null;
            Counters.VehiclesServed++;
            switch (v.FuelType)
            {
                case "Unleaded":
                    Counters.TotalUnleaded += l;
                    break;
                case "LPG":
                    Counters.TotalLPG += l;
                    break;
                case "Diesel":
                    Counters.TotalDiesel += l;
                    break;
            }
            
            Counters.Transactions.Add(transaction);
        }
        #endregion
    }
}
