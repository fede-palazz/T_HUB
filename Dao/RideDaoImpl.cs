using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao
{
    class RideDaoImpl : RideDao
    {

        private List<Ride> rides;
        private List<Ride> complRides;

        public RideDaoImpl()
        {
            rides = new List<Ride>();
            complRides = new List<Ride>();
        }

        public void AddRide(Ride ride)
        {
            this.rides.Add(new Ride(ride.VehType, ride.VehLicPlt, ride.Km, ride.StartTm,
                ride.EndTm, ride.StartPrc));
        }

        public List<Ride> DelComplRides()
        {
            List<Ride> temp = new List<Ride>(complRides);
            complRides.Clear();
            return temp;
        }

        public List<Ride> DelRides()
        {
            List<Ride> temp = new List<Ride>(rides);
            rides.Clear();
            return temp;
        }

        public void EndRide(string licPlt, double priceKm)
        {
            foreach (Ride r in rides)
            {
                if (r.VehLicPlt == licPlt) // Found the ride
                {
                    r.EndPrc = (priceKm * r.Km) + r.StartPrc; // Set end price of the ride
                    complRides.Add(r);
                    rides.Remove(r);
                    return;
                }
            }
        }

        public List<Ride> GetComplRides()
        {
            return complRides;
        }

        public List<Ride> GetRides()
        {
            return rides;
        }

        public bool isAvailable(string licPlt)
        {
            foreach (Ride r in rides)
                if (r.VehLicPlt == licPlt)
                    return false;
            return true;
        }

        public void LoadComplRides(List<Ride> rides)
        {
            foreach (Ride r in rides)
            {
                complRides.Add(new Ride(r.VehType, r.VehLicPlt, r.Km, r.StartTm, r.EndTm, r.StartPrc));
            }
        }

        public void LoadRides(List<Ride> rides)
        {
            foreach (Ride r in rides)
                rides.Add(new Ride(r.VehType, r.VehLicPlt, r.Km, r.StartTm, r.EndTm, r.StartPrc));

        }


    }
}
