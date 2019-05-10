using System;
using System.Collections.Generic;

namespace PetrolManager
{
    class Counters
    {
        #region Properties
        /// <summary>
        /// Total amount of petrol in litres sold during the simulation.
        /// </summary>
        public static double TotalUnleaded { get; set; }

        /// <summary>
        /// Total amount of LPG in litres sold during the simulation.
        /// </summary>
        public static double TotalLPG { get; set; }

        /// <summary>
        /// Total amount of Diesel in litres sold during the simulation.
        /// </summary>
        public static double TotalDiesel { get; set; }

        /// <summary>
        /// The amount of money earned during the simulation.
        /// </summary>
        public static double TotalProfit { get; set; }

        /// <summary>
        /// 1% commission from all transactions
        /// </summary>
        public static double Commission
        {
            get { return TotalProfit * 0.01; }
        }

        /// <summary>
        /// Number of vehicles serviced
        /// </summary>
        public static int VehiclesServed { get; set; }

        /// <summary>
        /// Number of vehicles that left before they were fuelled
        /// </summary>
        public static int VehiclesUnserved { get; set; }

        /// <summary>
        /// List of all transactions
        /// </summary>
        public static List<Transaction> Transactions = new List<Transaction>();

        /// <summary>
        /// Price of Petrol.
        /// </summary>
        public static double UnleadedPrice { get; set; }

        /// <summary>
        /// Price of LPG.
        /// </summary>
        public static double LPGPrice { get; set; }

        /// <summary>
        /// Price of Diesel.
        /// </summary>
        public static double DieselPrice { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Method that sets the prices of different fuels.
        /// </summary>
        public static void SetPrices()
        {
            UnleadedPrice = 1.21;
            DieselPrice = 1.30;
            LPGPrice = 0.6;
        }

        /// <summary>
        /// Method to reset the counters data.
        /// </summary>
        public static void ResetCounters()
        {
            TotalDiesel = 0;
            TotalLPG = 0;
            TotalUnleaded = 0;
            TotalProfit = 0;
            VehiclesServed = 0;
            VehiclesUnserved = 0;
            Transactions.Clear();
        }
        #endregion
    }
}
