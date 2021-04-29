using System;
using System.Collections.Generic;
using System.Text;
using T_HUB.Model;

namespace T_HUB.Dao
{
    interface RideDao
    {

        /// <summary>
        /// Registers a new ride
        /// </summary>
        /// <param name="ride">Ride to be tracked</param>
        void AddRide(Ride ride);

        /// <summary>
        /// Ends a ride
        /// </summary>
        /// <param name="licPlt">License plate of the associated vehicle</param>
        /// <param name="endTm">End time of the ride</param>
        void EndRide(string licPlt, DateTime endTm);

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
        /// Sorts the current rides list
        /// </summary>
        /// <param name="param">Sorting parameter {"lic", "startTm", "km"}</param>
        /// <param name="mode">Sorting mode {"asc", "desc"}</param>
        /// <returns>Sorted current rides list</returns>
        List<Ride> SortRides(string param, string mode);

        /// <summary>
        /// Sorts the completed rides list
        /// </summary>
        /// <param name="param">Sorting parameter {"lic", "startTm", "km", "endTm"}</param>
        /// <param name="mode">Sorting mode {"asc", "desc"}</param>
        /// <returns>Sorted completed rides list</returns>
        List<Ride> SortComplRides(string param, string mode);

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
    }
}
