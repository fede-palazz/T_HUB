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
            switch (Type(veh))
            {
                case "car":
                    vehs.Add(new Car(veh.LicPlt, veh.GasKm, veh.PriceKm, ((Car) veh).MaxPass, veh.Mod));
                    break;
                case "truck":
                    vehs.Add(new Truck(veh.LicPlt, veh.GasKm, veh.PriceKm, ((Truck) veh).MaxWg,
                                        ((Truck) veh).MaxVol, veh.Mod));
                    break;
                case "van":
                    vehs.Add(new Van(veh.LicPlt, veh.GasKm, veh.PriceKm, ((Van) veh).MaxWg,
                                        ((Van) veh).MaxVol, ((Van) veh).MaxPass, veh.Mod));
                    break;
            }
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

        public void UpdVeh(string licPlt, Vehicle veh)
        {
            Vehicle v = this.GetVeh(licPlt);

            v.Mod = veh.Mod;
            v.GasKm = veh.GasKm;
            v.PriceKm = veh.PriceKm;
            v.TotalKm = veh.TotalKm;
            // Check vehicle type
            switch (Type(veh))
            {
                case "car":
                    (v as Car).MaxPass = (veh as Car).MaxPass;
                    break;
                case "truck":
                    (v as Truck).MaxWg = (veh as Truck).MaxWg;
                    (v as Truck).MaxVol = (veh as Truck).MaxVol;
                    break;
                case "van":
                    (v as Van).MaxPass = (veh as Van).MaxPass;
                    (v as Van).MaxWg = (veh as Van).MaxWg;
                    (v as Van).MaxVol = (veh as Van).MaxVol;
                    break;
            }
        }

        public string Type(Vehicle veh)
        {
            if (veh.GetType() == typeof(Car))
                return "car";
            else if (veh.GetType() == typeof(Truck))
                return "truck";
            else if (veh.GetType() == typeof(Van))
                return "van";
            return null;
        }
    }
}
