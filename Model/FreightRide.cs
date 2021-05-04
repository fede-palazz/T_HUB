using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model
{
    public class FreightRide : Ride
    {

        /// <summary>
        /// Total weigth of the goods
        /// </summary>
        public double Wg { get; }

        /// <summary>
        /// Volume occupied by the goods
        /// </summary>
        public double Vol { get; }

        public FreightRide(string vehType, string vehLicPlt, int km, DateTime startTm,
            DateTime endTm, double wg, double vol, double startPrc = 0) :
            base(vehType, vehLicPlt, km, startTm, endTm, startPrc)
        {
            this.Wg = wg;
            this.Vol = vol;
        }
    }
}
