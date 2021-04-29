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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            titlePnl.BackColor = ColorTranslator.FromHtml("#263238");
            titleLbl.ForeColor = ColorTranslator.FromHtml("#eceff1");
            navBarPnl.BackColor = ColorTranslator.FromHtml("#263238");
        }

        private void navHomePtb_MouseEnter(object sender, EventArgs e)
        {
            navHomePtb.Image = T_HUB.Properties.Resources.navbar_dash_sel;
        }

        private void navHomePtb_MouseLeave(object sender, EventArgs e)
        {
            navHomePtb.Image = T_HUB.Properties.Resources.navbar_dash_unsel;
        }

        private void navVehsPtb_MouseEnter(object sender, EventArgs e)
        {
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_sel;
        }

        private void navVehsPtb_MouseLeave(object sender, EventArgs e)
        {
            navVehsPtb.Image = T_HUB.Properties.Resources.navbar_vehs_unsel;
        }

        private void navRidesPtb_MouseEnter(object sender, EventArgs e)
        {
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_sel;
        }

        private void navRidesPtb_MouseLeave(object sender, EventArgs e)
        {
            navRidesPtb.Image = T_HUB.Properties.Resources.navbar_flag_unsel;
        }

        private void navExpPtb_MouseEnter(object sender, EventArgs e)
        {
            navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_sel;
        }

        private void navExpPtb_MouseLeave(object sender, EventArgs e)
        {
            navExpPtb.Image = T_HUB.Properties.Resources.navbar_export_unsel;
        }

        private void navHomePtb_Click(object sender, EventArgs e)
        {
            dashPnl.BringToFront();
            titleLbl.Text = "Dashboard";
        }

        private void navVehsPtb_Click(object sender, EventArgs e)
        {
            vehsPnl.BringToFront();
            titleLbl.Text = "Vehicles";
        }

        private void navRidesPtb_Click(object sender, EventArgs e)
        {
            ridesPnl.BringToFront();
            titleLbl.Text = "Rides";
        }

        private void navExpPtb_Click(object sender, EventArgs e)
        {
            exportPnl.BringToFront();
            titleLbl.Text = "Export";
        }
    }
}
