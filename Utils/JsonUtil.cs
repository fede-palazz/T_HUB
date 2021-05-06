using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using System.IO;

namespace T_HUB.Utils
{
    public static class JsonUtil
    {
        /// <summary>
        /// Converts a list of vehicles to a JArray object
        /// </summary>
        /// <param name="vehs">List of vehicles</param>
        /// <returns>JArray object</returns>
        public static JArray VehsToJson(List<Vehicle> vehs)
        {
            JArray array = new JArray(); // JSON Array
            foreach (Vehicle veh in vehs)
            {
                JObject obj = new JObject(); // JSON Object

                // Adds general properties
                obj.Add(new JProperty("licPlt", veh.LicPlt));
                obj.Add(new JProperty("mod", veh.Mod));
                obj.Add(new JProperty("gasKm", veh.GasKm));
                obj.Add(new JProperty("priceKm", veh.PriceKm));
                obj.Add(new JProperty("totalKm", veh.TotalKm));

                if (veh.GetType() == typeof(Car))
                {
                    obj.Add(new JProperty("type", "car")); // Vehicle type
                    obj.Add(new JProperty("maxPass", (veh as Car).MaxPass));
                }
                else if (veh.GetType() == typeof(Truck))
                {
                    obj.Add(new JProperty("type", "truck")); // Vehicle type
                    obj.Add(new JProperty("maxWg", (veh as Truck).MaxWg));
                    obj.Add(new JProperty("maxVol", (veh as Truck).MaxVol));
                }
                else if (veh.GetType() == typeof(Van))
                {
                    obj.Add(new JProperty("type", "van")); // Vehicle type
                    obj.Add(new JProperty("maxPass", (veh as Van).MaxPass));
                    obj.Add(new JProperty("maxWg", (veh as Van).MaxWg));
                    obj.Add(new JProperty("maxVol", (veh as Van).MaxVol));
                }
                // Adds the object to the array
                array.Add(obj);
            }
            return array;
        }

        /// <summary>
        /// Converts a JArray object to a list of vehicles
        /// </summary>
        /// <param name="array">JArray object</param>
        /// <returns>List of vehicles</returns>
        public static List<Vehicle> JsonToVehs(JArray array)
        {
            List<Vehicle> vehs = new List<Vehicle>();

            if (array == null)
                throw new Exception("File JSON non valido");

            foreach (JObject obj in array)
            {
                if (obj == null || obj.GetValue("type") == null || obj.GetValue("licPlt") == null ||
                    obj.GetValue("gasKm") == null || obj.GetValue("priceKm") == null ||
                    obj.GetValue("mod") == null)
                    throw new Exception("File JSON non valido");

                switch (obj.GetValue("type").ToString()) // Type of vehicle
                {
                    case "car":
                        if (obj.GetValue("maxPass") == null)
                            throw new Exception("File JSON non valido");

                        vehs.Add(new Car(obj.GetValue("licPlt").ToString(),
                                         double.Parse(obj.GetValue("gasKm").ToString()),
                                         double.Parse(obj.GetValue("priceKm").ToString()),
                                         int.Parse(obj.GetValue("maxPass").ToString()),
                                         obj.GetValue("mod").ToString()));
                        break;

                    case "truck":
                        if (obj.GetValue("maxWg") == null || obj.GetValue("maxVol") == null)
                            throw new Exception("File JSON non valido");

                        vehs.Add(new Truck(obj.GetValue("licPlt").ToString(),
                                           double.Parse(obj.GetValue("gasKm").ToString()),
                                           double.Parse(obj.GetValue("priceKm").ToString()),
                                           double.Parse(obj.GetValue("maxWg").ToString()),
                                           int.Parse(obj.GetValue("totalKm").ToString()),
                                           double.Parse(obj.GetValue("maxVol").ToString()),
                                           obj.GetValue("mod").ToString()));
                        break;

                    case "van":
                        if (obj.GetValue("maxPass") == null || obj.GetValue("maxWg") == null ||
                            obj.GetValue("maxVol") == null)
                            throw new Exception("File JSON non valido");

                        vehs.Add(new Van(obj.GetValue("licPlt").ToString(),
                                           double.Parse(obj.GetValue("gasKm").ToString()),
                                           double.Parse(obj.GetValue("priceKm").ToString()),
                                           int.Parse(obj.GetValue("totalKm").ToString()),
                                           double.Parse(obj.GetValue("maxWg").ToString()),
                                           double.Parse(obj.GetValue("maxVol").ToString()),
                                           int.Parse(obj.GetValue("maxPass").ToString()),
                                           obj.GetValue("mod").ToString()));
                        break;
                }
            }

            return vehs;
        }

