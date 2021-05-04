using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    public class Truck : Vehicle {

        /// <summary>
        /// Maximum Weight 
        /// </summary>
        public double MaxWg { get; set; }

        /// <summary>
        /// Maximum Volume
        /// </summary>
        public double MaxVol { get; set; }

        public Truck(string licPlt, double gasKm, double priceKm, double maxWg, double maxVol, string mod = null) :
           base(licPlt, gasKm, priceKm, mod) {
            this.MaxWg = maxWg;
            this.MaxVol = maxVol;
        }

        public Truck(string licPlt, double gasKm, double priceKm, double maxWg, int totalKm,
            double maxVol, string mod = null) : base(licPlt, gasKm, priceKm, totalKm, mod)
        {
            this.MaxWg = maxWg;
            this.MaxVol = maxVol;
        }
    }
}
