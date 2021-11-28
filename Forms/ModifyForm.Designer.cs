
namespace TransportationHub.Forms
{
    partial class ModifyForm
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
            this.ModifyVehicle = new System.Windows.Forms.Button();
            this.LicensePlateValue = new System.Windows.Forms.TextBox();
            this.LicensePlateHeader = new System.Windows.Forms.Label();
            this.MakeAndModelHeader = new System.Windows.Forms.Label();
            this.MakeAndModelValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyVehicle
            // 
            this.ModifyVehicle.BackColor = System.Drawing.Color.LightGreen;
            this.ModifyVehicle.Location = new System.Drawing.Point(35, 203);
            this.ModifyVehicle.Name = "ModifyVehicle";
            this.ModifyVehicle.Size = new System.Drawing.Size(127, 58);
            this.ModifyVehicle.TabIndex = 71;
            this.ModifyVehicle.Text = "Modify Vehicle";
            this.ModifyVehicle.UseVisualStyleBackColor = false;
            this.ModifyVehicle.Click += new System.EventHandler(this.ModifyVehicle_Click);
            // 
            // LicensePlateValue
            // 
            this.LicensePlateValue.Location = new System.Drawing.Point(35, 84);
            this.LicensePlateValue.Multiline = true;
            this.LicensePlateValue.Name = "LicensePlateValue";
            this.LicensePlateValue.Size = new System.Drawing.Size(131, 29);
            this.LicensePlateValue.TabIndex = 60;
            this.LicensePlateValue.TextChanged += new System.EventHandler(this.LicensePlateValue_TextChanged);
            // 
            // LicensePlateHeader
            // 
            this.LicensePlateHeader.AutoSize = true;
            this.LicensePlateHeader.Location = new System.Drawing.Point(32, 64);
            this.LicensePlateHeader.Name = "LicensePlateHeader";
            this.LicensePlateHeader.Size = new System.Drawing.Size(212, 17);
            this.LicensePlateHeader.TabIndex = 59;
            this.LicensePlateHeader.Text = "License Plate(to identify vehicle)";
            // 
            // MakeAndModelHeader
            // 
            this.MakeAndModelHeader.AutoSize = true;
            this.MakeAndModelHeader.Location = new System.Drawing.Point(32, 131);
            this.MakeAndModelHeader.Name = "MakeAndModelHeader";
            this.MakeAndModelHeader.Size = new System.Drawing.Size(112, 17);
            this.MakeAndModelHeader.TabIndex = 58;
            this.MakeAndModelHeader.Text = "Make and Model";
            // 
            // MakeAndModelValue
            // 
            this.MakeAndModelValue.Location = new System.Drawing.Point(35, 151);
            this.MakeAndModelValue.Multiline = true;
            this.MakeAndModelValue.Name = "MakeAndModelValue";
            this.MakeAndModelValue.Size = new System.Drawing.Size(131, 29);
            this.MakeAndModelValue.TabIndex = 57;
            this.MakeAndModelValue.TextChanged += new System.EventHandler(this.MakeAndModelValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "ModifyVehicles";
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(482, 446);
            this.Controls.Add(this.ModifyVehicle);
            this.Controls.Add(this.LicensePlateValue);
            this.Controls.Add(this.LicensePlateHeader);
            this.Controls.Add(this.MakeAndModelHeader);
            this.Controls.Add(this.MakeAndModelValue);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModifyVehicle;
        private System.Windows.Forms.TextBox LicensePlateValue;
        private System.Windows.Forms.Label LicensePlateHeader;
        private System.Windows.Forms.Label MakeAndModelHeader;
        private System.Windows.Forms.TextBox MakeAndModelValue;
        private System.Windows.Forms.Label label1;
    }
}