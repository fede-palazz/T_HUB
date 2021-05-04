using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao {
    interface VehDao {

        /// <summary>
        /// Registers a new Vehicle
        /// </summary>
        /// <param name="veh">Vehicle object</param>
        void AddVeh(Vehicle veh);

        /// <summary>
        /// Returns true if a vehicle with the specified license plate is already registered
        /// </summary>
        /// <param name="licPlt">License plate parameter</param>
        /// <returns>True if the vehicle is registered, false otherwise</returns>
        bool IsPresent(string licPlt);

        /// <summary>
        /// Updates the info of an existing vehicle
        /// </summary>
        /// <param name="veh">Updated vehicle</param>
        void UpdVeh(Vehicle veh);

        /// <summary>
        /// Returns the full vehicles list
        /// </summary>
        /// <returns>List of Vehicles</returns>
        List<Vehicle> GetVehs();

        /// <summary>
        /// Returns the specified vehicle
        /// </summary>
        /// <param name="licPlt">Vehicle's license plate</param>
        /// <returns></returns>
        Vehicle GetVeh(string licPlt);

        /// <summary>
        /// Clears the vehicles list
        /// </summary>
        /// <returns>List of Vehicles</returns>
        List<Vehicle> DelVehs();

        /// <summary>
        /// Removes the specified vehicle from the list
        /// </summary>
        /// <param name="licPlt">License Plate of the vehicle to remove</param>
        void DelVeh(string licPlt);

        /// <summary>
        /// Adds to the list the vehicles passed as parameter
        /// </summary>
        /// <param name="vehs">Vehicles list to load</param>
        void LoadVehs(List<Vehicle> vehs);
    }
}
