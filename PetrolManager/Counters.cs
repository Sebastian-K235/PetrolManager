using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolManager
{
    class Counters
    {
        #region Properties

        /// <summary>
        /// Total number of litres dispensed during the app's lifetime
        /// </summary>
        public static double TotalLitres { get; set; }

        /// <summary>
        /// The amount of money total litres equate to
        /// </summary>
        public static double TotalProfit { get; set; }

        /// <summary>
        /// 1% commission from all transactions
        /// </summary>
        public static double Commission { get; set; }

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
        #endregion

        #region Methods

        #endregion
    }
}
