using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using T_HUB.Controller;
using T_HUB.Model;

namespace T_HUB
{
    public partial class VehInfo : Form
    {
        /// <summary>
        /// True = add a new vehicle, False = update an existing vehicle 
        /// </summary>
        private bool newVeh = true;
        private THub hub;
        private string licPlt;

        public VehInfo()
        {
            InitializeComponent();
        }

        public VehInfo(THub hub)
        {
            InitializeComponent();
            newVeh = true;
            this.hub = hub;
        }

        public VehInfo(THub hub, string licPlt)
        {
            InitializeComponent();
            newVeh = false;
            this.hub = hub;
            this.licPlt = licPlt;
        }

        private void VehInfo_Load(object sender, EventArgs e)
        {
            #region Graphics
            // External band colors
            titlePnl.BackColor = ColorTranslator.FromHtml("#263238");
            titleLbl.ForeColor = ColorTranslator.FromHtml("#eceff1");
            //this.BackColor = ColorTranslator.FromHtml("#90a4ae");

            titleLbl.Text = newVeh ? titleLbl.Text = "Add Vehicle" : titleLbl.Text = "Update Vehicle";
            typeCmb.SelectedIndex = 0;
            licPltTxb.Focus();
            #endregion

            if (!newVeh) // Vehicle update
            {
                // Fill all fields
                Vehicle v = hub.GetVeh(licPlt);
                licPltTxb.Text = licPlt;
                modelTxb.Text = v.Mod;
                gasKmTxb.Text = v.GasKm.ToString();
                priceKmTxb.Text = v.PriceKm.ToString();
                totalKmTxb.Text = v.TotalKm.ToString();
                switch (hub.Type(v))
                {
                    case "car":
                        typeCmb.SelectedIndex = 0;
                        maxPassTxb.Text = (v as Car).MaxPass.ToString();
                        break;
                    case "truck":
                        typeCmb.SelectedIndex = 1;
                        maxWgTxb.Text = (v as Truck).MaxWg.ToString();
                        maxVolTxb.Text = (v as Truck).MaxVol.ToString();
                        break;
                    case "van":
                        typeCmb.SelectedIndex = 2;
                        maxPassTxb.Text = (v as Van).MaxPass.ToString();
                        maxWgTxb.Text = (v as Van).MaxWg.ToString();
                        maxVolTxb.Text = (v as Van).MaxVol.ToString();
                        break;
                }
                // Disables not editable components
                typeCmb.Enabled = false;
                licPltTxb.Enabled = false;
            }
        }

        private void typeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeCmb.SelectedIndex)
            {
                case 0:
                    maxPassTxb.Enabled = true;
                    maxWgTxb.Enabled = false;
                    maxVolTxb.Enabled = false;
                    break;
                case 1:
                    maxPassTxb.Enabled = false;
                    maxWgTxb.Enabled = true;
                    maxVolTxb.Enabled = true;
                    break;
                case 2:
                    maxPassTxb.Enabled = true;
                    maxWgTxb.Enabled = true;
                    maxVolTxb.Enabled = true;
                    break;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Vehicle v = null; // New or updated vehicle

            #region Fields check
            if (String.IsNullOrEmpty(licPltTxb.Text))
            {
                ShowError("License plate");
                licPltTxb.Focus();
                return;
            }
            double temp;
            if (!Double.TryParse(gasKmTxb.Text, out temp))
            {
                ShowError("Gas / Km");
                gasKmTxb.Focus();
                return;
            }
            if (!Double.TryParse(priceKmTxb.Text, out temp))
            {
                ShowError("Price / Km");
                priceKmTxb.Focus();
                return;
            }
            int temp2;

            if (!int.TryParse(totalKmTxb.Text, out temp2))
            {
                ShowError("Total Km");
                totalKmTxb.Focus();
                return;
            }
            
            switch (typeCmb.SelectedIndex)
            {
                case 0: // Car
                    if (!int.TryParse(maxPassTxb.Text, out temp2))
                    {
                        ShowError("Max Passengers");
                        maxPassTxb.Focus();
                        return;
                    }
                    v = new Car(licPltTxb.Text, double.Parse(gasKmTxb.Text), double.Parse(priceKmTxb.Text),
                        int.Parse(totalKmTxb.Text), int.Parse(maxPassTxb.Text), modelTxb.Text);
                    break;
                case 1: // Truck
                    if (!double.TryParse(maxWgTxb.Text, out temp))
                    {
                        ShowError("Max Weigth");
                        maxWgTxb.Focus();
                        return;
                    }
                    v = new Truck(licPltTxb.Text, double.Parse(gasKmTxb.Text), double.Parse(priceKmTxb.Text),
                        double.Parse(maxWgTxb.Text), int.Parse(totalKmTxb.Text), double.Parse(maxVolTxb.Text),
                        modelTxb.Text);
                    break;
                case 2: // Van
                    if (!double.TryParse(maxVolTxb.Text, out temp))
                    {
                        ShowError("Max Volume");
                        maxVolTxb.Focus();
                        return;
                    }
                    v = new Van(licPltTxb.Text, double.Parse(gasKmTxb.Text), double.Parse(priceKmTxb.Text),
                        int.Parse(totalKmTxb.Text), double.Parse(maxWgTxb.Text), double.Parse(maxVolTxb.Text),
                        int.Parse(maxPassTxb.Text), modelTxb.Text);
                    break;
            }
            #endregion

            if (newVeh) // Adds the vehicle
                hub.AddVeh(v);
            else // Updates the vehicle info
                hub.UpdVeh(licPlt, v);
            this.Close();
        }

        private void ShowError(string field)
        {
            MessageBox.Show(field + " field is empty or invalid", "Invalid field",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
