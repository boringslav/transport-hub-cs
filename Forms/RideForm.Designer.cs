
namespace TransportationHub.Forms
{
    partial class RideForm
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
            this.RideHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassangerHeader = new System.Windows.Forms.Label();
            this.FreighterHeader = new System.Windows.Forms.Label();
            this.AmountPassanger = new System.Windows.Forms.Label();
            this.AmountPassangerValue = new System.Windows.Forms.TextBox();
            this.VolumeValue = new System.Windows.Forms.TextBox();
            this.VolumeHeader = new System.Windows.Forms.Label();
            this.WeightValue = new System.Windows.Forms.TextBox();
            this.WeightHeader = new System.Windows.Forms.Label();
            this.StartPriceHeader = new System.Windows.Forms.Label();
            this.StartPriceValue = new System.Windows.Forms.TextBox();
            this.KilometresValue = new System.Windows.Forms.TextBox();
            this.KilometresHeader = new System.Windows.Forms.Label();
            this.VehiclesListBox = new System.Windows.Forms.ListBox();
            this.RegisterRide = new System.Windows.Forms.Button();
            this.EndTimeHeader = new System.Windows.Forms.Label();
            this.EndTimeValue = new System.Windows.Forms.NumericUpDown();
            this.FinishRideButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // RideHeader
            // 
            this.RideHeader.AutoSize = true;
            this.RideHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RideHeader.Location = new System.Drawing.Point(12, 9);
            this.RideHeader.Name = "RideHeader";
            this.RideHeader.Size = new System.Drawing.Size(109, 29);
            this.RideHeader.TabIndex = 0;
            this.RideHeader.Text = "Ride Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicles for passenger ride";
            // 
            // PassangerHeader
            // 
            this.PassangerHeader.AutoSize = true;
            this.PassangerHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassangerHeader.Location = new System.Drawing.Point(22, 70);
            this.PassangerHeader.Name = "PassangerHeader";
            this.PassangerHeader.Size = new System.Drawing.Size(134, 24);
            this.PassangerHeader.TabIndex = 2;
            this.PassangerHeader.Text = "For Passenger";
            // 
            // FreighterHeader
            // 
            this.FreighterHeader.AutoSize = true;
            this.FreighterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreighterHeader.Location = new System.Drawing.Point(238, 71);
            this.FreighterHeader.Name = "FreighterHeader";
            this.FreighterHeader.Size = new System.Drawing.Size(120, 24);
            this.FreighterHeader.TabIndex = 3;
            this.FreighterHeader.Text = "For Freighter";
            // 
            // AmountPassanger
            // 
            this.AmountPassanger.AutoSize = true;
            this.AmountPassanger.Location = new System.Drawing.Point(23, 109);
            this.AmountPassanger.Name = "AmountPassanger";
            this.AmountPassanger.Size = new System.Drawing.Size(119, 17);
            this.AmountPassanger.TabIndex = 4;
            this.AmountPassanger.Text = "Amount of people";
            // 
            // AmountPassangerValue
            // 
            this.AmountPassangerValue.Location = new System.Drawing.Point(26, 139);
            this.AmountPassangerValue.Multiline = true;
            this.AmountPassangerValue.Name = "AmountPassangerValue";
            this.AmountPassangerValue.Size = new System.Drawing.Size(130, 22);
            this.AmountPassangerValue.TabIndex = 5;
            this.AmountPassangerValue.TextChanged += new System.EventHandler(this.AmountPassangerValue_TextChanged);
            // 
            // VolumeValue
            // 
            this.VolumeValue.Location = new System.Drawing.Point(242, 140);
            this.VolumeValue.Multiline = true;
            this.VolumeValue.Name = "VolumeValue";
            this.VolumeValue.Size = new System.Drawing.Size(130, 22);
            this.VolumeValue.TabIndex = 7;
            this.VolumeValue.TextChanged += new System.EventHandler(this.VolumeValue_TextChanged);
            // 
            // VolumeHeader
            // 
            this.VolumeHeader.AutoSize = true;
            this.VolumeHeader.Location = new System.Drawing.Point(239, 110);
            this.VolumeHeader.Name = "VolumeHeader";
            this.VolumeHeader.Size = new System.Drawing.Size(173, 17);
            this.VolumeHeader.TabIndex = 6;
            this.VolumeHeader.Text = "Volume of the cargo in m3";
            // 
            // WeightValue
            // 
            this.WeightValue.Location = new System.Drawing.Point(242, 202);
            this.WeightValue.Multiline = true;
            this.WeightValue.Name = "WeightValue";
            this.WeightValue.Size = new System.Drawing.Size(130, 22);
            this.WeightValue.TabIndex = 9;
            this.WeightValue.TextChanged += new System.EventHandler(this.WeightValue_TextChanged);
            // 
            // WeightHeader
            // 
            this.WeightHeader.AutoSize = true;
            this.WeightHeader.Location = new System.Drawing.Point(239, 172);
            this.WeightHeader.Name = "WeightHeader";
            this.WeightHeader.Size = new System.Drawing.Size(166, 17);
            this.WeightHeader.TabIndex = 8;
            this.WeightHeader.Text = "Weight of the cargo in kg";
            // 
            // StartPriceHeader
            // 
            this.StartPriceHeader.AutoSize = true;
            this.StartPriceHeader.Location = new System.Drawing.Point(23, 402);
            this.StartPriceHeader.Name = "StartPriceHeader";
            this.StartPriceHeader.Size = new System.Drawing.Size(92, 17);
            this.StartPriceHeader.TabIndex = 10;
            this.StartPriceHeader.Text = "Starting price";
            // 
            // StartPriceValue
            // 
            this.StartPriceValue.Location = new System.Drawing.Point(26, 428);
            this.StartPriceValue.Multiline = true;
            this.StartPriceValue.Name = "StartPriceValue";
            this.StartPriceValue.Size = new System.Drawing.Size(130, 22);
            this.StartPriceValue.TabIndex = 11;
            this.StartPriceValue.TextChanged += new System.EventHandler(this.StartPriceValue_TextChanged);
            // 
            // KilometresValue
            // 
            this.KilometresValue.Location = new System.Drawing.Point(27, 491);
            this.KilometresValue.Multiline = true;
            this.KilometresValue.Name = "KilometresValue";
            this.KilometresValue.Size = new System.Drawing.Size(130, 22);
            this.KilometresValue.TabIndex = 13;
            this.KilometresValue.TextChanged += new System.EventHandler(this.KilometresValue_TextChanged);
            // 
            // KilometresHeader
            // 
            this.KilometresHeader.AutoSize = true;
            this.KilometresHeader.Location = new System.Drawing.Point(24, 465);
            this.KilometresHeader.Name = "KilometresHeader";
            this.KilometresHeader.Size = new System.Drawing.Size(74, 17);
            this.KilometresHeader.TabIndex = 12;
            this.KilometresHeader.Text = "Kilometres";
            // 
            // VehiclesListBox
            // 
            this.VehiclesListBox.FormattingEnabled = true;
            this.VehiclesListBox.ItemHeight = 16;
            this.VehiclesListBox.Location = new System.Drawing.Point(26, 306);
            this.VehiclesListBox.Name = "VehiclesListBox";
            this.VehiclesListBox.ScrollAlwaysVisible = true;
            this.VehiclesListBox.Size = new System.Drawing.Size(141, 68);
            this.VehiclesListBox.TabIndex = 14;
            this.VehiclesListBox.SelectedIndexChanged += new System.EventHandler(this.VehiclesListBox_SelectedIndexChanged);
            // 
            // RegisterRide
            // 
            this.RegisterRide.BackColor = System.Drawing.Color.LightGreen;
            this.RegisterRide.Location = new System.Drawing.Point(245, 349);
            this.RegisterRide.Name = "RegisterRide";
            this.RegisterRide.Size = new System.Drawing.Size(127, 58);
            this.RegisterRide.TabIndex = 55;
            this.RegisterRide.Text = "Register ride";
            this.RegisterRide.UseVisualStyleBackColor = false;
            this.RegisterRide.Click += new System.EventHandler(this.RegisterRide_Click);
            // 
            // EndTimeHeader
            // 
            this.EndTimeHeader.AutoSize = true;
            this.EndTimeHeader.Location = new System.Drawing.Point(23, 205);
            this.EndTimeHeader.Name = "EndTimeHeader";
            this.EndTimeHeader.Size = new System.Drawing.Size(111, 17);
            this.EndTimeHeader.TabIndex = 56;
            this.EndTimeHeader.Text = "Minutes for road";
            // 
            // EndTimeValue
            // 
            this.EndTimeValue.Location = new System.Drawing.Point(26, 240);
            this.EndTimeValue.Maximum = new decimal(new int[] {
            2880,
            0,
            0,
            0});
            this.EndTimeValue.Name = "EndTimeValue";
            this.EndTimeValue.Size = new System.Drawing.Size(141, 22);
            this.EndTimeValue.TabIndex = 57;
            this.EndTimeValue.ValueChanged += new System.EventHandler(this.EndTimeValue_ValueChanged);
            // 
            // FinishRideButton
            // 
            this.FinishRideButton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.FinishRideButton.Location = new System.Drawing.Point(245, 428);
            this.FinishRideButton.Name = "FinishRideButton";
            this.FinishRideButton.Size = new System.Drawing.Size(127, 58);
            this.FinishRideButton.TabIndex = 58;
            this.FinishRideButton.Text = "Finish ride";
            this.FinishRideButton.UseVisualStyleBackColor = false;
            this.FinishRideButton.Click += new System.EventHandler(this.FinishRideButton_Click);
            // 
            // RideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(444, 535);
            this.Controls.Add(this.FinishRideButton);
            this.Controls.Add(this.EndTimeValue);
            this.Controls.Add(this.EndTimeHeader);
            this.Controls.Add(this.RegisterRide);
            this.Controls.Add(this.VehiclesListBox);
            this.Controls.Add(this.KilometresValue);
            this.Controls.Add(this.KilometresHeader);
            this.Controls.Add(this.StartPriceValue);
            this.Controls.Add(this.StartPriceHeader);
            this.Controls.Add(this.WeightValue);
            this.Controls.Add(this.WeightHeader);
            this.Controls.Add(this.VolumeValue);
            this.Controls.Add(this.VolumeHeader);
            this.Controls.Add(this.AmountPassangerValue);
            this.Controls.Add(this.AmountPassanger);
            this.Controls.Add(this.FreighterHeader);
            this.Controls.Add(this.PassangerHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RideHeader);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "RideForm";
            this.Text = "RideForm";
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RideHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PassangerHeader;
        private System.Windows.Forms.Label FreighterHeader;
        private System.Windows.Forms.Label AmountPassanger;
        private System.Windows.Forms.TextBox AmountPassangerValue;
        private System.Windows.Forms.TextBox VolumeValue;
        private System.Windows.Forms.Label VolumeHeader;
        private System.Windows.Forms.TextBox WeightValue;
        private System.Windows.Forms.Label WeightHeader;
        private System.Windows.Forms.Label StartPriceHeader;
        private System.Windows.Forms.TextBox StartPriceValue;
        private System.Windows.Forms.TextBox KilometresValue;
        private System.Windows.Forms.Label KilometresHeader;
        private System.Windows.Forms.ListBox VehiclesListBox;
        private System.Windows.Forms.Button RegisterRide;
        private System.Windows.Forms.Label EndTimeHeader;
        private System.Windows.Forms.NumericUpDown EndTimeValue;
        private System.Windows.Forms.Button FinishRideButton;
    }
}