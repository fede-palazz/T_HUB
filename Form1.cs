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
            hub = new THubImpl();
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

            dashPnl.BringToFront();
            panel = "dash";


            hub.AddVeh(new Car("ABC", 2, 0.45, 5, "Audi a3 sportback"));
            hub.AddVeh(new Truck("DFG", 3, 0.45, 1267.45, 400.5, "Fiat panda"));
            hub.AddVeh(new Van("XYZ", 0.34, 0.56, 800.2, 400, 8, "Pongo"));

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
            foreach 
        }

        private void LoadVehs()
        {

        }

        #endregion


    }
}
