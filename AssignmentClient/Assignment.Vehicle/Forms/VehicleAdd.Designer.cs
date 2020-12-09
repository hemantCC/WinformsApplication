
namespace Assignment.Vehicle.Forms
{
    partial class VehicleAdd
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxVehicleInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxFuelType = new System.Windows.Forms.ComboBox();
            this.comboBoxTransmissionType = new System.Windows.Forms.ComboBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.textBoxGrossVehicleMass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTankCapacity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEngineSize = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
            this.textBoxMaxPassengers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPlate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new Assignment.Base.Common.CustomControls.ModernFlatButton();
            this.radioButtonUtility = new System.Windows.Forms.RadioButton();
            this.radioButtonCargo = new System.Windows.Forms.RadioButton();
            this.radioButtonPassanger = new System.Windows.Forms.RadioButton();
            this.errorProviderVin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMaker = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderModel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderColor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPlate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMaxPassangers = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEngineSize = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTankcapacity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMileage = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxVehicleInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaxPassangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEngineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTankcapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMileage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVehicleInfo
            // 
            this.groupBoxVehicleInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVehicleInfo.Controls.Add(this.panel2);
            this.groupBoxVehicleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVehicleInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            this.groupBoxVehicleInfo.Size = new System.Drawing.Size(839, 438);
            this.groupBoxVehicleInfo.TabIndex = 0;
            this.groupBoxVehicleInfo.TabStop = false;
            this.groupBoxVehicleInfo.Text = "Vehicle Information";
            // 
            // comboBoxFuelType
            // 
            this.comboBoxFuelType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxFuelType.FormattingEnabled = true;
            this.comboBoxFuelType.Location = new System.Drawing.Point(553, 187);
            this.comboBoxFuelType.Name = "comboBoxFuelType";
            this.comboBoxFuelType.Size = new System.Drawing.Size(211, 24);
            this.comboBoxFuelType.TabIndex = 12;
            // 
            // comboBoxTransmissionType
            // 
            this.comboBoxTransmissionType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxTransmissionType.FormattingEnabled = true;
            this.comboBoxTransmissionType.Location = new System.Drawing.Point(553, 108);
            this.comboBoxTransmissionType.Name = "comboBoxTransmissionType";
            this.comboBoxTransmissionType.Size = new System.Drawing.Size(211, 24);
            this.comboBoxTransmissionType.TabIndex = 10;
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Location = new System.Drawing.Point(553, 67);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(211, 24);
            this.comboBoxCarType.TabIndex = 9;
            // 
            // textBoxGrossVehicleMass
            // 
            this.textBoxGrossVehicleMass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGrossVehicleMass.Enabled = false;
            this.textBoxGrossVehicleMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrossVehicleMass.Location = new System.Drawing.Point(553, 307);
            this.textBoxGrossVehicleMass.Name = "textBoxGrossVehicleMass";
            this.textBoxGrossVehicleMass.Size = new System.Drawing.Size(211, 24);
            this.textBoxGrossVehicleMass.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Gross Vehicle Mass";
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMileage.Location = new System.Drawing.Point(553, 267);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(211, 24);
            this.textBoxMileage.TabIndex = 14;
            this.textBoxMileage.TextChanged += new System.EventHandler(this.textBoxMileage_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mileage";
            // 
            // textBoxTankCapacity
            // 
            this.textBoxTankCapacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTankCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTankCapacity.Location = new System.Drawing.Point(553, 227);
            this.textBoxTankCapacity.Name = "textBoxTankCapacity";
            this.textBoxTankCapacity.Size = new System.Drawing.Size(211, 24);
            this.textBoxTankCapacity.TabIndex = 13;
            this.textBoxTankCapacity.TextChanged += new System.EventHandler(this.textBoxTankCapacity_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tank Capacity";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(473, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fuel Type";
            // 
            // textBoxEngineSize
            // 
            this.textBoxEngineSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEngineSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngineSize.Location = new System.Drawing.Point(553, 147);
            this.textBoxEngineSize.Name = "textBoxEngineSize";
            this.textBoxEngineSize.Size = new System.Drawing.Size(211, 24);
            this.textBoxEngineSize.TabIndex = 11;
            this.textBoxEngineSize.TextChanged += new System.EventHandler(this.textBoxEngineSize_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Engine Size";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(452, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Transmission";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(478, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Car Type";
            // 
            // checkBoxAvailable
            // 
            this.checkBoxAvailable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAvailable.AutoSize = true;
            this.checkBoxAvailable.Location = new System.Drawing.Point(145, 352);
            this.checkBoxAvailable.Name = "checkBoxAvailable";
            this.checkBoxAvailable.Size = new System.Drawing.Size(164, 21);
            this.checkBoxAvailable.TabIndex = 14;
            this.checkBoxAvailable.Text = "Available for requests";
            this.checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // textBoxMaxPassengers
            // 
            this.textBoxMaxPassengers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMaxPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxPassengers.Location = new System.Drawing.Point(145, 311);
            this.textBoxMaxPassengers.Name = "textBoxMaxPassengers";
            this.textBoxMaxPassengers.Size = new System.Drawing.Size(222, 24);
            this.textBoxMaxPassengers.TabIndex = 7;
            this.textBoxMaxPassengers.TextChanged += new System.EventHandler(this.textBoxMaxPassengers_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max Passenges";
            // 
            // textBoxPlate
            // 
            this.textBoxPlate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlate.Location = new System.Drawing.Point(145, 271);
            this.textBoxPlate.Name = "textBoxPlate";
            this.textBoxPlate.Size = new System.Drawing.Size(222, 24);
            this.textBoxPlate.TabIndex = 6;
            this.textBoxPlate.TextChanged += new System.EventHandler(this.textBoxPlate_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plate";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxColor.Location = new System.Drawing.Point(145, 231);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(222, 24);
            this.textBoxColor.TabIndex = 5;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(145, 189);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(222, 24);
            this.textBoxModel.TabIndex = 4;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model";
            // 
            // textBoxMaker
            // 
            this.textBoxMaker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaker.Location = new System.Drawing.Point(145, 151);
            this.textBoxMaker.Name = "textBoxMaker";
            this.textBoxMaker.Size = new System.Drawing.Size(222, 24);
            this.textBoxMaker.TabIndex = 3;
            this.textBoxMaker.TextChanged += new System.EventHandler(this.textBoxMaker_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maker";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYear.Location = new System.Drawing.Point(145, 112);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(222, 24);
            this.textBoxYear.TabIndex = 2;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year";
            // 
            // textBoxVin
            // 
            this.textBoxVin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVin.Location = new System.Drawing.Point(145, 71);
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(222, 24);
            this.textBoxVin.TabIndex = 1;
            this.textBoxVin.TextChanged += new System.EventHandler(this.textBoxVin_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIN";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.radioButtonUtility);
            this.panel1.Controls.Add(this.radioButtonCargo);
            this.panel1.Controls.Add(this.radioButtonPassanger);
            this.panel1.Location = new System.Drawing.Point(12, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 75);
            this.panel1.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonSave.Location = new System.Drawing.Point(648, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 31);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // radioButtonUtility
            // 
            this.radioButtonUtility.AutoSize = true;
            this.radioButtonUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonUtility.Location = new System.Drawing.Point(243, 32);
            this.radioButtonUtility.Name = "radioButtonUtility";
            this.radioButtonUtility.Size = new System.Drawing.Size(76, 19);
            this.radioButtonUtility.TabIndex = 18;
            this.radioButtonUtility.TabStop = true;
            this.radioButtonUtility.Text = "Utility Car";
            this.radioButtonUtility.UseVisualStyleBackColor = true;
            // 
            // radioButtonCargo
            // 
            this.radioButtonCargo.AutoSize = true;
            this.radioButtonCargo.Checked = true;
            this.radioButtonCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCargo.Location = new System.Drawing.Point(151, 31);
            this.radioButtonCargo.Name = "radioButtonCargo";
            this.radioButtonCargo.Size = new System.Drawing.Size(80, 19);
            this.radioButtonCargo.TabIndex = 17;
            this.radioButtonCargo.TabStop = true;
            this.radioButtonCargo.Text = "Cargo Car";
            this.radioButtonCargo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassanger
            // 
            this.radioButtonPassanger.AutoSize = true;
            this.radioButtonPassanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPassanger.Location = new System.Drawing.Point(27, 31);
            this.radioButtonPassanger.Name = "radioButtonPassanger";
            this.radioButtonPassanger.Size = new System.Drawing.Size(106, 19);
            this.radioButtonPassanger.TabIndex = 16;
            this.radioButtonPassanger.TabStop = true;
            this.radioButtonPassanger.Text = "Passanger Car";
            this.radioButtonPassanger.UseVisualStyleBackColor = true;
            // 
            // errorProviderVin
            // 
            this.errorProviderVin.ContainerControl = this;
            // 
            // errorProviderYear
            // 
            this.errorProviderYear.ContainerControl = this;
            // 
            // errorProviderMaker
            // 
            this.errorProviderMaker.ContainerControl = this;
            // 
            // errorProviderModel
            // 
            this.errorProviderModel.ContainerControl = this;
            // 
            // errorProviderColor
            // 
            this.errorProviderColor.ContainerControl = this;
            // 
            // errorProviderPlate
            // 
            this.errorProviderPlate.ContainerControl = this;
            // 
            // errorProviderMaxPassangers
            // 
            this.errorProviderMaxPassangers.ContainerControl = this;
            // 
            // errorProviderEngineSize
            // 
            this.errorProviderEngineSize.ContainerControl = this;
            // 
            // errorProviderTankcapacity
            // 
            this.errorProviderTankcapacity.ContainerControl = this;
            // 
            // errorProviderMileage
            // 
            this.errorProviderMileage.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.checkBoxAvailable);
            this.panel2.Controls.Add(this.comboBoxFuelType);
            this.panel2.Controls.Add(this.textBoxMaxPassengers);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxTransmissionType);
            this.panel2.Controls.Add(this.textBoxPlate);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxCarType);
            this.panel2.Controls.Add(this.textBoxColor);
            this.panel2.Controls.Add(this.textBoxEngineSize);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxGrossVehicleMass);
            this.panel2.Controls.Add(this.textBoxModel);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxMaker);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxMileage);
            this.panel2.Controls.Add(this.textBoxYear);
            this.panel2.Controls.Add(this.textBoxTankCapacity);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxVin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 416);
            this.panel2.TabIndex = 28;
            // 
            // VehicleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxVehicleInfo);
            this.Name = "VehicleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleAdd_FormClosing);
            this.groupBoxVehicleInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderVin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPlate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMaxPassangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEngineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTankcapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMileage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVehicleInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonUtility;
        private System.Windows.Forms.RadioButton radioButtonCargo;
        private System.Windows.Forms.RadioButton radioButtonPassanger;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFuelType;
        private System.Windows.Forms.ComboBox comboBoxTransmissionType;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.TextBox textBoxGrossVehicleMass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTankCapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEngineSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.TextBox textBoxMaxPassengers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label2;
        private Base.Common.CustomControls.ModernFlatButton buttonSave;
        private System.Windows.Forms.ErrorProvider errorProviderVin;
        private System.Windows.Forms.ErrorProvider errorProviderYear;
        private System.Windows.Forms.ErrorProvider errorProviderMaker;
        private System.Windows.Forms.ErrorProvider errorProviderModel;
        private System.Windows.Forms.ErrorProvider errorProviderColor;
        private System.Windows.Forms.ErrorProvider errorProviderPlate;
        private System.Windows.Forms.ErrorProvider errorProviderMaxPassangers;
        private System.Windows.Forms.ErrorProvider errorProviderEngineSize;
        private System.Windows.Forms.ErrorProvider errorProviderTankcapacity;
        private System.Windows.Forms.ErrorProvider errorProviderMileage;
        private System.Windows.Forms.Panel panel2;
    }
}