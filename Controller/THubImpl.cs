using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Dao;
using T_HUB.Model;

namespace T_HUB.Controller
{
    class THubImpl : THub
    {
        private RideDao rideDao;
        private VehDao vehDao;

        public THubImpl()
        {
            this.vehDao = new VehDaoImpl();
            this.rideDao = new RideDaoImpl();
        }

        public void AddRide(Ride ride)
        {
            rideDao.AddRide(ride);
        }

        public void AddVeh(Vehicle veh)
        {
            vehDao.AddVeh(veh);
        }

        public List<Ride> DelComplRides()
        {
            return rideDao.DelComplRides();
        }

        public List<Ride> DelRides()
        {
            return rideDao.DelRides();
        }

        public void DelVeh(string licPlt)
        {
            vehDao.DelVeh(licPlt);
        }

        public void EndRide(string licPlt)
        {
            rideDao.EndRide(licPlt, vehDao.GetVeh(licPlt).PriceKm);
        }

        public List<Ride> GetComplRides()
        {
            return rideDao.GetComplRides();
        }

        public List<Ride> GetRides()
        {
            return rideDao.GetRides();
        }

        public Vehicle GetVeh(string licPlt)
        {
            return vehDao.GetVeh(licPlt);
        }

        public List<Vehicle> GetVehs()
        {
            return vehDao.GetVehs();
        }

        public bool IsAvailable(string licPlt)
        {
            return rideDao.isAvailable(licPlt);
        }

        public void LoadRides(string path)
        {
            throw new NotImplementedException();
        }

        public void LoadVehs(string path)
        {
            throw new NotImplementedException();
        }

        public void SaveRides(string path)
        {
            throw new NotImplementedException();
        }

        public void SaveVehs(string path)
        {
            throw new NotImplementedException();
        }

        public string Type(Vehicle veh)
        {
            return vehDao.Type(veh);
        }

        public void UpdVeh(string licPlt, Vehicle veh)
        {
            vehDao.UpdVeh(licPlt, veh);
        }
    }
}
