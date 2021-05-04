using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    public class Car : Vehicle {

        /// <summary>
        /// Maximum number of passengers
        /// </summary>
        public int MaxPass { get; set; }

        public Car(string licPlt, double gasKm, double priceKm, int maxPass, string mod = null) :
            base(licPlt, gasKm, priceKm, mod) {
            this.MaxPass = maxPass;
        }

        public Car(string licPlt, double gasKm, double priceKm, int totalKm, int maxPass, 
            string mod = null) : base(licPlt, gasKm, priceKm, totalKm, mod)
        {
            this.MaxPass = maxPass;
        }
    }
}

