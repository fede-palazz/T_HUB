using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model
{
    class PassRide : Ride
    {

        /// <summary>
        /// Number of passengers in the ride
        /// </summary>
        public int NumPass { get; }

        public PassRide(string vehType, string vehLicPlt, double km, DateTime startTm, DateTime endTm,
            int numPass, double startPrc = 0) : base(vehType, vehLicPlt, km, startTm, endTm, startPrc)
        {
            this.NumPass = numPass;
        }

    }
}
