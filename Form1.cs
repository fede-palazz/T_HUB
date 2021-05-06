using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_HUB.Controller;
using T_HUB.Model;
using T_HUB.Utils;

namespace T_HUB
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global variable used to determine which panel is currently displayed
        /// Values : { "dash", "vehs", "rides" }
        /// </summary>
        private string panel;
        private THub hub;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Graphics
            // External bands colors
            titlePnl.BackColor = ColorTranslator.FromHtml("#263238");
            titleLbl.ForeColor = ColorTranslator.FromHtml("#eceff1");
            navBarPnl.BackColor = ColorTranslator.FromHtml("#263238");
            // Panels colors
            dashPnl.BackColor = ColorTranslator.FromHtml("#90a4ae");
            vehsPnl.BackColor = ColorTranslator.FromHtml("#90a4ae");
            ridesPnl.BackColor = ColorTranslator.FromHtml("#90a4ae");

            // Buttons colors
            addRideBtn.BackColor = ColorTranslator.FromHtml("#263238");
            endRideBtn.BackColor = ColorTranslator.FromHtml("#263238");

            addVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            updVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            delVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            impVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            expVehBtn.BackColor = ColorTranslator.FromHtml("#263238");

            impComplRidesBtn.BackColor = ColorTranslator.FromHtml("#263238");
            expComplRidesBtn.BackColor = ColorTranslator.FromHtml("#263238");
            delComplRidesBtn.BackColor = ColorTranslator.FromHtml("#263238");

            // Tooltips 
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(addRideBtn, "Add a new ride");
            toolTip1.SetToolTip(endRideBtn, "End the selected ride");
            toolTip1.SetToolTip(addVehBtn, "Add a new vehicle");
            toolTip1.SetToolTip(updVehBtn, "Update the selected vehicle");
            toolTip1.SetToolTip(delVehBtn, "Remove the selected vehicle");
            toolTip1.SetToolTip(impVehBtn, "Import vehicles");
            toolTip1.SetToolTip(expVehBtn, "Export vehicles");
            toolTip1.SetToolTip(impComplRidesBtn, "Import rides");
            toolTip1.SetToolTip(expComplRidesBtn, "Export rides");
            toolTip1.SetToolTip(delComplRidesBtn, "Clear history");

            #endregion

            hub = new THubImpl();
            dashPnl.BringToFront();
            panel = "dash";
            viewCmb.SelectedIndex = 0;
        }

        #region Navbar

        private void navDashPtb_MouseEnter(object sender, EventArgs e)
        {
            if (panel != "dash")
                navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_sel;
        }

        private void navDashPtb_MouseLeave(object sender, EventArgs e)
        {
            if (panel != "dash")
                navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
        }

        private void navVehsPtb_MouseEnter(object sender, EventArgs e)
        {
            if (panel != "vehs")
                navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_sel;
        }

        private void navVehsPtb_MouseLeave(object sender, EventArgs e)
        {
            if (panel != "vehs")
                navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
        }

        private void navRidesPtb_MouseEnter(object sender, EventArgs e)
        {
            if (panel != "rides")
                navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_sel;
        }

        private void navRidesPtb_MouseLeave(object sender, EventArgs e)
        {
            if (panel != "rides")
                navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
        }

        private void navDashPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Dashboard";
            dashPnl.BringToFront();
            // Reset buttons selections
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
            panel = "dash";
        }

        private void navVehsPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Vehicles";
            vehsPnl.BringToFront();
            // Reset buttons selections
            navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
            panel = "vehs";
        }

        private void navRidesPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Rides";
            ridesPnl.BringToFront();
            // Reset buttons selections
            navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
            panel = "rides";
        }

        #endregion

        #region "Vehicles tab"

        private void RefreshVehsList()
        {
            vehsList.Items.Clear(); // Removes all vehicles
            foreach (Vehicle v in hub.GetVehs())
                DisplayVeh(v);
        }

        /// <summary>
        /// Displays the vehicle in the listview
        /// </summary>
        /// <param name="veh">Vehicle to display</param>
        private void DisplayVeh(Vehicle veh)
        {
            ListViewItem row = null; // Listview row

            switch (hub.Type(veh))
            {
                case "car":
                    // Vehicle's parameters
                    string[] carParam = {"", veh.LicPlt, veh.Mod, veh.TotalKm + "",
                        ((Car)veh).MaxPass + "", "-", "-"};
                    // Check availability
                    if (hub.IsAvailable(veh.LicPlt))
                        row = new ListViewItem(carParam, 0);
                    else
                        row = new ListViewItem(carParam, 3);
                    break;
                case "truck":
                    // Vehicle's parameters
                    string[] truckParam = {"", veh.LicPlt, veh.Mod, veh.TotalKm + "",
                        "-", ((Truck)veh).MaxWg + "", ((Truck)veh).MaxVol + "" };
                    // Check availability
                    if (hub.IsAvailable(veh.LicPlt))
                        row = new ListViewItem(truckParam, 1);
                    else
                        row = new ListViewItem(truckParam, 4);
                    break;
                case "van":
                    // Vehicle's parameters
                    string[] vanParam = {"", veh.LicPlt, veh.Mod, veh.TotalKm + "",
                        ((Van)veh).MaxPass + "", ((Van)veh).MaxWg + "", ((Van)veh).MaxVol + "" };
                    // Check availability
                    if (hub.IsAvailable(veh.LicPlt))
                        row = new ListViewItem(vanParam, 2);
                    else
                        row = new ListViewItem(vanParam, 5);
                    break;
            }
            vehsList.Items.Add(row);
        }

        private void addVehBtn_Click(object sender, EventArgs e)
        {
            int vehsCount = hub.GetVehs().Count;
            // Shows the form
            using (VehInfo vehInfo = new VehInfo(hub))
            {
                vehInfo.ShowDialog();
            }
            RefreshVehsList();
            RefreshAvailability();
        }

        private void delVehBtn_Click(object sender, EventArgs e)
        {
            if (vehsList.Items.Count > 0) // At least one vehicle in the list
            {
                // Gets the license plate of the selected vehicle
                string licPlt = vehsList.SelectedItems[0].SubItems[1].Text;
                if (!string.IsNullOrEmpty(licPlt) && hub.IsAvailable(licPlt)) // If available
                {
                    // Removes it
                    hub.DelVeh(licPlt);
                    vehsList.SelectedItems[0].Remove();
                    RefreshAvailability();
                }
                else
                    MessageBox.Show("The vehicle is currently unavailable :(", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void updVehBtn_Click(object sender, EventArgs e)
        {
            string licPlt = null;
            if (vehsList.Items.Count > 0)
                licPlt = vehsList.SelectedItems[0].SubItems[1].Text;
            if (!string.IsNullOrEmpty(licPlt) && hub.IsAvailable(licPlt))
            {
                using (VehInfo vehInfo = new VehInfo(hub, licPlt))
                {
                    vehInfo.ShowDialog();
                }
                RefreshVehsList();
            }
            else
                MessageBox.Show("The vehicle is currently unavailable :(", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void viewCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehsList.Items.Clear();

            switch (viewCmb.SelectedIndex)
            {
                case 0: // All vehicles
                    RefreshVehsList();
                    break;
                case 1: // Available vehicles
                    foreach (Vehicle v in hub.GetAvailVehs())
                        DisplayVeh(v);
                    break;
                case 2: // Non available vehicles
                    foreach (Vehicle v in hub.GetNotAvailVehs())
                        DisplayVeh(v);
                    break;
            }
        }

        private void vehsList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = vehsList.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                vehsList.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            vehsList.Sort();
        }

        private void expVehBtn_Click(object sender, EventArgs e)
        {
            if (vehsList.Items.Count > 0)
            {
                string path = ""; // File path

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "JSOn File|*.json";
                    dialog.Title = "Export Vehicles";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        path = dialog.FileName;
                    else
                        return;
                }
                // Selects vehicles to export
                List<Vehicle> expVehs = new List<Vehicle>();
                switch (viewCmb.SelectedIndex)
                {
                    case 0: // All
                        expVehs = hub.GetVehs();
                        break;
                    case 1: // Available
                        foreach (Vehicle v in hub.GetVehs())
                            if (hub.IsAvailable(v.LicPlt))
                                expVehs.Add(v);
                        break;
                    case 2: // Not available
                        foreach (Vehicle v in hub.GetVehs())
                            if (!hub.IsAvailable(v.LicPlt))
                                expVehs.Add(v);
                        break;
                }
                // Save to file
                JsonUtil.WriteJArray(JsonUtil.VehsToJson(expVehs), path);
            }
        }

        private void impVehBtn_Click(object sender, EventArgs e)
        {
            string path = ""; // File path
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JSOn File|*.json";
                dialog.Title = "Import Vehicles";
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.FileName;
                else
                    return;
            }

            List<Vehicle> impVehs = null;
            try
            {
                impVehs = JsonUtil.JsonToVehs(JsonUtil.ReadJArray(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            hub.LoadVehs(impVehs);
            RefreshVehsList();
            RefreshAvailability();
        }

        #endregion

        #region Dashboard

        /// <summary>
        /// Refreshs vehicles availability in the dashboard panel
        /// </summary>
        private void RefreshAvailability()
        {
            int[] num = hub.Availability();

            // Labels update
            carCountLbl.Text = num[0].ToString();
            truckCountLbl.Text = num[1].ToString();
            vanCountLbl.Text = num[2].ToString();

            // Pictureboxes update
            if (num[0] > 0)
                dashCarPtb.Image = T_HUB.Properties.Resources.car;
            else
                dashCarPtb.Image = T_HUB.Properties.Resources.car_red;
            if (num[1] > 0)
                dashTruckPtb.Image = T_HUB.Properties.Resources.truck;
            else
                dashTruckPtb.Image = T_HUB.Properties.Resources.truck_red;
            if (num[2] > 0)
                dashVanPtb.Image = T_HUB.Properties.Resources.van;
            else
                dashVanPtb.Image = T_HUB.Properties.Resources.van_red;
        }

        private void DisplayRide(Ride ride)
        {
            // type  licPlt   Km   Pass  Wg   Vol   StartTm

            ListViewItem row = null; // Listview row

            if (ride.GetType() == typeof(PassRide)) // Passenger ride
            {
                string[] param = {"", ride.VehLicPlt, ride.Km.ToString(), ride.StartTm.ToString(),
                    (ride as PassRide).NumPass.ToString(), "-", "-"};
                // Vehicle type
                if (hub.Type(hub.GetVeh(ride.VehLicPlt)) == "car")
                    row = new ListViewItem(param, 0); // Adds row with image
                else if (hub.Type(hub.GetVeh(ride.VehLicPlt)) == "van")
                    row = new ListViewItem(param, 2); // Adds row with image
            }
            else // Freight ride
            {
                string[] param = {"", ride.VehLicPlt, ride.Km.ToString(), ride.StartTm.ToString(),
                    "-", (ride as FreightRide).Wg.ToString(), (ride as FreightRide).Vol.ToString()};
                // Vehicle type
                if (hub.Type(hub.GetVeh(ride.VehLicPlt)) == "truck")
                    row = new ListViewItem(param, 1); // Adds row with image
                else if (hub.Type(hub.GetVeh(ride.VehLicPlt)) == "van")
                    row = new ListViewItem(param, 2); // Adds row with image
            }
            // Adds the row
            currentRidesList.Items.Add(row);
        }

        private void RefreshRidesList()
        {
            currentRidesList.Items.Clear(); // Removes all vehicles
            if (hub.GetRides().Count > 0)
            {
                noRidesLbl.Visible = false;
                foreach (Ride r in hub.GetRides())
                    DisplayRide(r);
            }
            else
                noRidesLbl.Visible = true;
        }

        private void addRideBtn_Click(object sender, EventArgs e)
        {
            if (hub.GetVehs().Count == 0)
            {
                MessageBox.Show("You should add a vehicle first ;)", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            // Opens the new ride form
            using (NewRide ride = new NewRide(hub))
            {
                ride.ShowDialog();
            }
            RefreshRidesList();
            RefreshVehsList();
            RefreshAvailability();
        }

        private void endRideBtn_Click(object sender, EventArgs e)
        {
            if (currentRidesList.Items.Count > 0) // At least one ride in the list
            {
                // Gets the license plate
                string licPlt = currentRidesList.SelectedItems[0].SubItems[1].Text;
                if (!string.IsNullOrEmpty(licPlt))
                {
                    // Removes it
                    hub.EndRide(licPlt);

                    // Updates vehicle's km
                    int rideKm = int.Parse(currentRidesList.SelectedItems[0].SubItems[2].Text);
                    hub.GetVeh(licPlt).TotalKm += rideKm;

                    // Updates end price
                    double startPrc = hub.GetComplRide(licPlt).StartPrc;
                    hub.GetComplRide(licPlt).EndPrc = (hub.GetVeh(licPlt).PriceKm * rideKm) + startPrc;

                    currentRidesList.SelectedItems[0].Remove();
                    if (currentRidesList.Items.Count == 0)
                        noRidesLbl.Visible = true;
                    RefreshComplRidesList();
                    RefreshVehsList();
                    RefreshAvailability();
                }
            }
        }

        private void currentRidesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = currentRidesList.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                currentRidesList.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            currentRidesList.Sort();
        }

        #endregion

        #region Completed Rides
        private void complRidesList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ItemComparer sorter = complRidesList.ListViewItemSorter as ItemComparer;
            if (sorter == null)
            {
                sorter = new ItemComparer(e.Column);
                sorter.Order = SortOrder.Ascending;
                complRidesList.ListViewItemSorter = sorter;
            }
            // if clicked column is already the column that is being sorted
            if (e.Column == sorter.Column)
            {
                // Reverse the current sort direction
                if (sorter.Order == SortOrder.Ascending)
                    sorter.Order = SortOrder.Descending;
                else
                    sorter.Order = SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }
            complRidesList.Sort();
        }

        private void RefreshComplRidesList()
        {
            complRidesList.Items.Clear(); // Removes all vehicles
            if (hub.GetComplRides().Count > 0)
            {
                foreach (Ride r in hub.GetComplRides())
                    DisplayComplRide(r);
            }
        }

        private void DisplayComplRide(Ride ride)
        {
            // type   licPlt   Km   startTm   endTm   Pass   Wg   Vol   endPrc    
            ListViewItem row = null; // Listview row

            if (ride.GetType() == typeof(PassRide)) // Passenger ride
            {
                string[] param = {"", ride.VehLicPlt, ride.Km.ToString(), ride.StartTm.ToString(),
                    ride.EndTm.ToString(), (ride as PassRide).NumPass.ToString(), "-", "-",
                    ride.EndPrc.ToString()};
                // Vehicle type
                if (ride.VehType == "car")
                    row = new ListViewItem(param, 0); // Adds row with image
                else if (ride.VehType == "van")
                    row = new ListViewItem(param, 2); // Adds row with image
            }
            else // Freight ride
            {
                string[] param = {"", ride.VehLicPlt, ride.Km.ToString(), ride.StartTm.ToString(),
                    ride.EndTm.ToString(), "-", (ride as FreightRide).Wg.ToString(), 
                    (ride as FreightRide).Vol.ToString(), ride.EndPrc.ToString()};
                // Vehicle type
                if (ride.VehType == "truck")
                    row = new ListViewItem(param, 1); // Adds row with image
                else if (ride.VehType == "van")
                    row = new ListViewItem(param, 2); // Adds row with image
            }
            // Adds the row
            complRidesList.Items.Add(row);
        }

        private void impComplRidesBtn_Click(object sender, EventArgs e)
        {
            string path = ""; // File path
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JSOn File|*.json";
                dialog.Title = "Import Rides";
                if (dialog.ShowDialog() == DialogResult.OK)
                    path = dialog.FileName;
                else
                    return;
            }

            List<Ride> impRides = null;
            try
            {
                impRides = JsonUtil.JsonToRides(JsonUtil.ReadJArray(path));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            hub.LoadRides(impRides);
            RefreshComplRidesList();
        }

        private void expComplRidesBtn_Click(object sender, EventArgs e)
        {
            if (complRidesList.Items.Count > 0)
            {
                string path = ""; // File path

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "JSOn File|*.json";
                    dialog.Title = "Export Rides";
                    if (dialog.ShowDialog() == DialogResult.OK)
                        path = dialog.FileName;
                    else
                        return;
                }
                // Save to file
                JsonUtil.WriteJArray(JsonUtil.RidesToJson(hub.GetComplRides()), path);
            }
        }

        private void delComplRidesBtn_Click(object sender, EventArgs e)
        {
            hub.DelComplRides();
            RefreshComplRidesList();
        }

        #endregion
    }
}
