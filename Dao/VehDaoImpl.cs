using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao {
    class VehDaoImpl : VehDao {

        private List<Vehicle> vehs;

        public VehDaoImpl() {
            vehs = new List<Vehicle>();
        }

        public void AddVeh(Vehicle veh) {
            throw new NotImplementedException();
        }

        public bool IsPresent(string licPlt) {
            throw new NotImplementedException();
        }

        public List<Vehicle> DelVehs() {
            throw new NotImplementedException();
        }

        public void DelVehs(string licPlt) {
            throw new NotImplementedException();
        }

        public Vehicle GetVeh(string licPlt) {
            throw new NotImplementedException();
        }

        public List<Vehicle> GetVehs() {
            throw new NotImplementedException();
        }

        public void LoadVehs(List<Vehicle> vehs) {
            throw new NotImplementedException();
        }

        public List<Vehicle> Sort(string param, string mode) {
            throw new NotImplementedException();
        }

        public void UpdVeh(string licPlt, Vehicle veh) {
            throw new NotImplementedException();
        }
    }
}
