using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    class Van : Truck {

        /// <summary>
        /// Maximum number of passengers
        /// </summary>
        public int MaxPass { get; set; }

        public Van(string licPlt, float gasKm, float priceKm, float maxWg, float maxVol, int maxPass, 
            string mod = null) : base(licPlt, gasKm, priceKm, maxWg, maxVol, mod) {
            this.MaxPass = maxPass;
        }
    }
}
