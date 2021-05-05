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
    public partial class NewRide : Form
    {
        private THub hub;
        private bool added; // New ride added

        public NewRide()
        {
            InitializeComponent();
        }

        public NewRide(THub hub, bool added)
        {
            InitializeComponent();
            this.hub = hub;
            this.added = added;
        }

        private void NewRidecs_Load(object sender, EventArgs e)
        {
            titlePnl.BackColor = ColorTranslator.FromHtml("#263238");
            titleLbl.ForeColor = ColorTranslator.FromHtml("#eceff1");
        }

        private void passRbt_CheckedChanged(object sender, EventArgs e)
        {
            string name = ((RadioButton) sender).Name; // Selected radiobutton
            if (name == "passRbt")
            {
                passPnl.Visible = true;
                freightPnl.Visible = false;
            }
            else
            {
                passPnl.Visible = false;
                freightPnl.Visible = true;
            }
        }

        private void cancBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            #region Checks
            double temp;
            int temp2;

            if (!double.TryParse(startPrcTxb.Text, out temp))
            {
                ShowError("Start price");
                startPrcTxb.Focus();
                return;
            }
            if (!int.TryParse(kmTxb.Text, out temp2))
            {
                ShowError("Total Km");
                kmTxb.Focus();
                return;
            }
            if (endTmDtp.Value.Date < startTmDtp.Value.Date)
            {
                ShowError("End Time");
                endTmDtp.Focus();
                return;
            }
            if (vehsCmb.Items.Count == 0)
            {
                ShowError("Vehicle");
                return;
            }

            #endregion

            string type = vehsCmb.Text.Substring(1, vehsCmb.Text.LastIndexOf("]"));
            string licPlt = vehsCmb.Text.Substring(vehsCmb.Text.LastIndexOf("]") + 2);

            if (passRbt.Checked) // Passenger ride
            {
                hub.AddRide(new PassRide(type, licPlt, int.Parse(kmTxb.Text),
                    startTmDtp.Value.Date, endTmDtp.Value.Date, int.Parse(numPassTxb.Text),
                    double.Parse(startPrcTxb.Text)));
            }
            else // Freight ride
            {
                hub.AddRide(new FreightRide(type, licPlt, int.Parse(kmTxb.Text),
                    startTmDtp.Value.Date, endTmDtp.Value.Date, double.Parse(wgTxb.Text),
                    double.Parse(volTxb.Text), double.Parse(startPrcTxb.Text)));
            }
            added = true;
            this.Close();
        }

        private void startTmDtp_ValueChanged(object sender, EventArgs e)
        {
            endTmDtp.Value = startTmDtp.Value;
        }

        private void ShowError(string field)
        {
            MessageBox.Show(field + " field is empty or invalid", "Invalid field",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textChanged(object sender, EventArgs e)
        {
            vehsCmb.Items.Clear(); // Clears vehicles list

        }

        private void vehsCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void vehsCmb_DropDown(object sender, EventArgs e)
        {
            // Checks
            double temp;
            int temp2;

            if (passRbt.Checked && !int.TryParse(numPassTxb.Text, out temp2))
                return;
            if (freightRbt.Checked && !double.TryParse(wgTxb.Text, out temp)
                && !double.TryParse(volTxb.Text, out temp))
                return;

            foreach (Vehicle v in hub.GetVehs())
            {
                if (hub.IsAvailable(v.LicPlt)) // Vehicle available
                {
                    string type = hub.Type(v); // Vehicle type
                    switch (type)
                    {
                        case "car":
                            if (passRbt.Checked && (v as Car).MaxPass >= int.Parse(numPassTxb.Text))
                                vehsCmb.Items.Add("[" + type.ToUpper() + "] " + v.LicPlt);
                            break;
                        case "truck":
                            if (freightRbt.Checked && (v as Truck).MaxWg >= double.Parse(wgTxb.Text)
                                && (v as Truck).MaxVol >= double.Parse(volTxb.Text))
                                vehsCmb.Items.Add("[" + type.ToUpper() + "] " + v.LicPlt);
                            break;
                        case "van":
                            if (passRbt.Checked && (v as Van).MaxPass >= int.Parse(numPassTxb.Text))
                                vehsCmb.Items.Add("[" + type.ToUpper() + "] " + v.LicPlt);
                            else if (freightRbt.Checked && (v as Van).MaxWg >= double.Parse(wgTxb.Text)
                                && (v as Van).MaxVol >= double.Parse(volTxb.Text))
                                vehsCmb.Items.Add("[" + type.ToUpper() + "] " + v.LicPlt);
                            break;
                    }

                }
            }
        }
    }
}
