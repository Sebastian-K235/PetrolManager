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
            FuellingRate = 1.5;
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
            double fuelTime = ((v.TankVolume - v.LitresInTank) / FuellingRate) * 1000;
            timer.Interval = fuelTime + 3000;
            PictureBox.Image = Image.FromFile("picPumpBusy.png");
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
            Counters.TotalLitres += l;
            Counters.Transactions.Add(transaction);
        }
        #endregion
    }
}
