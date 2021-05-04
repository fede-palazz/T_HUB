using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao
{
    class VehDaoImpl : VehDao
    {

        private List<Vehicle> vehs;

        public VehDaoImpl()
        {
            vehs = new List<Vehicle>();
        }

        public void AddVeh(Vehicle veh)
        {
            if (veh.GetType() == typeof(Car))
                vehs.Add(new Car(veh.LicPlt, veh.GasKm, veh.PriceKm, ((Car) veh).MaxPass, veh.Mod));
            else if (veh.GetType() == typeof(Truck))
                vehs.Add(new Truck(veh.LicPlt, veh.GasKm, veh.PriceKm, ((Truck) veh).MaxWg,
                    ((Truck) veh).MaxVol, veh.Mod));
            else if (veh.GetType() == typeof(Van))
                vehs.Add(new Van(veh.LicPlt, veh.GasKm, veh.PriceKm, ((Van) veh).MaxWg,
                    ((Van) veh).MaxVol, ((Van) veh).MaxPass, veh.Mod));
        }

        public bool IsPresent(string licPlt)
        {
            foreach (Vehicle v in vehs)
                if (v.LicPlt == licPlt)
                    return true;
            return false;

        }

        public List<Vehicle> DelVehs()
        {
            List<Vehicle> temp = new List<Vehicle>(vehs);
            vehs.Clear();
            return temp;
        }

        public void DelVeh(string licPlt)
        {
            foreach (Vehicle v in vehs)
                if (v.LicPlt == licPlt)
                {
                    vehs.Remove(v);
                    return;
                }
        }

        public Vehicle GetVeh(string licPlt)
        {
            foreach (Vehicle v in vehs)
                if (v.LicPlt == licPlt)
                    return v;
            return null;
        }

        public List<Vehicle> GetVehs()
        {
            return vehs;
        }

        public void LoadVehs(List<Vehicle> vehs)
        {
            foreach (Vehicle v in vehs)
                this.vehs.Add(v);
        }

        public void UpdVeh(Vehicle veh)
        {
            Vehicle v = this.GetVeh(veh.LicPlt);

            v.Mod = veh.Mod;
            v.TotalKm = veh.TotalKm;
            // Check vehicle type
            if (v.GetType() == typeof(Car))
                (v as Car).MaxPass = (veh as Car).MaxPass;
            else if (v.GetType() == typeof(Truck))
            {
                (v as Truck).MaxWg = (veh as Truck).MaxWg;
                (v as Truck).MaxVol = (veh as Truck).MaxVol;
            }
            else if (v.GetType() == typeof(Van))
            {
                (v as Van).MaxPass = (veh as Van).MaxPass;
                (v as Van).MaxWg = (veh as Van).MaxWg;
                (v as Van).MaxVol = (veh as Van).MaxVol;
            }
            return;

        }
    }
}
