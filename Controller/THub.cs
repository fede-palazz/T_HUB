using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Controller
{
    interface THub
    {

        /// <summary>
        /// Registers a new passengers ride
        /// </summary>
        /// <param name="ride"></param>
        void AddRide(PassRide ride);

        /// <summary>
        /// Registers a new freight ride
        /// </summary>
        /// <param name="ride"></param>
        void AddRide(FreightRide ride);

        /// <summary>
        /// Adds a new vehicle
        /// </summary>
        /// <param name="veh"></param>
        void AddVeh(Vehicle veh);

        /// <summary>
        /// Updates the vehicle info
        /// </summary>
        /// <param name="veh">Updated vehicle</param>
        void UpdVeh(Vehicle veh);

        /// <summary>
        /// Delete the specified vehicle
        /// </summary>
        /// <param name="licPlt">License plate</param>
        void DelVeh(string licPlt);

        /// <summary>
        /// Returns the complete vehicles list
        /// </summary>
        /// <returns>Vehicles list</returns>
        List<Vehicle> GetVehs();

        /// <summary>
        /// Returns true if the specified vehicle is available
        /// </summary>
        /// <param name="licPlt">Vehicle's license plate</param>
        /// <returns>True if the vehicle is available, false otherwise</returns>
        bool IsAvailable(string licPlt);

        /// <summary>
        /// Returns the current rides list
        /// </summary>
        /// <returns>Current rides list</returns>
        List<Ride> GetRides();

        /// <summary>
        /// Returns the completed rides list
        /// </summary>
        /// <returns>Completed rides list</returns>
        List<Ride> GetComplRides();

        /// <summary>
        /// Ends the specified ride
        /// </summary>
        /// <param name="licPlt">License plate of the ride's associated vehicle</param>
        void EndRide(string licPlt);

        /// <summary>
        /// Clear the current rides list
        /// </summary>
        /// <returns>Current rides list</returns>
        List<Ride> DelRides();

        /// <summary>
        /// Clear the completed rides list
        /// </summary>
        /// <returns>Completed rides list</returns>
        List<Ride> DelComplRides();

        /// <summary>
        /// Exports the current and completed rides lists to a file
        /// </summary>
        /// <param name="path">file path</param>
        void SaveRides(string path);

        /// <summary>
        /// Imports the current and completed rides lists from a file
        /// </summary>
        /// <param name="path">file path</param>
        void LoadRides(string path);

        /// <summary>
        /// Exports the vehicles list to a file
        /// </summary>
        /// <param name="path">file path</param>
        void SaveVehs(string path);

        /// <summary>
        /// Imports the vehicles list from a file
        /// </summary>
        /// <param name="path">file path</param>
        void LoadVehs(string path);

    }
}
