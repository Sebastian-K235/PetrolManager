﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolManager
{
    class Transaction
    {
        #region Properties
        public Vehicle Vehicle { get; set; }
        public Pump Pump { get; set; }
        public double NumberOfLitres { get; set; }
        public double Cost { get; set; }
        public int TransactionID { get; set; }

        static int TransactionNumber = 0;
        #endregion

        #region Methods

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="v">Vehicle</param>
        /// <param name="p">Pump</param>
        /// <param name="l">Number of litres</param>
        public Transaction(Vehicle v, Pump p, double l)
        {
            Vehicle = v;
            Pump = p;
            NumberOfLitres = l;
            TransactionID = TransactionNumber++;
            switch(v.FuelType)
            {
                case "Unleaded":
                    Cost = l * Counters.UnleadedPrice;
                    break;
                case "LPG":
                    Cost = l * Counters.LPGPrice;
                    break;
                case "Diesel":
                    Cost = l * Counters.DieselPrice;
                    break;
            }
            Counters.TotalProfit += Cost; 
        }

        public override string ToString()
        {
            string String = "";
            String += "TransID: " + TransactionID + " | ";
            String += "Pump: " + Pump.PumpID + " | ";
            String += "Litres: " + NumberOfLitres + " | ";
            String += "Fuel: " + Vehicle.FuelType + " | ";
            String += "Cost: £" + Cost;
            return String;
        }
        #endregion
    }
}
