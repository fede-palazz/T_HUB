using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Controller
{
    public interface THub
    {

        /// <summary>
        /// Registers a new ride
        /// </summary>
        /// <param name="ride">Ride object</param>
        void AddRide(Ride ride);

        /// <summary>
        /// Adds a new vehicle
        /// </summary>
        /// <param name="veh"></param>
        void AddVeh(Vehicle veh);

        /// <summary>
        /// Updates the vehicle info
        /// </summary>
        /// <param name="licPlt">License plate</param>
        /// <param name="veh">Updated vehicle</param>
        void UpdVeh(string licPlt, Vehicle veh);

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
        /// Returns the list of the available vehicles
        /// </summary>
        /// <returns>List of available vehicles</returns>
        List<Vehicle> GetAvailVehs();

        /// <summary>
        /// Returns the list of unavailable vehicles
        /// </summary>
        /// <returns>List of unavailable vehicles</returns>
        List<Vehicle> GetNotAvailVehs();

        /// <summary>
        /// Returns a specific vehicle
        /// </summary>
        /// <param name="licPlt">License plate</param>
        /// <returns></returns>
        Vehicle GetVeh(string licPlt);

        /// <summary>
        /// Returns true if the specified vehicle is available
        /// </summary>
        /// <param name="licPlt">Vehicle's license plate</param>
        /// <returns>True if the vehicle is available, false otherwise</returns>
        bool IsAvailable(string licPlt);

        /// <summary>
        /// Returns the total number of available vehicles for each category
        /// </summary>
        /// <returns>Availability number of each type of vehicle</returns>
        int[] Availability();

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
        /// Return the specified completed ride
        /// </summary>
        /// <param name="licPlt">License plate</param>
        /// <returns></returns>
        Ride GetComplRide(string licPlt);

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
        /// Imports a completed rides list
        /// </summary>
        /// <param name="rides">Rides list</param>
        void LoadRides(List<Ride> rides);

        /// <summary>
        /// Imports a vehicles list
        /// </summary>
        /// <param name="vehs">Vehicles list</param>
        void LoadVehs(List<Vehicle> vehs);

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <param name="veh">Vehicle object</param>
        /// <returns>{ "car", "truck", "van" }</returns>
        string Type(Vehicle veh);

    }
}
