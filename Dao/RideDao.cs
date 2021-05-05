using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao
{
    public interface RideDao
    {

        /// <summary>
        /// Registers a new ride
        /// </summary>
        /// <param name="ride">Ride to be tracked</param>
        void AddRide(Ride ride);

        /// <summary>
        /// Registers a completed ride
        /// </summary>
        /// <param name="ride">Completed ride</param>
        void AddComplRide(Ride ride);

        /// <summary>
        /// Ends a ride
        /// </summary>
        /// <param name="licPlt">License plate of the associated vehicle</param>
        /// <param name="priceKm">Vehicle price</param>
        void EndRide(string licPlt, double priceKm);

        /// <summary>
        /// Returns the current rides list
        /// </summary>
        /// <returns>Current rides list</returns>
        List<Ride> GetRides();

        /// <summary>
        /// Clears the current rides list
        /// </summary>
        /// <returns>Current rides list</returns>
        List<Ride> DelRides();

        /// <summary>
        /// Returns the completed rides list
        /// </summary>
        /// <returns>Completed rides list</returns>
        List<Ride> GetComplRides();

        /// <summary>
        /// Clears the completed rides list
        /// </summary>
        /// <returns>Completed rides list</returns>
        List<Ride> DelComplRides();

        /// <summary>
        /// Adds to the current rides list the rides passed as parameter
        /// </summary>
        /// <param name="rides">Current rides list to load</param>
        void LoadRides(List<Ride> rides);

        /// <summary>
        /// Adds to the completed rides list the rides passed as parameter
        /// </summary>
        /// <param name="rides">Completed rides list to load</param>
        void LoadComplRides(List<Ride> rides);

        /// <summary>
        /// Returns true if the specified vehicle is not present in the rides list
        /// </summary>
        /// <param name="licPlt">License plate of the vehicle</param>
        /// <returns></returns>
        bool isAvailable(string licPlt);
    }
}
