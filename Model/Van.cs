using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    class Van : Truck {

        /// <summary>
        /// Maximum number of passengers
        /// </summary>
        public int MaxPass { get; set; }

        public Van(string licPlt, double gasKm, double priceKm, double maxWg, double maxVol, int maxPass, 
            string mod = null) : base(licPlt, gasKm, priceKm, maxWg, maxVol, mod) {
            this.MaxPass = maxPass;
        }
    }
}
