namespace TransportForm
{
    partial class AddTransportForm
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
            this.Transport = new System.Windows.Forms.GroupBox();
            this.TypeHybrid = new System.Windows.Forms.GroupBox();
            this.TypeCar = new System.Windows.Forms.GroupBox();
            this.TypeHelicopter = new System.Windows.Forms.GroupBox();
            this.FuelHelicopter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VolumeOfTheTank = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FuelConsumptionPer100km = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PowerOfBatteryHybrid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ElectricityConsumptionPer = new System.Windows.Forms.Label();
            this.Per100km = new System.Windows.Forms.Label();
            this.ElectricityHybrid = new System.Windows.Forms.TextBox();
            this.FuelHybrid = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.TransportType = new System.Windows.Forms.GroupBox();
            this.Helicopter = new System.Windows.Forms.RadioButton();
            this.Hybrid = new System.Windows.Forms.RadioButton();
            this.Car = new System.Windows.Forms.RadioButton();
            this.dist = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.Label();
            this.DateOfManufacture = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.Label();
            this.Transport.SuspendLayout();
            this.TypeHybrid.SuspendLayout();
            this.TypeCar.SuspendLayout();
            this.TypeHelicopter.SuspendLayout();
            this.TransportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transport
            // 
            this.Transport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Transport.Controls.Add(this.TypeCar);
            this.Transport.Controls.Add(this.TypeHybrid);
            this.Transport.Controls.Add(this.TransportType);
            this.Transport.Controls.Add(this.dist);
            this.Transport.Controls.Add(this.date);
            this.Transport.Controls.Add(this.model);
            this.Transport.Controls.Add(this.Distance);
            this.Transport.Controls.Add(this.DateOfManufacture);
            this.Transport.Controls.Add(this.ModelName);
            this.Transport.Location = new System.Drawing.Point(12, 12);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(609, 319);
            this.Transport.TabIndex = 0;
            this.Transport.TabStop = false;
            this.Transport.Text = "Transport";
            // 
            // TypeHybrid
            // 
            this.TypeHybrid.Controls.Add(this.PowerOfBatteryHybrid);
            this.TypeHybrid.Controls.Add(this.label1);
            this.TypeHybrid.Controls.Add(this.ElectricityConsumptionPer);
            this.TypeHybrid.Controls.Add(this.Per100km);
            this.TypeHybrid.Controls.Add(this.ElectricityHybrid);
            this.TypeHybrid.Controls.Add(this.FuelHybrid);
            this.TypeHybrid.Location = new System.Drawing.Point(6, 159);
            this.TypeHybrid.Name = "TypeHybrid";
            this.TypeHybrid.Size = new System.Drawing.Size(294, 99);
            this.TypeHybrid.TabIndex = 9;
            this.TypeHybrid.TabStop = false;
            this.TypeHybrid.Text = "TypeHybrid";
            // 
            // TypeCar
            // 
            this.TypeCar.Controls.Add(this.VolumeOfTheTank);
            this.TypeCar.Controls.Add(this.TypeHelicopter);
            this.TypeCar.Controls.Add(this.textBox2);
            this.TypeCar.Controls.Add(this.FuelConsumptionPer100km);
            this.TypeCar.Controls.Add(this.textBox1);
            this.TypeCar.Location = new System.Drawing.Point(5, 159);
            this.TypeCar.Name = "TypeCar";
            this.TypeCar.Size = new System.Drawing.Size(294, 99);
            this.TypeCar.TabIndex = 8;
            this.TypeCar.TabStop = false;
            this.TypeCar.Text = "TypeCar";
            // 
            // TypeHelicopter
            // 
            this.TypeHelicopter.Controls.Add(this.FuelHelicopter);
            this.TypeHelicopter.Controls.Add(this.label3);
            this.TypeHelicopter.Location = new System.Drawing.Point(0, 0);
            this.TypeHelicopter.Name = "TypeHelicopter";
            this.TypeHelicopter.Size = new System.Drawing.Size(294, 99);
            this.TypeHelicopter.TabIndex = 10;
            this.TypeHelicopter.TabStop = false;
            this.TypeHelicopter.Text = "TypeHelicopter";
            // 
            // FuelHelicopter
            // 
            this.FuelHelicopter.Location = new System.Drawing.Point(154, 22);
            this.FuelHelicopter.Name = "FuelHelicopter";
            this.FuelHelicopter.Size = new System.Drawing.Size(82, 20);
            this.FuelHelicopter.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FuelConsumptionPer100km";
            // 
            // VolumeOfTheTank
            // 
            this.VolumeOfTheTank.AutoSize = true;
            this.VolumeOfTheTank.Location = new System.Drawing.Point(11, 41);
            this.VolumeOfTheTank.Name = "VolumeOfTheTank";
            this.VolumeOfTheTank.Size = new System.Drawing.Size(97, 13);
            this.VolumeOfTheTank.TabIndex = 3;
            this.VolumeOfTheTank.Text = "VolumeOfTheTank";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // FuelConsumptionPer100km
            // 
            this.FuelConsumptionPer100km.AutoSize = true;
            this.FuelConsumptionPer100km.Location = new System.Drawing.Point(11, 22);
            this.FuelConsumptionPer100km.Name = "FuelConsumptionPer100km";
            this.FuelConsumptionPer100km.Size = new System.Drawing.Size(136, 13);
            this.FuelConsumptionPer100km.TabIndex = 1;
            this.FuelConsumptionPer100km.Text = "FuelConsumptionPer100km";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // PowerOfBatteryHybrid
            // 
            this.PowerOfBatteryHybrid.Location = new System.Drawing.Point(153, 66);
            this.PowerOfBatteryHybrid.Name = "PowerOfBatteryHybrid";
            this.PowerOfBatteryHybrid.Size = new System.Drawing.Size(100, 20);
            this.PowerOfBatteryHybrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PowerOfBattery";
            // 
            // ElectricityConsumptionPer
            // 
            this.ElectricityConsumptionPer.AutoSize = true;
            this.ElectricityConsumptionPer.Location = new System.Drawing.Point(14, 38);
            this.ElectricityConsumptionPer.Name = "ElectricityConsumptionPer";
            this.ElectricityConsumptionPer.Size = new System.Drawing.Size(129, 13);
            this.ElectricityConsumptionPer.TabIndex = 3;
            this.ElectricityConsumptionPer.Text = "ElectricityConsumptionPer";
            // 
            // Per100km
            // 
            this.Per100km.AutoSize = true;
            this.Per100km.Location = new System.Drawing.Point(11, 19);
            this.Per100km.Name = "Per100km";
            this.Per100km.Size = new System.Drawing.Size(136, 13);
            this.Per100km.TabIndex = 2;
            this.Per100km.Text = "FuelConsumptionPer100km";
            // 
            // ElectricityHybrid
            // 
            this.ElectricityHybrid.Location = new System.Drawing.Point(153, 38);
            this.ElectricityHybrid.Name = "ElectricityHybrid";
            this.ElectricityHybrid.Size = new System.Drawing.Size(100, 20);
            this.ElectricityHybrid.TabIndex = 1;
            // 
            // FuelHybrid
            // 
            this.FuelHybrid.Location = new System.Drawing.Point(153, 12);
            this.FuelHybrid.Name = "FuelHybrid";
            this.FuelHybrid.Size = new System.Drawing.Size(100, 20);
            this.FuelHybrid.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(124, 354);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OK.Location = new System.Drawing.Point(17, 354);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // TransportType
            // 
            this.TransportType.Controls.Add(this.Helicopter);
            this.TransportType.Controls.Add(this.Hybrid);
            this.TransportType.Controls.Add(this.Car);
            this.TransportType.Location = new System.Drawing.Point(20, 20);
            this.TransportType.Name = "TransportType";
            this.TransportType.Size = new System.Drawing.Size(143, 102);
            this.TransportType.TabIndex = 6;
            this.TransportType.TabStop = false;
            this.TransportType.Text = "Transport Type";
            // 
            // Helicopter
            // 
            this.Helicopter.AutoSize = true;
            this.Helicopter.Location = new System.Drawing.Point(6, 64);
            this.Helicopter.Name = "Helicopter";
            this.Helicopter.Size = new System.Drawing.Size(73, 17);
            this.Helicopter.TabIndex = 2;
            this.Helicopter.TabStop = true;
            this.Helicopter.Text = "Helicopter";
            this.Helicopter.UseVisualStyleBackColor = true;
            this.Helicopter.CheckedChanged += new System.EventHandler(this.Helicopter_CheckedChanged);
            // 
            // Hybrid
            // 
            this.Hybrid.AutoSize = true;
            this.Hybrid.Location = new System.Drawing.Point(6, 42);
            this.Hybrid.Name = "Hybrid";
            this.Hybrid.Size = new System.Drawing.Size(55, 17);
            this.Hybrid.TabIndex = 1;
            this.Hybrid.TabStop = true;
            this.Hybrid.Text = "Hybrid";
            this.Hybrid.UseVisualStyleBackColor = true;
            this.Hybrid.CheckedChanged += new System.EventHandler(this.Hybrid_CheckedChanged);
            // 
            // Car
            // 
            this.Car.AutoSize = true;
            this.Car.Location = new System.Drawing.Point(6, 19);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(41, 17);
            this.Car.TabIndex = 0;
            this.Car.Text = "Car";
            this.Car.UseVisualStyleBackColor = true;
            this.Car.CheckedChanged += new System.EventHandler(this.Car_CheckedChanged);
            // 
            // dist
            // 
            this.dist.Location = new System.Drawing.Point(294, 84);
            this.dist.Name = "dist";
            this.dist.Size = new System.Drawing.Size(84, 20);
            this.dist.TabIndex = 5;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(294, 56);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(84, 20);
            this.date.TabIndex = 4;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(294, 33);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(84, 20);
            this.model.TabIndex = 3;
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(187, 86);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(49, 13);
            this.Distance.TabIndex = 2;
            this.Distance.Text = "Distance";
            // 
            // DateOfManufacture
            // 
            this.DateOfManufacture.AutoSize = true;
            this.DateOfManufacture.Location = new System.Drawing.Point(187, 59);
            this.DateOfManufacture.Name = "DateOfManufacture";
            this.DateOfManufacture.Size = new System.Drawing.Size(101, 13);
            this.DateOfManufacture.TabIndex = 1;
            this.DateOfManufacture.Text = "DateOfManufacture";
            // 
            // ModelName
            // 
            this.ModelName.AutoSize = true;
            this.ModelName.Location = new System.Drawing.Point(187, 36);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(64, 13);
            this.ModelName.TabIndex = 0;
            this.ModelName.Text = "ModelName";
            // 
            // AddTransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 389);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "AddTransportForm";
            this.Text = "AddTransportForm";
            this.Transport.ResumeLayout(false);
            this.Transport.PerformLayout();
            this.TypeHybrid.ResumeLayout(false);
            this.TypeHybrid.PerformLayout();
            this.TypeCar.ResumeLayout(false);
            this.TypeCar.PerformLayout();
            this.TypeHelicopter.ResumeLayout(false);
            this.TypeHelicopter.PerformLayout();
            this.TransportType.ResumeLayout(false);
            this.TransportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Transport;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label DateOfManufacture;
        private System.Windows.Forms.Label ModelName;
        private System.Windows.Forms.GroupBox TransportType;
        private System.Windows.Forms.RadioButton Helicopter;
        private System.Windows.Forms.RadioButton Hybrid;
        private System.Windows.Forms.RadioButton Car;
        private System.Windows.Forms.TextBox dist;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox TypeCar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label VolumeOfTheTank;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label FuelConsumptionPer100km;
        private System.Windows.Forms.GroupBox TypeHybrid;
        private System.Windows.Forms.TextBox ElectricityHybrid;
        private System.Windows.Forms.TextBox FuelHybrid;
        private System.Windows.Forms.Label Per100km;
        private System.Windows.Forms.Label ElectricityConsumptionPer;
        private System.Windows.Forms.TextBox PowerOfBatteryHybrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TypeHelicopter;
        private System.Windows.Forms.TextBox FuelHelicopter;
        private System.Windows.Forms.Label label3;
    }
}