using System;
using System.Collections.Generic;
using System.Text;

namespace T_HUB.Model {
    class FreightRide : Ride {

        /// <summary>
        /// Total weigth of the goods
        /// </summary>
        public float Wg { get; }

        /// <summary>
        /// Volume occupied by the goods
        /// </summary>
        public float Vol { get; }

        public FreightRide(string vehType, string vehLicPlt, float km, DateTime startTm, 
            DateTime endTm, float wg, float vol, float startPrc = 0) : 
            base(vehType, vehLicPlt, km, startTm, endTm, startPrc) {
            this.Wg = wg;
            this.Vol = vol;
        }
    }
}
