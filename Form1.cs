using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace T_HUB
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Global variable used to determine which panel is currently displayed
        /// Values : {"dash", "vehs", "rides", "export"}
        /// </summary>
        private string panel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            titlePnl.BackColor = ColorTranslator.FromHtml("#263238");
            titleLbl.ForeColor = ColorTranslator.FromHtml("#eceff1");
            navBarPnl.BackColor = ColorTranslator.FromHtml("#263238");
            dashPnl.BringToFront();
            panel = "dash";
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

        private void navExpPtb_MouseEnter(object sender, EventArgs e)
        {
            if (panel != "export")
                navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_sel;
        }

        private void navExpPtb_MouseLeave(object sender, EventArgs e)
        {
            if (panel != "export")
                navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_unsel;
        }

        private void navDashPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Dashboard";
            dashPnl.BringToFront();
            // Reset buttons selections
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
            navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_unsel;
            panel = "dash";
        }

        private void navVehsPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Vehicles";
            vehsPnl.BringToFront();
            // Reset buttons selections
            navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
            navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_unsel;
            panel = "vehs";
        }

        private void navRidesPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Rides";
            ridesPnl.BringToFront();
            // Reset buttons selections
            navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
            navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_unsel;
            panel = "rides";
        }

        private void navExpPtb_Click(object sender, EventArgs e)
        {
            titleLbl.Text = "Export";
            exportPnl.BringToFront();
            // Reset buttons selections
            navDashPtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
            panel = "export";
        }


        #endregion


    }
}
