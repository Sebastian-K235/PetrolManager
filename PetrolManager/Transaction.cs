using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolManager
{
    class Transaction
    {
        public Vehicle Vehicle { get; set; }
        public Pump Pump { get; set; }
        public double NumberOfLitres { get; set; }

        public static void GenerateTransaction()
        {

        }
    }
}
