using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    class Ride {

        /// <summary>
        /// Type of associated vehicle {"Car", "Truck", "Van"}
        /// </summary>
        public string VehType { get; }
        /// <summary>
        /// Associated vehicle's license plate
        /// </summary>
        public string VehLicPlt { get; }

        /// <summary>
        /// Start price of the ride
        /// </summary>
        public float StartPrc { get; }

        /// <summary>
        /// Km to be travelled for this ride
        /// </summary>
        public float Km { get; }

        /// <summary>
        /// Starting time of the ride
        /// </summary>
        public DateTime StartTm { get; set; }

        /// <summary>
        /// End time of the ride
        /// </summary>
        public DateTime EndTm { get; set; }

        public Ride(string vehType, string vehLicPlt, float km, DateTime startTm, DateTime endTm, 
            float startPrc = 0) {
            VehType = vehType;
            VehLicPlt = vehLicPlt;
            StartPrc = startPrc;
            Km = km;
            StartTm = startTm;
            EndTm = endTm;
        }

    }
}
