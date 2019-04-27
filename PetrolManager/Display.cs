using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PetrolManager
{
    class Display
    {
        #region Properties
        #endregion

        #region Methods

        public static void DisplayUI(FormSimulation form)
        {
            DisplayCounters(form);
            DisplayQueue(form);
            DisplayTransactions(form);
        }
        public static void DisplayQueue(FormSimulation form)
        {
            if(Data.vehicles.Count > 0)
            {

                for (int i = 0; i <= 4; i++)
                {
                    if (Data.vehicles[i] != null)
                    {
                        form.QueuePictures[i].Image = Image.FromFile("picVan.png");
                    }
                    else
                    {
                        form.QueuePictures[i].Image = Image.FromFile("picEmpty.png");
                    }
                    if(i == Data.vehicles.Count -1)
                    {
                        break;
                    }
                }
                if (Data.vehicles.Count > 5)
                {
                    form.lblQueue.Text = "+" + (Data.vehicles.Count - 5);
                }
                else
                {
                    form.lblQueue.Text = "";
                }

            }

        }

        public static void DisplayTransactions(FormSimulation form)
        {

        }
        public static void DisplayCounters(FormSimulation form)
        {           
            form.lblTotalLitres.Text = "Total Litres: " + Counters.TotalLitres;
            form.lblTotalProfit.Text = "Total Profit: " + Counters.TotalProfit;           
            form.lblCommission.Text = "Commission: " + Counters.Commission;
            form.lblVehiclesServiced.Text = "Vehicles Serviced: " + Counters.VehiclesServed;
            form.lblVehiclesUnserviced.Text = "Vehicles UnServiced: " + Counters.VehiclesUnserved;
        }
        #endregion
    }
}
