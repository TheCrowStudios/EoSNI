namespace EoSNI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPackageType;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.DateTimePicker dtpDispatchDate;
        private System.Windows.Forms.DateTimePicker dtpTargetDeliveryDate;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPackageType;
        private System.Windows.Forms.Label lblWeightPerPackage;
        private System.Windows.Forms.Label lblNumberOfPackages;
        private System.Windows.Forms.Label lblBaseCost;
        private System.Windows.Forms.Label lblDispatchDate;
        private System.Windows.Forms.Label lblTargetDeliveryDate;

        private void InitializeComponent()
        {
            txtCustomerName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtPackageType = new TextBox();
            lblTotalWeight = new Label();
            lblTotalCost = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            dtpDispatchDate = new DateTimePicker();
            dtpTargetDeliveryDate = new DateTimePicker();
            lblCustomerName = new Label();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            lblPackageType = new Label();
            lblWeightPerPackage = new Label();
            lblNumberOfPackages = new Label();
            lblBaseCost = new Label();
            lblDispatchDate = new Label();
            lblTargetDeliveryDate = new Label();
            label1 = new Label();
            numWeightPerPackage = new NumericUpDown();
            numNumberOfPackages = new NumericUpDown();
            numBaseCost = new NumericUpDown();
            numCostPerKg = new NumericUpDown();
            lblCostPerKg = new Label();
            numTotalWeight = new NumericUpDown();
            numTotalCost = new NumericUpDown();
            lblCity = new Label();
            txtCity = new TextBox();
            lblPostCode = new Label();
            txtPostCode = new TextBox();
            numVAT = new NumericUpDown();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numWeightPerPackage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumberOfPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBaseCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCostPerKg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numVAT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 109);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(240, 23);
            txtCustomerName.TabIndex = 0;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 152);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(240, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(12, 283);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(240, 23);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtPackageType
            // 
            txtPackageType.Location = new Point(12, 327);
            txtPackageType.Name = "txtPackageType";
            txtPackageType.Size = new Size(240, 23);
            txtPackageType.TabIndex = 5;
            // 
            // lblTotalWeight
            // 
            lblTotalWeight.AutoSize = true;
            lblTotalWeight.Location = new Point(466, 353);
            lblTotalWeight.Name = "lblTotalWeight";
            lblTotalWeight.Size = new Size(100, 15);
            lblTotalWeight.TabIndex = 7;
            lblTotalWeight.Text = "Total Weight (kg):";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(466, 397);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(62, 15);
            lblTotalCost.TabIndex = 8;
            lblTotalCost.Text = "Total Cost:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(260, 458);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(200, 30);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Show shipping details";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculateCost_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(466, 458);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 30);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(569, 458);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(97, 30);
            btnQuit.TabIndex = 15;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // dtpDispatchDate
            // 
            dtpDispatchDate.Location = new Point(260, 371);
            dtpDispatchDate.Name = "dtpDispatchDate";
            dtpDispatchDate.Size = new Size(200, 23);
            dtpDispatchDate.TabIndex = 8;
            // 
            // dtpTargetDeliveryDate
            // 
            dtpTargetDeliveryDate.Location = new Point(260, 415);
            dtpTargetDeliveryDate.Name = "dtpTargetDeliveryDate";
            dtpTargetDeliveryDate.Size = new Size(200, 23);
            dtpTargetDeliveryDate.TabIndex = 9;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(12, 91);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(97, 15);
            lblCustomerName.TabIndex = 15;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 134);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(12, 265);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 15);
            lblPhoneNumber.TabIndex = 17;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblPackageType
            // 
            lblPackageType.AutoSize = true;
            lblPackageType.Location = new Point(12, 309);
            lblPackageType.Name = "lblPackageType";
            lblPackageType.Size = new Size(81, 15);
            lblPackageType.TabIndex = 18;
            lblPackageType.Text = "Package Type:";
            // 
            // lblWeightPerPackage
            // 
            lblWeightPerPackage.AutoSize = true;
            lblWeightPerPackage.Location = new Point(12, 353);
            lblWeightPerPackage.Name = "lblWeightPerPackage";
            lblWeightPerPackage.Size = new Size(139, 15);
            lblWeightPerPackage.TabIndex = 19;
            lblWeightPerPackage.Text = "Weight Per Package (kg):";
            // 
            // lblNumberOfPackages
            // 
            lblNumberOfPackages.AutoSize = true;
            lblNumberOfPackages.Location = new Point(12, 397);
            lblNumberOfPackages.Name = "lblNumberOfPackages";
            lblNumberOfPackages.Size = new Size(120, 15);
            lblNumberOfPackages.TabIndex = 20;
            lblNumberOfPackages.Text = "Number of Packages:";
            // 
            // lblBaseCost
            // 
            lblBaseCost.AutoSize = true;
            lblBaseCost.Location = new Point(527, 135);
            lblBaseCost.Name = "lblBaseCost";
            lblBaseCost.Size = new Size(56, 15);
            lblBaseCost.TabIndex = 21;
            lblBaseCost.Text = "Base cost";
            // 
            // lblDispatchDate
            // 
            lblDispatchDate.AutoSize = true;
            lblDispatchDate.Location = new Point(260, 353);
            lblDispatchDate.Name = "lblDispatchDate";
            lblDispatchDate.Size = new Size(83, 15);
            lblDispatchDate.TabIndex = 22;
            lblDispatchDate.Text = "Dispatch Date:";
            // 
            // lblTargetDeliveryDate
            // 
            lblTargetDeliveryDate.AutoSize = true;
            lblTargetDeliveryDate.Location = new Point(260, 397);
            lblTargetDeliveryDate.Name = "lblTargetDeliveryDate";
            lblTargetDeliveryDate.Size = new Size(114, 15);
            lblTargetDeliveryDate.TabIndex = 23;
            lblTargetDeliveryDate.Text = "Target Delivery Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 91);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 25;
            label1.Text = "VAT:";
            // 
            // numWeightPerPackage
            // 
            numWeightPerPackage.DecimalPlaces = 3;
            numWeightPerPackage.Location = new Point(12, 371);
            numWeightPerPackage.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numWeightPerPackage.Name = "numWeightPerPackage";
            numWeightPerPackage.Size = new Size(240, 23);
            numWeightPerPackage.TabIndex = 6;
            numWeightPerPackage.ValueChanged += numWeightPerPackage_ValueChanged;
            // 
            // numNumberOfPackages
            // 
            numNumberOfPackages.Location = new Point(12, 415);
            numNumberOfPackages.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNumberOfPackages.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numNumberOfPackages.Name = "numNumberOfPackages";
            numNumberOfPackages.Size = new Size(240, 23);
            numNumberOfPackages.TabIndex = 7;
            numNumberOfPackages.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numNumberOfPackages.ValueChanged += numNumberOfPackages_ValueChanged;
            // 
            // numBaseCost
            // 
            numBaseCost.DecimalPlaces = 2;
            numBaseCost.Location = new Point(527, 153);
            numBaseCost.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numBaseCost.Name = "numBaseCost";
            numBaseCost.Size = new Size(136, 23);
            numBaseCost.TabIndex = 11;
            numBaseCost.ThousandsSeparator = true;
            numBaseCost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numBaseCost.ValueChanged += numBaseCost_ValueChanged;
            // 
            // numCostPerKg
            // 
            numCostPerKg.DecimalPlaces = 2;
            numCostPerKg.Location = new Point(527, 197);
            numCostPerKg.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCostPerKg.Name = "numCostPerKg";
            numCostPerKg.Size = new Size(136, 23);
            numCostPerKg.TabIndex = 12;
            numCostPerKg.ThousandsSeparator = true;
            numCostPerKg.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCostPerKg.ValueChanged += numCostPerKg_ValueChanged;
            // 
            // lblCostPerKg
            // 
            lblCostPerKg.AutoSize = true;
            lblCostPerKg.Location = new Point(528, 179);
            lblCostPerKg.Name = "lblCostPerKg";
            lblCostPerKg.Size = new Size(55, 15);
            lblCostPerKg.TabIndex = 31;
            lblCostPerKg.Text = "Cost / kg";
            // 
            // numTotalWeight
            // 
            numTotalWeight.DecimalPlaces = 2;
            numTotalWeight.Location = new Point(466, 371);
            numTotalWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTotalWeight.Name = "numTotalWeight";
            numTotalWeight.ReadOnly = true;
            numTotalWeight.Size = new Size(200, 23);
            numTotalWeight.TabIndex = 6;
            numTotalWeight.TabStop = false;
            numTotalWeight.ThousandsSeparator = true;
            // 
            // numTotalCost
            // 
            numTotalCost.DecimalPlaces = 2;
            numTotalCost.Location = new Point(466, 415);
            numTotalCost.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTotalCost.Name = "numTotalCost";
            numTotalCost.ReadOnly = true;
            numTotalCost.Size = new Size(200, 23);
            numTotalCost.TabIndex = 7;
            numTotalCost.TabStop = false;
            numTotalCost.ThousandsSeparator = true;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(12, 178);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 33;
            lblCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 196);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(240, 23);
            txtCity.TabIndex = 2;
            // 
            // lblPostCode
            // 
            lblPostCode.AutoSize = true;
            lblPostCode.Location = new Point(12, 222);
            lblPostCode.Name = "lblPostCode";
            lblPostCode.Size = new Size(62, 15);
            lblPostCode.TabIndex = 35;
            lblPostCode.Text = "Post code:";
            // 
            // txtPostCode
            // 
            txtPostCode.Location = new Point(12, 240);
            txtPostCode.Name = "txtPostCode";
            txtPostCode.Size = new Size(240, 23);
            txtPostCode.TabIndex = 3;
            // 
            // numVAT
            // 
            numVAT.Location = new Point(527, 109);
            numVAT.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numVAT.Name = "numVAT";
            numVAT.Size = new Size(136, 23);
            numVAT.TabIndex = 10;
            numVAT.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numVAT.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.eos_ni_high_resolution_logo_transparent;
            pictureBoxLogo.Location = new Point(260, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 36;
            pictureBoxLogo.TabStop = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(702, 500);
            Controls.Add(pictureBoxLogo);
            Controls.Add(numVAT);
            Controls.Add(lblPostCode);
            Controls.Add(txtPostCode);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Controls.Add(numTotalCost);
            Controls.Add(numTotalWeight);
            Controls.Add(lblCostPerKg);
            Controls.Add(numCostPerKg);
            Controls.Add(numBaseCost);
            Controls.Add(numNumberOfPackages);
            Controls.Add(numWeightPerPackage);
            Controls.Add(label1);
            Controls.Add(lblTargetDeliveryDate);
            Controls.Add(dtpTargetDeliveryDate);
            Controls.Add(lblDispatchDate);
            Controls.Add(dtpDispatchDate);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalCost);
            Controls.Add(lblTotalWeight);
            Controls.Add(lblBaseCost);
            Controls.Add(lblNumberOfPackages);
            Controls.Add(lblWeightPerPackage);
            Controls.Add(lblPackageType);
            Controls.Add(txtPackageType);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Name = "MainForm";
            Text = "EoS NI - Add delivery";
            ((System.ComponentModel.ISupportInitialize)numWeightPerPackage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumberOfPackages).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBaseCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCostPerKg).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numVAT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private NumericUpDown numWeightPerPackage;
        private NumericUpDown numNumberOfPackages;
        private NumericUpDown numBaseCost;
        private NumericUpDown numCostPerKg;
        private Label lblCostPerKg;
        private NumericUpDown numTotalWeight;
        private NumericUpDown numTotalCost;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblPostCode;
        private TextBox txtPostCode;
        private NumericUpDown numVAT;
        private PictureBox pictureBoxLogo;
    }
}