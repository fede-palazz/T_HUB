using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    class Vehicle {

        /// <summary>
        /// Vehicle model
        /// </summary>
        public string Mod { get; set; }

        /// <summary>
        /// License Plate
        /// </summary>
        public string LicPlt { get; set; }

        /// <summary>
        /// Gas usage [L/Km]
        /// </summary>
        public float GasKm { get; set; }

        /// <summary>
        /// Price in euros/Km
        /// </summary>
        public float PriceKm { get; set; }

        /// <summary>
        /// Total Km traveled
        /// </summary>
        public float TotalKm { get; set; }

        public Vehicle(string licPlt, float gasKm, float priceKm, string mod = null) {
            this.LicPlt = licPlt;
            this.GasKm = gasKm;
            this.PriceKm = priceKm;
            this.Mod = mod;
            this.TotalKm = 0;
        }

        /// <summary>
        /// Get consumed fuel
        /// </summary>
        /// <returns>Total liters of gas consumed</returns>
        public float GetGasTot() {
            return TotalKm * GasKm;
        }
    }
}
