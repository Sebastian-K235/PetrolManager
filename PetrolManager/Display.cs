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

                for (int i = 0; i <= 4; i++)
                {
                    if (Data.vehicles.ElementAtOrDefault(i) == null)
                    {
                        form.QueuePictures[i].Image = Image.FromFile("picEmpty.png");
                    }
                    else
                    {
                        form.QueuePictures[i].Image = Image.FromFile(Data.vehicles[i].VehicleImage);
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

        public static void DisplayTransactions(FormSimulation form)
        {
            if (Counters.Transactions.Count == 0)
            {
                form.tbxTransactionList.Text = "No transactions recorded";
            }
            else
            {
                string transactionString = "";
                for(int i = 0; i<6; i++)
                {
                    transactionString += Counters.Transactions[i].ToString() + Environment.NewLine;
                    if(i == Counters.Transactions.Count - 1)
                    {
                        break;
                    }
                }
                form.tbxTransactionList.Text = transactionString;
            }
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
