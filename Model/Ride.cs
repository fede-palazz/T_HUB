using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model
{
    class Ride
    {

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
        public double StartPrc { get; }

        /// <summary>
        /// End price of the ride
        /// </summary>
        public double EndPrc { get; set; }

        /// <summary>
        /// Km to be travelled for this ride
        /// </summary>
        public double Km { get; }

        /// <summary>
        /// Starting time of the ride
        /// </summary>
        public DateTime StartTm { get; set; }

        /// <summary>
        /// End time of the ride
        /// </summary>
        public DateTime EndTm { get; set; }

        public Ride(string vehType, string vehLicPlt, double km, DateTime startTm, DateTime endTm,
            double startPrc = 0)
        {
            VehType = vehType;
            VehLicPlt = vehLicPlt;
            StartPrc = startPrc;
            Km = km;
            StartTm = startTm;
            EndTm = endTm;
            EndPrc = 0;
        }

        public Ride(string vehType, string vehLicPlt, double km, DateTime startTm, DateTime endTm, 
            double endPrc, double startPrc = 0)
        {
            VehType = vehType;
            VehLicPlt = vehLicPlt;
            StartPrc = startPrc;
            Km = km;
            StartTm = startTm;
            EndTm = endTm;
            EndPrc = endPrc;
        }



    }
}
