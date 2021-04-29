using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao {
    class RideDaoImpl : RideDao {

        private List<Ride> rides;
        private List<Ride> complRides;

        public RideDaoImpl() {
            rides = new List<Ride>();
            complRides = new List<Ride>();
        }

        public void AddRide(Ride ride) {
            throw new NotImplementedException();
        }

        public List<Ride> DelComplRides() {
            throw new NotImplementedException();
        }

        public List<Ride> DelRides() {
            throw new NotImplementedException();
        }

        public void EndRide(string licPlt, DateTime endTm) {
            throw new NotImplementedException();
        }

        public List<Ride> GetComplRides() {
            throw new NotImplementedException();
        }

        public List<Ride> GetRides() {
            throw new NotImplementedException();
        }

        public List<Ride> SortComplRides(string param, string mode) {
            throw new NotImplementedException();
        }

        public List<Ride> SortRides(string param, string mode) {
            throw new NotImplementedException();
        }

        public void LoadComplRides(List<Ride> rides) {
            throw new NotImplementedException();
        }

        public void LoadRides(List<Ride> rides) {
            throw new NotImplementedException();
        }

      
    }
}
