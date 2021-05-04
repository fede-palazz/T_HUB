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
            // Labels colors
            carCountLbl.ForeColor = ColorTranslator.FromHtml("#455a64");
            // Buttons colors
            addRideBtn.BackColor = ColorTranslator.FromHtml("#263238");
            endRideBtn.BackColor = ColorTranslator.FromHtml("#263238");

            addVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            updVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            delVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            impVehBtn.BackColor = ColorTranslator.FromHtml("#263238");
            expVehBtn.BackColor = ColorTranslator.FromHtml("#263238");

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
            if (hub.GetVehs().Count != vehsCount) // Vehicle added
                RefreshVehsList(); // Refresh the list
        }

        private void delVehBtn_Click(object sender, EventArgs e)
        {
            if (vehsList.Items.Count > 0) // At least one vehicle in the list
            {
                // Gets the license plate of the selected vehicle
                string licPlt = vehsList.SelectedItems[0].SubItems[1].Text;
                // Removes it
                hub.DelVeh(licPlt);
                vehsList.SelectedItems[0].Remove();
            }
        }

        private void updVehBtn_Click(object sender, EventArgs e)
        {
            string licPlt = null;
            if (vehsList.Items.Count > 0)
                licPlt = vehsList.SelectedItems[0].SubItems[1].Text;
            if (!string.IsNullOrEmpty(licPlt))
            {
                using (VehInfo vehInfo = new VehInfo(hub, licPlt))
                {
                    vehInfo.ShowDialog();
                }
                RefreshVehsList();
            }
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
                    foreach (Vehicle v in hub.GetVehs())
                        if (hub.IsAvailable(v.LicPlt))
                            DisplayVeh(v);
                    break;
                case 2: // Non available vehicles
                    foreach (Vehicle v in hub.GetVehs())
                        if (!hub.IsAvailable(v.LicPlt))
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

        #endregion
    }
}
