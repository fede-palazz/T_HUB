using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    class Truck : Vehicle {

        /// <summary>
        /// Maximum Weight 
        /// </summary>
        public float MaxWg { get; set; }

        /// <summary>
        /// Maximum Volume
        /// </summary>
        public float MaxVol { get; set; }

        public Truck(string licPlt, float gasKm, float priceKm, float maxWg, float maxVol, string mod = null) :
           base(licPlt, gasKm, priceKm, mod) {
            this.MaxWg = maxWg;
            this.MaxVol = maxVol;
        }
    }
}
