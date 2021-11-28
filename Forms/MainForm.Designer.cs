
namespace TransportationHub.Forms
{
    partial class MainForm
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
            this.AllRidesToFileButton = new System.Windows.Forms.Button();
            this.PresentVehicleDataButtonToFile = new System.Windows.Forms.Button();
            this.InfoAboutRides = new System.Windows.Forms.Button();
            this.ReserveRideButton = new System.Windows.Forms.Button();
            this.ModifyVehicleButton = new System.Windows.Forms.Button();
            this.AddNewVehicleButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OutTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            this.PresidentVehicalDataButtonFromFile = new System.Windows.Forms.Button();
            this.InfoAboutRidesFromFileButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllRidesToFileButton
            // 
            this.AllRidesToFileButton.Location = new System.Drawing.Point(759, 370);
            this.AllRidesToFileButton.Name = "AllRidesToFileButton";
            this.AllRidesToFileButton.Size = new System.Drawing.Size(127, 69);
            this.AllRidesToFileButton.TabIndex = 21;
            this.AllRidesToFileButton.Text = "Persist ride data to file";
            this.AllRidesToFileButton.UseVisualStyleBackColor = true;
            this.AllRidesToFileButton.Click += new System.EventHandler(this.AllRidesToFileButton_Click);
            // 
            // PresentVehicleDataButtonToFile
            // 
            this.PresentVehicleDataButtonToFile.Location = new System.Drawing.Point(903, 221);
            this.PresentVehicleDataButtonToFile.Name = "PresentVehicleDataButtonToFile";
            this.PresentVehicleDataButtonToFile.Size = new System.Drawing.Size(127, 69);
            this.PresentVehicleDataButtonToFile.TabIndex = 20;
            this.PresentVehicleDataButtonToFile.Text = "Vehicle Data To File";
            this.PresentVehicleDataButtonToFile.UseVisualStyleBackColor = true;
            this.PresentVehicleDataButtonToFile.Click += new System.EventHandler(this.PresentVehicleDataButtonToFile_Click);
            // 
            // InfoAboutRides
            // 
            this.InfoAboutRides.Location = new System.Drawing.Point(903, 370);
            this.InfoAboutRides.Name = "InfoAboutRides";
            this.InfoAboutRides.Size = new System.Drawing.Size(127, 69);
            this.InfoAboutRides.TabIndex = 19;
            this.InfoAboutRides.Text = "Rides Overview (must have completed rides)\r\n";
            this.InfoAboutRides.UseVisualStyleBackColor = true;
            this.InfoAboutRides.Click += new System.EventHandler(this.InfoAboutRides_Click);
            // 
            // ReserveRideButton
            // 
            this.ReserveRideButton.Location = new System.Drawing.Point(1050, 83);
            this.ReserveRideButton.Name = "ReserveRideButton";
            this.ReserveRideButton.Size = new System.Drawing.Size(127, 69);
            this.ReserveRideButton.TabIndex = 17;
            this.ReserveRideButton.Text = "Reserve Ride";
            this.ReserveRideButton.UseVisualStyleBackColor = true;
            this.ReserveRideButton.Click += new System.EventHandler(this.ReserveRideButton_Click);
            // 
            // ModifyVehicleButton
            // 
            this.ModifyVehicleButton.Location = new System.Drawing.Point(903, 83);
            this.ModifyVehicleButton.Name = "ModifyVehicleButton";
            this.ModifyVehicleButton.Size = new System.Drawing.Size(127, 69);
            this.ModifyVehicleButton.TabIndex = 16;
            this.ModifyVehicleButton.Text = "Modify Vehicle";
            this.ModifyVehicleButton.UseVisualStyleBackColor = true;
            this.ModifyVehicleButton.Click += new System.EventHandler(this.ModifyVehicleButton_Click);
            // 
            // AddNewVehicleButton
            // 
            this.AddNewVehicleButton.Location = new System.Drawing.Point(759, 83);
            this.AddNewVehicleButton.Name = "AddNewVehicleButton";
            this.AddNewVehicleButton.Size = new System.Drawing.Size(127, 69);
            this.AddNewVehicleButton.TabIndex = 15;
            this.AddNewVehicleButton.Text = "Create New Vehicle";
            this.AddNewVehicleButton.UseVisualStyleBackColor = true;
            this.AddNewVehicleButton.Click += new System.EventHandler(this.AddNewVehicleButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(489, 370);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OutTextBox
            // 
            this.OutTextBox.Location = new System.Drawing.Point(12, 83);
            this.OutTextBox.Multiline = true;
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutTextBox.Size = new System.Drawing.Size(715, 358);
            this.OutTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(401, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Borislav Stoyanov - Transportation Hub";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(1050, 370);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(127, 69);
            this.SortButton.TabIndex = 22;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // PresidentVehicalDataButtonFromFile
            // 
            this.PresidentVehicalDataButtonFromFile.Location = new System.Drawing.Point(759, 221);
            this.PresidentVehicalDataButtonFromFile.Name = "PresidentVehicalDataButtonFromFile";
            this.PresidentVehicalDataButtonFromFile.Size = new System.Drawing.Size(127, 69);
            this.PresidentVehicalDataButtonFromFile.TabIndex = 23;
            this.PresidentVehicalDataButtonFromFile.Text = "Vehicle Data From File";
            this.PresidentVehicalDataButtonFromFile.UseVisualStyleBackColor = true;
            this.PresidentVehicalDataButtonFromFile.Click += new System.EventHandler(this.PresidentVehicalDataButtonFromFile_Click);
            // 
            // InfoAboutRidesFromFileButton
            // 
            this.InfoAboutRidesFromFileButton.Location = new System.Drawing.Point(1050, 221);
            this.InfoAboutRidesFromFileButton.Name = "InfoAboutRidesFromFileButton";
            this.InfoAboutRidesFromFileButton.Size = new System.Drawing.Size(127, 69);
            this.InfoAboutRidesFromFileButton.TabIndex = 24;
            this.InfoAboutRidesFromFileButton.Text = "Persist ride data from file";
            this.InfoAboutRidesFromFileButton.UseVisualStyleBackColor = true;
            this.InfoAboutRidesFromFileButton.Click += new System.EventHandler(this.InfoAboutRidesFromFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1189, 497);
            this.Controls.Add(this.InfoAboutRidesFromFileButton);
            this.Controls.Add(this.PresidentVehicalDataButtonFromFile);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.AllRidesToFileButton);
            this.Controls.Add(this.PresentVehicleDataButtonToFile);
            this.Controls.Add(this.InfoAboutRides);
            this.Controls.Add(this.ReserveRideButton);
            this.Controls.Add(this.ModifyVehicleButton);
            this.Controls.Add(this.AddNewVehicleButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllRidesToFileButton;
        private System.Windows.Forms.Button PresentVehicleDataButtonToFile;
        private System.Windows.Forms.Button InfoAboutRides;
        private System.Windows.Forms.Button ReserveRideButton;
        private System.Windows.Forms.Button ModifyVehicleButton;
        private System.Windows.Forms.Button AddNewVehicleButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button PresidentVehicalDataButtonFromFile;
        private System.Windows.Forms.Button InfoAboutRidesFromFileButton;
    }
}