        /// <summary>
        /// Converts a list of rides to a JArray
        /// </summary>
        /// <param name="rides">List of rides objects</param>
        /// <returns>JArray object</returns>
        public static JArray RidesToJson(List<Ride> rides)
        {
            JArray array = new JArray(); // JSON Array

            foreach (Ride ride in rides)
            {
                JObject obj = new JObject();
                // Adds general properties
                obj.Add(new JProperty("vehLicPlt", ride.VehLicPlt));
                obj.Add(new JProperty("vehType", ride.VehType));
                obj.Add(new JProperty("startPrc", ride.StartPrc));
                obj.Add(new JProperty("endPrc", ride.EndPrc));
                obj.Add(new JProperty("km", ride.Km));
                obj.Add(new JProperty("startTm", ride.StartTm));
                obj.Add(new JProperty("endTm", ride.EndTm));

                if (ride.GetType() == typeof(PassRide))
                {
                    obj.Add(new JProperty("numPass", (ride as PassRide).NumPass));
                }
                else if (ride.GetType() == typeof(FreightRide))
                {
                    obj.Add(new JProperty("wg", (ride as FreightRide).Wg));
                    obj.Add(new JProperty("vol", (ride as FreightRide).Vol));
                }
                array.Add(obj);
            }
            return array;
        }

        /// <summary>
        /// Converts a JArray object to a list of rides
        /// </summary>
        /// <param name="array">JArray object</param>
        /// <returns>List of rides</returns>
        public static List<Ride> JsonToRides(JArray array)
        {
            List<Ride> rides = new List<Ride>();
            if (array == null)
                throw new Exception("File JSON non valido!");
            foreach (JObject obj in array)
            {
                if (obj == null || obj.GetValue("vehType") == null || obj.GetValue("vehLicPlt") == null ||
                    obj.GetValue("km") == null || obj.GetValue("startTm") == null ||
                    obj.GetValue("endTm") == null || obj.GetValue("endPrc") == null ||
                    obj.GetValue("startPrc") == null)
                    throw new Exception("File JSON non valido!");

                if (obj.ContainsKey("numPass")) // Passenger ride
                {
                    if (obj.GetValue("numPass") == null)
                        throw new Exception("File JSON non valido!");

                    rides.Add(new PassRide(obj.GetValue("vehType").ToString(),
                                           obj.GetValue("vehLicPlt").ToString(),
                                           int.Parse(obj.GetValue("km").ToString()),
                                           DateTime.Parse(obj.GetValue("startTm").ToString()),
                                           DateTime.Parse(obj.GetValue("endTm").ToString()),
                                           double.Parse(obj.GetValue("endPrc").ToString()),
                                           int.Parse(obj.GetValue("numPass").ToString()),
                                           double.Parse(obj.GetValue("startPrc").ToString())));
                }

                else if (obj.ContainsKey("wg")) // Freight ride
                {
                    if (obj.GetValue("wg") == null || obj.GetValue("vol") == null)
                        throw new Exception("File JSON non valido!");

                    rides.Add(new FreightRide(obj.GetValue("vehType").ToString(),
                                           obj.GetValue("vehLicPlt").ToString(),
                                           int.Parse(obj.GetValue("km").ToString()),
                                           DateTime.Parse(obj.GetValue("startTm").ToString()),
                                           DateTime.Parse(obj.GetValue("endTm").ToString()),
                                           double.Parse(obj.GetValue("endPrc").ToString()),
                                           double.Parse(obj.GetValue("wg").ToString()),
                                           double.Parse(obj.GetValue("vol").ToString()),
                                           double.Parse(obj.GetValue("startPrc").ToString())));
                }
            }

            return rides;
        }

        /// <summary>
        /// Writes a JArray object to a JSON file
        /// </summary>
        /// <param name="array">JArray object</param>
        /// <param name="path">File path</param>
        public static void WriteJArray(JArray array, string path)
        {
            try { File.WriteAllText(path, array.ToString()); }
            catch (FileNotFoundException e) { throw new FileNotFoundException(e.StackTrace); }
            catch (Exception e) { throw new Exception(e.StackTrace); }
        }

        /// <summary>
        /// Reads a JArray object from a JSON file
        /// </summary>
        /// <param name="path">File path</param>
        /// <returns>JArray object</returns>
        public static JArray ReadJArray(string path)
        {
            try { return JArray.Parse(File.ReadAllText(path)); }
            catch (FileNotFoundException e) { throw new FileNotFoundException(e.StackTrace); }
            catch (Exception e) { throw new Exception(e.StackTrace); }
        }

    }
}
