
namespace T_HUB
{
    partial class NewRide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlePnl = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.passRbt = new System.Windows.Forms.RadioButton();
            this.freightRbt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.startPrcTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kmTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startTmDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.endTmDtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPassTxb = new System.Windows.Forms.TextBox();
            this.passPnl = new System.Windows.Forms.Panel();
            this.freightPnl = new System.Windows.Forms.Panel();
            this.volTxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wgTxb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.vehsCmb = new System.Windows.Forms.ComboBox();
            this.titlePnl.SuspendLayout();
            this.passPnl.SuspendLayout();
            this.freightPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePnl
            // 
            this.titlePnl.BackColor = System.Drawing.SystemColors.Control;
            this.titlePnl.Controls.Add(this.titleLbl);
            this.titlePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePnl.Location = new System.Drawing.Point(0, 0);
            this.titlePnl.Margin = new System.Windows.Forms.Padding(0);
            this.titlePnl.Name = "titlePnl";
            this.titlePnl.Size = new System.Drawing.Size(587, 65);
            this.titlePnl.TabIndex = 2;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(29, 14);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(20, 5, 3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(150, 40);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "New Ride";
            // 
            // passRbt
            // 
            this.passRbt.AutoSize = true;
            this.passRbt.Checked = true;
            this.passRbt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passRbt.Location = new System.Drawing.Point(148, 245);
            this.passRbt.Name = "passRbt";
            this.passRbt.Size = new System.Drawing.Size(98, 25);
            this.passRbt.TabIndex = 3;
            this.passRbt.TabStop = true;
            this.passRbt.Text = "Passenger";
            this.passRbt.UseVisualStyleBackColor = true;
            this.passRbt.CheckedChanged += new System.EventHandler(this.passRbt_CheckedChanged);
            // 
            // freightRbt
            // 
            this.freightRbt.AutoSize = true;
            this.freightRbt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.freightRbt.Location = new System.Drawing.Point(318, 245);
            this.freightRbt.Name = "freightRbt";
            this.freightRbt.Size = new System.Drawing.Size(77, 25);
            this.freightRbt.TabIndex = 4;
            this.freightRbt.Text = "Freight";
            this.freightRbt.UseVisualStyleBackColor = true;
            this.freightRbt.CheckedChanged += new System.EventHandler(this.passRbt_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start price";
            // 
            // startPrcTxb
            // 
            this.startPrcTxb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startPrcTxb.Location = new System.Drawing.Point(115, 100);
            this.startPrcTxb.Name = "startPrcTxb";
            this.startPrcTxb.Size = new System.Drawing.Size(156, 27);
            this.startPrcTxb.TabIndex = 6;
            this.startPrcTxb.Text = "0.0";
            this.startPrcTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(318, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Km";
            // 
            // kmTxb
            // 
            this.kmTxb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kmTxb.Location = new System.Drawing.Point(396, 98);
            this.kmTxb.Name = "kmTxb";
            this.kmTxb.Size = new System.Drawing.Size(156, 27);
            this.kmTxb.TabIndex = 6;
            this.kmTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start time";
            // 
            // startTmDtp
            // 
            this.startTmDtp.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.startTmDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTmDtp.Location = new System.Drawing.Point(115, 171);
            this.startTmDtp.Name = "startTmDtp";
            this.startTmDtp.Size = new System.Drawing.Size(156, 25);
            this.startTmDtp.TabIndex = 7;
            this.startTmDtp.ValueChanged += new System.EventHandler(this.startTmDtp_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(319, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "End time";
            // 
            // endTmDtp
            // 
            this.endTmDtp.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.endTmDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTmDtp.Location = new System.Drawing.Point(396, 174);
            this.endTmDtp.Name = "endTmDtp";
            this.endTmDtp.Size = new System.Drawing.Size(156, 25);
            this.endTmDtp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ride type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Passengers";
            // 
            // numPassTxb
            // 
            this.numPassTxb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numPassTxb.Location = new System.Drawing.Point(115, 20);
            this.numPassTxb.Name = "numPassTxb";
            this.numPassTxb.Size = new System.Drawing.Size(156, 27);
            this.numPassTxb.TabIndex = 6;
            this.numPassTxb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPassTxb.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // passPnl
            // 
            this.passPnl.Controls.Add(this.numPassTxb);
            this.passPnl.Controls.Add(this.label6);
            this.passPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passPnl.Location = new System.Drawing.Point(0, 0);
            this.passPnl.Name = "passPnl";
            this.passPnl.Size = new System.Drawing.Size(587, 86);
            this.passPnl.TabIndex = 8;
            // 
            // freightPnl
            // 
            this.freightPnl.Controls.Add(this.volTxb);
            this.freightPnl.Controls.Add(this.label8);
            this.freightPnl.Controls.Add(this.wgTxb);
            this.freightPnl.Controls.Add(this.label7);
            this.freightPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freightPnl.Location = new System.Drawing.Point(0, 0);
            this.freightPnl.Name = "freightPnl";
            this.freightPnl.Size = new System.Drawing.Size(587, 86);
            this.freightPnl.TabIndex = 9;
            this.freightPnl.Visible = false;
            // 
            // volTxb
            // 
            this.volTxb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volTxb.Location = new System.Drawing.Point(396, 23);
            this.volTxb.Name = "volTxb";
            this.volTxb.Size = new System.Drawing.Size(156, 27);
            this.volTxb.TabIndex = 6;
            this.volTxb.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(319, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 42);
            this.label8.TabIndex = 5;
            this.label8.Text = "Volume\r\n (m^3)";
            // 
            // wgTxb
            // 
            this.wgTxb.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wgTxb.Location = new System.Drawing.Point(115, 23);
            this.wgTxb.Name = "wgTxb";
            this.wgTxb.Size = new System.Drawing.Size(156, 27);
            this.wgTxb.TabIndex = 6;
            this.wgTxb.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 42);
            this.label7.TabIndex = 5;
            this.label7.Text = "Weigth\r\n  (Kg)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.freightPnl);
            this.panel1.Controls.Add(this.passPnl);
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 86);
            this.panel1.TabIndex = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Location = new System.Drawing.Point(186, 459);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 36);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancBtn
            // 
            this.cancBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancBtn.Location = new System.Drawing.Point(319, 459);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(85, 36);
            this.cancBtn.TabIndex = 11;
            this.cancBtn.Text = "Cancel";
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(34, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Vehicle";
            // 
            // vehsCmb
            // 
            this.vehsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehsCmb.FormattingEnabled = true;
            this.vehsCmb.Location = new System.Drawing.Point(115, 393);
            this.vehsCmb.Name = "vehsCmb";
            this.vehsCmb.Size = new System.Drawing.Size(156, 25);
            this.vehsCmb.TabIndex = 12;
            this.vehsCmb.DropDown += new System.EventHandler(this.vehsCmb_DropDown);
            // 
            // NewRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 516);
            this.Controls.Add(this.vehsCmb);
            this.Controls.Add(this.cancBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.endTmDtp);
            this.Controls.Add(this.startTmDtp);
            this.Controls.Add(this.kmTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startPrcTxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.freightRbt);
            this.Controls.Add(this.passRbt);
            this.Controls.Add(this.titlePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewRide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewRidecs";
            this.Load += new System.EventHandler(this.NewRidecs_Load);
            this.titlePnl.ResumeLayout(false);
            this.titlePnl.PerformLayout();
            this.passPnl.ResumeLayout(false);
            this.passPnl.PerformLayout();
            this.freightPnl.ResumeLayout(false);
            this.freightPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePnl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.RadioButton passRbt;
        private System.Windows.Forms.RadioButton freightRbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startPrcTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kmTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startTmDtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker endTmDtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numPassTxb;
        private System.Windows.Forms.Panel passPnl;
        private System.Windows.Forms.Panel freightPnl;
        private System.Windows.Forms.TextBox volTxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wgTxb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox vehsCmb;
    }
}