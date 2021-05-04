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
        public double GasKm { get; set; }

        /// <summary>
        /// Price in euros/Km
        /// </summary>
        public double PriceKm { get; set; }

        /// <summary>
        /// Total Km traveled
        /// </summary>
        public double TotalKm { get; set; }

        public Vehicle(string licPlt, double gasKm, double priceKm, string mod = null) {
            this.LicPlt = licPlt;
            this.GasKm = gasKm;
            this.PriceKm = priceKm;
            this.Mod = mod;
            this.TotalKm = 0;
        }

        public Vehicle(string licPlt, double gasKm, double priceKm, double totalKm, string mod = null)
        {
            this.LicPlt = licPlt;
            this.GasKm = gasKm;
            this.PriceKm = priceKm;
            this.Mod = mod;
            this.TotalKm = totalKm;
        }

        /// <summary>
        /// Get consumed fuel
        /// </summary>
        /// <returns>Total liters of gas consumed</returns>
        public double GetGasTot() {
            return TotalKm * GasKm;
        }
    }
}
