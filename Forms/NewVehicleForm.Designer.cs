
namespace TransportationHub.Forms
{
    partial class NewVehicleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.VehicleTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CarRadioButton = new System.Windows.Forms.RadioButton();
            this.VanRadioButton = new System.Windows.Forms.RadioButton();
            this.TruckRadioButton = new System.Windows.Forms.RadioButton();
            this.MakeAndModelValue = new System.Windows.Forms.TextBox();
            this.MakeAndModelHeader = new System.Windows.Forms.Label();
            this.LicensePlateHeader = new System.Windows.Forms.Label();
            this.LicensePlateValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GasPerKmValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxPassangersValue = new System.Windows.Forms.NumericUpDown();
            this.MaxPassangersHeader = new System.Windows.Forms.Label();
            this.MaxWeightValue = new System.Windows.Forms.NumericUpDown();
            this.MaxWeightHeader = new System.Windows.Forms.Label();
            this.FreighterHeader = new System.Windows.Forms.Label();
            this.MaxVolumeValue = new System.Windows.Forms.NumericUpDown();
            this.MaxVolumeHeader = new System.Windows.Forms.Label();
            this.AddVehicleButton = new System.Windows.Forms.Button();
            this.VehicleTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GasPerKmValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPassangersValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVolumeValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VehicleHeader";
            // 
            // VehicleTypeGroupBox
            // 
            this.VehicleTypeGroupBox.Controls.Add(this.CarRadioButton);
            this.VehicleTypeGroupBox.Controls.Add(this.VanRadioButton);
            this.VehicleTypeGroupBox.Controls.Add(this.TruckRadioButton);
            this.VehicleTypeGroupBox.Location = new System.Drawing.Point(44, 67);
            this.VehicleTypeGroupBox.Name = "VehicleTypeGroupBox";
            this.VehicleTypeGroupBox.Size = new System.Drawing.Size(116, 125);
            this.VehicleTypeGroupBox.TabIndex = 1;
            this.VehicleTypeGroupBox.TabStop = false;
            this.VehicleTypeGroupBox.Text = "Vehicle type";
            // 
            // CarRadioButton
            // 
            this.CarRadioButton.AutoSize = true;
            this.CarRadioButton.Location = new System.Drawing.Point(18, 80);
            this.CarRadioButton.Name = "CarRadioButton";
            this.CarRadioButton.Size = new System.Drawing.Size(51, 21);
            this.CarRadioButton.TabIndex = 3;
            this.CarRadioButton.TabStop = true;
            this.CarRadioButton.Text = "Car";
            this.CarRadioButton.UseVisualStyleBackColor = true;
            this.CarRadioButton.CheckedChanged += new System.EventHandler(this.TypeRadioButtons_CheckedChanged);
            // 
            // VanRadioButton
            // 
            this.VanRadioButton.AutoSize = true;
            this.VanRadioButton.Location = new System.Drawing.Point(18, 53);
            this.VanRadioButton.Name = "VanRadioButton";
            this.VanRadioButton.Size = new System.Drawing.Size(54, 21);
            this.VanRadioButton.TabIndex = 2;
            this.VanRadioButton.TabStop = true;
            this.VanRadioButton.Text = "Van";
            this.VanRadioButton.UseVisualStyleBackColor = true;
            this.VanRadioButton.CheckedChanged += new System.EventHandler(this.TypeRadioButtons_CheckedChanged);
            // 
            // TruckRadioButton
            // 
            this.TruckRadioButton.AutoSize = true;
            this.TruckRadioButton.Location = new System.Drawing.Point(18, 29);
            this.TruckRadioButton.Name = "TruckRadioButton";
            this.TruckRadioButton.Size = new System.Drawing.Size(65, 21);
            this.TruckRadioButton.TabIndex = 1;
            this.TruckRadioButton.TabStop = true;
            this.TruckRadioButton.Text = "Truck";
            this.TruckRadioButton.UseVisualStyleBackColor = true;
            this.TruckRadioButton.CheckedChanged += new System.EventHandler(this.TypeRadioButtons_CheckedChanged);
            // 
            // MakeAndModelValue
            // 
            this.MakeAndModelValue.Location = new System.Drawing.Point(17, 229);
            this.MakeAndModelValue.Multiline = true;
            this.MakeAndModelValue.Name = "MakeAndModelValue";
            this.MakeAndModelValue.Size = new System.Drawing.Size(131, 29);
            this.MakeAndModelValue.TabIndex = 3;
            this.MakeAndModelValue.TextChanged += new System.EventHandler(this.MakeAndModelValue_TextChanged);
            // 
            // MakeAndModelHeader
            // 
            this.MakeAndModelHeader.AutoSize = true;
            this.MakeAndModelHeader.Location = new System.Drawing.Point(14, 209);
            this.MakeAndModelHeader.Name = "MakeAndModelHeader";
            this.MakeAndModelHeader.Size = new System.Drawing.Size(112, 17);
            this.MakeAndModelHeader.TabIndex = 4;
            this.MakeAndModelHeader.Text = "Make and Model";
            // 
            // LicensePlateHeader
            // 
            this.LicensePlateHeader.AutoSize = true;
            this.LicensePlateHeader.Location = new System.Drawing.Point(14, 277);
            this.LicensePlateHeader.Name = "LicensePlateHeader";
            this.LicensePlateHeader.Size = new System.Drawing.Size(92, 17);
            this.LicensePlateHeader.TabIndex = 5;
            this.LicensePlateHeader.Text = "License plate";
            // 
            // LicensePlateValue
            // 
            this.LicensePlateValue.Location = new System.Drawing.Point(17, 297);
            this.LicensePlateValue.Multiline = true;
            this.LicensePlateValue.Name = "LicensePlateValue";
            this.LicensePlateValue.Size = new System.Drawing.Size(131, 29);
            this.LicensePlateValue.TabIndex = 6;
            this.LicensePlateValue.TextChanged += new System.EventHandler(this.LicensePlateValue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gas usage litres per km";
            // 
            // GasPerKmValue
            // 
            this.GasPerKmValue.DecimalPlaces = 1;
            this.GasPerKmValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GasPerKmValue.Location = new System.Drawing.Point(17, 378);
            this.GasPerKmValue.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.GasPerKmValue.Name = "GasPerKmValue";
            this.GasPerKmValue.Size = new System.Drawing.Size(164, 22);
            this.GasPerKmValue.TabIndex = 45;
            this.GasPerKmValue.ValueChanged += new System.EventHandler(this.GasPerKmValue_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(264, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "For Passenger Vehicle";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MaxPassangersValue
            // 
            this.MaxPassangersValue.Location = new System.Drawing.Point(269, 120);
            this.MaxPassangersValue.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MaxPassangersValue.Name = "MaxPassangersValue";
            this.MaxPassangersValue.Size = new System.Drawing.Size(164, 22);
            this.MaxPassangersValue.TabIndex = 48;
            this.MaxPassangersValue.ValueChanged += new System.EventHandler(this.MaxPassangersValue_ValueChanged);
            // 
            // MaxPassangersHeader
            // 
            this.MaxPassangersHeader.AutoSize = true;
            this.MaxPassangersHeader.Location = new System.Drawing.Point(266, 100);
            this.MaxPassangersHeader.Name = "MaxPassangersHeader";
            this.MaxPassangersHeader.Size = new System.Drawing.Size(140, 21);
            this.MaxPassangersHeader.TabIndex = 47;
            this.MaxPassangersHeader.Text = "Max Passengers";
            // 
            // MaxWeightValue
            // 
            this.MaxWeightValue.DecimalPlaces = 1;
            this.MaxWeightValue.Location = new System.Drawing.Point(269, 244);
            this.MaxWeightValue.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.MaxWeightValue.Name = "MaxWeightValue";
            this.MaxWeightValue.Size = new System.Drawing.Size(164, 22);
            this.MaxWeightValue.TabIndex = 51;
            this.MaxWeightValue.ValueChanged += new System.EventHandler(this.MaxWeightValue_ValueChanged);
            // 
            // MaxWeightHeader
            // 
            this.MaxWeightHeader.AutoSize = true;
            this.MaxWeightHeader.Location = new System.Drawing.Point(266, 224);
            this.MaxWeightHeader.Name = "MaxWeightHeader";
            this.MaxWeightHeader.Size = new System.Drawing.Size(101, 21);
            this.MaxWeightHeader.TabIndex = 50;
            this.MaxWeightHeader.Text = "Max Weight";
            // 
            // FreighterHeader
            // 
            this.FreighterHeader.AutoSize = true;
            this.FreighterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreighterHeader.Location = new System.Drawing.Point(264, 191);
            this.FreighterHeader.Name = "FreighterHeader";
            this.FreighterHeader.Size = new System.Drawing.Size(193, 25);
            this.FreighterHeader.TabIndex = 49;
            this.FreighterHeader.Text = "For Freighter Vehicle";
            // 
            // MaxVolumeValue
            // 
            this.MaxVolumeValue.DecimalPlaces = 1;
            this.MaxVolumeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MaxVolumeValue.Location = new System.Drawing.Point(269, 297);
            this.MaxVolumeValue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MaxVolumeValue.Name = "MaxVolumeValue";
            this.MaxVolumeValue.Size = new System.Drawing.Size(164, 22);
            this.MaxVolumeValue.TabIndex = 53;
            this.MaxVolumeValue.ValueChanged += new System.EventHandler(this.MaxVolumeValue_ValueChanged);
            // 
            // MaxVolumeHeader
            // 
            this.MaxVolumeHeader.AutoSize = true;
            this.MaxVolumeHeader.Location = new System.Drawing.Point(266, 277);
            this.MaxVolumeHeader.Name = "MaxVolumeHeader";
            this.MaxVolumeHeader.Size = new System.Drawing.Size(105, 21);
            this.MaxVolumeHeader.TabIndex = 52;
            this.MaxVolumeHeader.Text = "Max Volume";
            // 
            // AddVehicleButton
            // 
            this.AddVehicleButton.BackColor = System.Drawing.Color.Aquamarine;
            this.AddVehicleButton.Location = new System.Drawing.Point(383, 378);
            this.AddVehicleButton.Name = "AddVehicleButton";
            this.AddVehicleButton.Size = new System.Drawing.Size(127, 58);
            this.AddVehicleButton.TabIndex = 54;
            this.AddVehicleButton.Text = "Add Vehicle";
            this.AddVehicleButton.UseVisualStyleBackColor = false;
            this.AddVehicleButton.Click += new System.EventHandler(this.AddVehicleButton_Click);
            // 
            // NewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(547, 474);
            this.Controls.Add(this.AddVehicleButton);
            this.Controls.Add(this.MaxVolumeValue);
            this.Controls.Add(this.MaxVolumeHeader);
            this.Controls.Add(this.MaxWeightValue);
            this.Controls.Add(this.MaxWeightHeader);
            this.Controls.Add(this.FreighterHeader);
            this.Controls.Add(this.MaxPassangersValue);
            this.Controls.Add(this.MaxPassangersHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GasPerKmValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LicensePlateValue);
            this.Controls.Add(this.LicensePlateHeader);
            this.Controls.Add(this.MakeAndModelHeader);
            this.Controls.Add(this.MakeAndModelValue);
            this.Controls.Add(this.VehicleTypeGroupBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "NewVehicleForm";
            this.Text = "NewVehicleForm";
            this.VehicleTypeGroupBox.ResumeLayout(false);
            this.VehicleTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GasPerKmValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPassangersValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxVolumeValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox VehicleTypeGroupBox;
        private System.Windows.Forms.RadioButton VanRadioButton;
        private System.Windows.Forms.RadioButton TruckRadioButton;
        private System.Windows.Forms.RadioButton CarRadioButton;
        private System.Windows.Forms.TextBox MakeAndModelValue;
        private System.Windows.Forms.Label MakeAndModelHeader;
        private System.Windows.Forms.Label LicensePlateHeader;
        private System.Windows.Forms.TextBox LicensePlateValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GasPerKmValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MaxPassangersValue;
        private System.Windows.Forms.Label MaxPassangersHeader;
        private System.Windows.Forms.NumericUpDown MaxWeightValue;
        private System.Windows.Forms.Label MaxWeightHeader;
        private System.Windows.Forms.Label FreighterHeader;
        private System.Windows.Forms.NumericUpDown MaxVolumeValue;
        private System.Windows.Forms.Label MaxVolumeHeader;
        private System.Windows.Forms.Button AddVehicleButton;
    }
}