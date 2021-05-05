using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model
{
    public class PassRide : Ride
    {

        /// <summary>
        /// Number of passengers in the ride
        /// </summary>
        public int NumPass { get; }

        public PassRide(string vehType, string vehLicPlt, int km, DateTime startTm, DateTime endTm,
            int numPass, double startPrc = 0) : base(vehType, vehLicPlt, km, startTm, endTm, startPrc)
        {
            this.NumPass = numPass;
        }

        public PassRide(string vehType, string vehLicPlt, int km, DateTime startTm, DateTime endTm, 
            double endPrc, int numPass, double startPrc = 0) : base(vehType, vehLicPlt, km, startTm, endTm, endPrc, startPrc)
        {
            this.NumPass = numPass;
        }

    }
}
