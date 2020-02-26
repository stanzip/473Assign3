namespace Assign3
{
    partial class Form1
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
            this.TypeRangeBox = new System.Windows.Forms.GroupBox();
            this.TypePriceBtn = new System.Windows.Forms.Button();
            this.MaxPriceLabel = new System.Windows.Forms.Label();
            this.MinPriceLabel = new System.Windows.Forms.Label();
            this.MinTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxTrackBar = new System.Windows.Forms.TrackBar();
            this.SchoolCheckBox = new System.Windows.Forms.CheckBox();
            this.BusCheckBox = new System.Windows.Forms.CheckBox();
            this.ResCheckBox = new System.Windows.Forms.CheckBox();
            this.SchoolRangeBox = new System.Windows.Forms.GroupBox();
            this.SchoolRangeBtn = new System.Windows.Forms.Button();
            this.SchoolRangeLbl = new System.Windows.Forms.Label();
            this.SchoolLabel = new System.Windows.Forms.Label();
            this.SchoolRangeUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectSchool = new System.Windows.Forms.ComboBox();
            this.BusDistanceBox = new System.Windows.Forms.GroupBox();
            this.HiringBusBtn = new System.Windows.Forms.Button();
            this.BusDistLbl = new System.Windows.Forms.Label();
            this.BusinessRangeLbl = new System.Windows.Forms.Label();
            this.BusDistUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectBusiness = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SqFeetLabel = new System.Windows.Forms.Label();
            this.BathsLabel = new System.Windows.Forms.Label();
            this.BedsLabel = new System.Windows.Forms.Label();
            this.ParameterSearchBtn = new System.Windows.Forms.Button();
            this.GarageTextBox = new System.Windows.Forms.CheckBox();
            this.BathsUpDown = new System.Windows.Forms.NumericUpDown();
            this.SqFeetUpDown = new System.Windows.Forms.NumericUpDown();
            this.BedsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ApartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.HouseCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LocalSearch = new System.Windows.Forms.Button();
            this.OutputArea = new System.Windows.Forms.RichTextBox();
            this.QueryResultsLabel = new System.Windows.Forms.Label();
            this.TypeRangeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).BeginInit();
            this.SchoolRangeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolRangeUpDown)).BeginInit();
            this.BusDistanceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusDistUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BathsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SqFeetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedsUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeRangeBox
            // 
            this.TypeRangeBox.Controls.Add(this.TypePriceBtn);
            this.TypeRangeBox.Controls.Add(this.MaxPriceLabel);
            this.TypeRangeBox.Controls.Add(this.MinPriceLabel);
            this.TypeRangeBox.Controls.Add(this.MinTrackBar);
            this.TypeRangeBox.Controls.Add(this.MaxTrackBar);
            this.TypeRangeBox.Controls.Add(this.SchoolCheckBox);
            this.TypeRangeBox.Controls.Add(this.BusCheckBox);
            this.TypeRangeBox.Controls.Add(this.ResCheckBox);
            this.TypeRangeBox.Location = new System.Drawing.Point(16, 15);
            this.TypeRangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeRangeBox.Name = "TypeRangeBox";
            this.TypeRangeBox.Padding = new System.Windows.Forms.Padding(4);
            this.TypeRangeBox.Size = new System.Drawing.Size(387, 192);
            this.TypeRangeBox.TabIndex = 0;
            this.TypeRangeBox.TabStop = false;
            this.TypeRangeBox.Text = "Type/Price Range";
            // 
            // TypePriceBtn
            // 
            this.TypePriceBtn.Location = new System.Drawing.Point(12, 156);
            this.TypePriceBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TypePriceBtn.Name = "TypePriceBtn";
            this.TypePriceBtn.Size = new System.Drawing.Size(100, 28);
            this.TypePriceBtn.TabIndex = 7;
            this.TypePriceBtn.Text = "Search";
            this.TypePriceBtn.UseVisualStyleBackColor = true;
            this.TypePriceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxPriceLabel
            // 
            this.MaxPriceLabel.AutoSize = true;
            this.MaxPriceLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MaxPriceLabel.Location = new System.Drawing.Point(201, 76);
            this.MaxPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaxPriceLabel.Name = "MaxPriceLabel";
            this.MaxPriceLabel.Size = new System.Drawing.Size(93, 17);
            this.MaxPriceLabel.TabIndex = 6;
            this.MaxPriceLabel.Text = "Max Price: $0";
            // 
            // MinPriceLabel
            // 
            this.MinPriceLabel.AutoSize = true;
            this.MinPriceLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.MinPriceLabel.Location = new System.Drawing.Point(8, 76);
            this.MinPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinPriceLabel.Name = "MinPriceLabel";
            this.MinPriceLabel.Size = new System.Drawing.Size(90, 17);
            this.MinPriceLabel.TabIndex = 5;
            this.MinPriceLabel.Text = "Min Price: $0";
            this.MinPriceLabel.Click += new System.EventHandler(this.MinPriceLabel_Click);
            // 
            // MinTrackBar
            // 
            this.MinTrackBar.Location = new System.Drawing.Point(12, 96);
            this.MinTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.MinTrackBar.Maximum = 350000;
            this.MinTrackBar.Name = "MinTrackBar";
            this.MinTrackBar.Size = new System.Drawing.Size(139, 56);
            this.MinTrackBar.TabIndex = 4;
            this.MinTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // MaxTrackBar
            // 
            this.MaxTrackBar.Location = new System.Drawing.Point(205, 96);
            this.MaxTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.MaxTrackBar.Maximum = 350000;
            this.MaxTrackBar.Name = "MaxTrackBar";
            this.MaxTrackBar.Size = new System.Drawing.Size(139, 56);
            this.MaxTrackBar.TabIndex = 3;
            this.MaxTrackBar.Scroll += new System.EventHandler(this.MaxTrackBar_Scroll);
            // 
            // SchoolCheckBox
            // 
            this.SchoolCheckBox.AutoSize = true;
            this.SchoolCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SchoolCheckBox.Location = new System.Drawing.Point(237, 34);
            this.SchoolCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolCheckBox.Name = "SchoolCheckBox";
            this.SchoolCheckBox.Size = new System.Drawing.Size(73, 21);
            this.SchoolCheckBox.TabIndex = 2;
            this.SchoolCheckBox.Text = "School";
            this.SchoolCheckBox.UseVisualStyleBackColor = true;
            this.SchoolCheckBox.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // BusCheckBox
            // 
            this.BusCheckBox.AutoSize = true;
            this.BusCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BusCheckBox.Location = new System.Drawing.Point(123, 34);
            this.BusCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.BusCheckBox.Name = "BusCheckBox";
            this.BusCheckBox.Size = new System.Drawing.Size(87, 21);
            this.BusCheckBox.TabIndex = 1;
            this.BusCheckBox.Text = "Business";
            this.BusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResCheckBox
            // 
            this.ResCheckBox.AutoSize = true;
            this.ResCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ResCheckBox.Location = new System.Drawing.Point(8, 34);
            this.ResCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResCheckBox.Name = "ResCheckBox";
            this.ResCheckBox.Size = new System.Drawing.Size(100, 21);
            this.ResCheckBox.TabIndex = 0;
            this.ResCheckBox.Text = "Residential";
            this.ResCheckBox.UseVisualStyleBackColor = true;
            // 
            // SchoolRangeBox
            // 
            this.SchoolRangeBox.Controls.Add(this.SchoolRangeBtn);
            this.SchoolRangeBox.Controls.Add(this.SchoolRangeLbl);
            this.SchoolRangeBox.Controls.Add(this.SchoolLabel);
            this.SchoolRangeBox.Controls.Add(this.SchoolRangeUpDown);
            this.SchoolRangeBox.Controls.Add(this.SelectSchool);
            this.SchoolRangeBox.Location = new System.Drawing.Point(291, 215);
            this.SchoolRangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolRangeBox.Name = "SchoolRangeBox";
            this.SchoolRangeBox.Padding = new System.Windows.Forms.Padding(4);
            this.SchoolRangeBox.Size = new System.Drawing.Size(205, 181);
            this.SchoolRangeBox.TabIndex = 1;
            this.SchoolRangeBox.TabStop = false;
            this.SchoolRangeBox.Text = "Within Range of a School";
            // 
            // SchoolRangeBtn
            // 
            this.SchoolRangeBtn.Location = new System.Drawing.Point(8, 137);
            this.SchoolRangeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolRangeBtn.Name = "SchoolRangeBtn";
            this.SchoolRangeBtn.Size = new System.Drawing.Size(100, 28);
            this.SchoolRangeBtn.TabIndex = 10;
            this.SchoolRangeBtn.Text = "Search";
            this.SchoolRangeBtn.UseVisualStyleBackColor = true;
            // 
            // SchoolRangeLbl
            // 
            this.SchoolRangeLbl.AutoSize = true;
            this.SchoolRangeLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SchoolRangeLbl.Location = new System.Drawing.Point(4, 85);
            this.SchoolRangeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SchoolRangeLbl.Name = "SchoolRangeLbl";
            this.SchoolRangeLbl.Size = new System.Drawing.Size(63, 17);
            this.SchoolRangeLbl.TabIndex = 11;
            this.SchoolRangeLbl.Text = "Distance";
            // 
            // SchoolLabel
            // 
            this.SchoolLabel.AutoSize = true;
            this.SchoolLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SchoolLabel.Location = new System.Drawing.Point(8, 20);
            this.SchoolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SchoolLabel.Name = "SchoolLabel";
            this.SchoolLabel.Size = new System.Drawing.Size(92, 17);
            this.SchoolLabel.TabIndex = 10;
            this.SchoolLabel.Text = "School Name";
            // 
            // SchoolRangeUpDown
            // 
            this.SchoolRangeUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SchoolRangeUpDown.Location = new System.Drawing.Point(8, 105);
            this.SchoolRangeUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolRangeUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.SchoolRangeUpDown.Name = "SchoolRangeUpDown";
            this.SchoolRangeUpDown.Size = new System.Drawing.Size(160, 22);
            this.SchoolRangeUpDown.TabIndex = 1;
            // 
            // SelectSchool
            // 
            this.SelectSchool.FormattingEnabled = true;
            this.SelectSchool.Location = new System.Drawing.Point(8, 46);
            this.SelectSchool.Margin = new System.Windows.Forms.Padding(4);
            this.SelectSchool.Name = "SelectSchool";
            this.SelectSchool.Size = new System.Drawing.Size(160, 24);
            this.SelectSchool.TabIndex = 0;
            // 
            // BusDistanceBox
            // 
            this.BusDistanceBox.Controls.Add(this.HiringBusBtn);
            this.BusDistanceBox.Controls.Add(this.BusDistLbl);
            this.BusDistanceBox.Controls.Add(this.BusinessRangeLbl);
            this.BusDistanceBox.Controls.Add(this.BusDistUpDown);
            this.BusDistanceBox.Controls.Add(this.SelectBusiness);
            this.BusDistanceBox.Location = new System.Drawing.Point(291, 404);
            this.BusDistanceBox.Margin = new System.Windows.Forms.Padding(4);
            this.BusDistanceBox.Name = "BusDistanceBox";
            this.BusDistanceBox.Padding = new System.Windows.Forms.Padding(4);
            this.BusDistanceBox.Size = new System.Drawing.Size(205, 191);
            this.BusDistanceBox.TabIndex = 2;
            this.BusDistanceBox.TabStop = false;
            this.BusDistanceBox.Text = "Hiring Businesses in Range";
            // 
            // HiringBusBtn
            // 
            this.HiringBusBtn.Location = new System.Drawing.Point(8, 137);
            this.HiringBusBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HiringBusBtn.Name = "HiringBusBtn";
            this.HiringBusBtn.Size = new System.Drawing.Size(100, 28);
            this.HiringBusBtn.TabIndex = 10;
            this.HiringBusBtn.Text = "Search";
            this.HiringBusBtn.UseVisualStyleBackColor = true;
            // 
            // BusDistLbl
            // 
            this.BusDistLbl.AutoSize = true;
            this.BusDistLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BusDistLbl.Location = new System.Drawing.Point(4, 85);
            this.BusDistLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BusDistLbl.Name = "BusDistLbl";
            this.BusDistLbl.Size = new System.Drawing.Size(63, 17);
            this.BusDistLbl.TabIndex = 11;
            this.BusDistLbl.Text = "Distance";
            // 
            // BusinessRangeLbl
            // 
            this.BusinessRangeLbl.AutoSize = true;
            this.BusinessRangeLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BusinessRangeLbl.Location = new System.Drawing.Point(8, 20);
            this.BusinessRangeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BusinessRangeLbl.Name = "BusinessRangeLbl";
            this.BusinessRangeLbl.Size = new System.Drawing.Size(106, 17);
            this.BusinessRangeLbl.TabIndex = 10;
            this.BusinessRangeLbl.Text = "Business Name";
            // 
            // BusDistUpDown
            // 
            this.BusDistUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BusDistUpDown.Location = new System.Drawing.Point(8, 105);
            this.BusDistUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.BusDistUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BusDistUpDown.Name = "BusDistUpDown";
            this.BusDistUpDown.Size = new System.Drawing.Size(160, 22);
            this.BusDistUpDown.TabIndex = 1;
            // 
            // SelectBusiness
            // 
            this.SelectBusiness.FormattingEnabled = true;
            this.SelectBusiness.Location = new System.Drawing.Point(8, 46);
            this.SelectBusiness.Margin = new System.Windows.Forms.Padding(4);
            this.SelectBusiness.Name = "SelectBusiness";
            this.SelectBusiness.Size = new System.Drawing.Size(160, 24);
            this.SelectBusiness.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SqFeetLabel);
            this.groupBox1.Controls.Add(this.BathsLabel);
            this.groupBox1.Controls.Add(this.BedsLabel);
            this.groupBox1.Controls.Add(this.ParameterSearchBtn);
            this.groupBox1.Controls.Add(this.GarageTextBox);
            this.groupBox1.Controls.Add(this.BathsUpDown);
            this.groupBox1.Controls.Add(this.SqFeetUpDown);
            this.groupBox1.Controls.Add(this.BedsUpDown);
            this.groupBox1.Controls.Add(this.ApartmentCheckBox);
            this.groupBox1.Controls.Add(this.HouseCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Residence Parameters";
            // 
            // SqFeetLabel
            // 
            this.SqFeetLabel.AutoSize = true;
            this.SqFeetLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SqFeetLabel.Location = new System.Drawing.Point(119, 76);
            this.SqFeetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SqFeetLabel.Name = "SqFeetLabel";
            this.SqFeetLabel.Size = new System.Drawing.Size(57, 17);
            this.SqFeetLabel.TabIndex = 8;
            this.SqFeetLabel.Text = "Sq Feet";
            // 
            // BathsLabel
            // 
            this.BathsLabel.AutoSize = true;
            this.BathsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BathsLabel.Location = new System.Drawing.Point(63, 76);
            this.BathsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BathsLabel.Name = "BathsLabel";
            this.BathsLabel.Size = new System.Drawing.Size(44, 17);
            this.BathsLabel.TabIndex = 9;
            this.BathsLabel.Text = "Baths";
            // 
            // BedsLabel
            // 
            this.BedsLabel.AutoSize = true;
            this.BedsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BedsLabel.Location = new System.Drawing.Point(8, 76);
            this.BedsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BedsLabel.Name = "BedsLabel";
            this.BedsLabel.Size = new System.Drawing.Size(40, 17);
            this.BedsLabel.TabIndex = 10;
            this.BedsLabel.Text = "Beds";
            // 
            // ParameterSearchBtn
            // 
            this.ParameterSearchBtn.Location = new System.Drawing.Point(7, 145);
            this.ParameterSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ParameterSearchBtn.Name = "ParameterSearchBtn";
            this.ParameterSearchBtn.Size = new System.Drawing.Size(100, 28);
            this.ParameterSearchBtn.TabIndex = 18;
            this.ParameterSearchBtn.Text = "Search";
            this.ParameterSearchBtn.UseVisualStyleBackColor = true;
            // 
            // GarageTextBox
            // 
            this.GarageTextBox.AutoSize = true;
            this.GarageTextBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GarageTextBox.Location = new System.Drawing.Point(123, 23);
            this.GarageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GarageTextBox.Name = "GarageTextBox";
            this.GarageTextBox.Size = new System.Drawing.Size(78, 21);
            this.GarageTextBox.TabIndex = 17;
            this.GarageTextBox.Text = "Garage";
            this.GarageTextBox.UseVisualStyleBackColor = true;
            // 
            // BathsUpDown
            // 
            this.BathsUpDown.Location = new System.Drawing.Point(67, 98);
            this.BathsUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.BathsUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.BathsUpDown.Name = "BathsUpDown";
            this.BathsUpDown.Size = new System.Drawing.Size(40, 22);
            this.BathsUpDown.TabIndex = 16;
            // 
            // SqFeetUpDown
            // 
            this.SqFeetUpDown.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.SqFeetUpDown.Location = new System.Drawing.Point(123, 98);
            this.SqFeetUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.SqFeetUpDown.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.SqFeetUpDown.Minimum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.SqFeetUpDown.Name = "SqFeetUpDown";
            this.SqFeetUpDown.Size = new System.Drawing.Size(80, 22);
            this.SqFeetUpDown.TabIndex = 15;
            this.SqFeetUpDown.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // BedsUpDown
            // 
            this.BedsUpDown.Location = new System.Drawing.Point(8, 98);
            this.BedsUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.BedsUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.BedsUpDown.Name = "BedsUpDown";
            this.BedsUpDown.Size = new System.Drawing.Size(40, 22);
            this.BedsUpDown.TabIndex = 14;
            // 
            // ApartmentCheckBox
            // 
            this.ApartmentCheckBox.AutoSize = true;
            this.ApartmentCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ApartmentCheckBox.Location = new System.Drawing.Point(8, 52);
            this.ApartmentCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ApartmentCheckBox.Name = "ApartmentCheckBox";
            this.ApartmentCheckBox.Size = new System.Drawing.Size(95, 21);
            this.ApartmentCheckBox.TabIndex = 8;
            this.ApartmentCheckBox.Text = "Apartment";
            this.ApartmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // HouseCheckBox
            // 
            this.HouseCheckBox.AutoSize = true;
            this.HouseCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HouseCheckBox.Location = new System.Drawing.Point(8, 23);
            this.HouseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.HouseCheckBox.Name = "HouseCheckBox";
            this.HouseCheckBox.Size = new System.Drawing.Size(71, 21);
            this.HouseCheckBox.TabIndex = 9;
            this.HouseCheckBox.Text = "House";
            this.HouseCheckBox.UseVisualStyleBackColor = true;
            this.HouseCheckBox.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LocalSearch);
            this.groupBox2.Location = new System.Drawing.Point(13, 425);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(207, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties Owned by Locals";
            // 
            // LocalSearch
            // 
            this.LocalSearch.Location = new System.Drawing.Point(45, 34);
            this.LocalSearch.Margin = new System.Windows.Forms.Padding(4);
            this.LocalSearch.Name = "LocalSearch";
            this.LocalSearch.Size = new System.Drawing.Size(100, 28);
            this.LocalSearch.TabIndex = 8;
            this.LocalSearch.Text = "Search";
            this.LocalSearch.UseVisualStyleBackColor = true;
            // 
            // OutputArea
            // 
            this.OutputArea.Location = new System.Drawing.Point(594, 47);
            this.OutputArea.Name = "OutputArea";
            this.OutputArea.Size = new System.Drawing.Size(446, 548);
            this.OutputArea.TabIndex = 5;
            this.OutputArea.Text = "";
            this.OutputArea.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // QueryResultsLabel
            // 
            this.QueryResultsLabel.AutoSize = true;
            this.QueryResultsLabel.Location = new System.Drawing.Point(591, 15);
            this.QueryResultsLabel.Name = "QueryResultsLabel";
            this.QueryResultsLabel.Size = new System.Drawing.Size(98, 17);
            this.QueryResultsLabel.TabIndex = 6;
            this.QueryResultsLabel.Text = "Query Results";
            this.QueryResultsLabel.Click += new System.EventHandler(this.QueryResultsLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 620);
            this.Controls.Add(this.QueryResultsLabel);
            this.Controls.Add(this.OutputArea);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BusDistanceBox);
            this.Controls.Add(this.SchoolRangeBox);
            this.Controls.Add(this.TypeRangeBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TypeRangeBox.ResumeLayout(false);
            this.TypeRangeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).EndInit();
            this.SchoolRangeBox.ResumeLayout(false);
            this.SchoolRangeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolRangeUpDown)).EndInit();
            this.BusDistanceBox.ResumeLayout(false);
            this.BusDistanceBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BusDistUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BathsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SqFeetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedsUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeRangeBox;
        private System.Windows.Forms.TrackBar MinTrackBar;
        private System.Windows.Forms.TrackBar MaxTrackBar;
        private System.Windows.Forms.CheckBox SchoolCheckBox;
        private System.Windows.Forms.CheckBox BusCheckBox;
        private System.Windows.Forms.CheckBox ResCheckBox;
        private System.Windows.Forms.Button TypePriceBtn;
        private System.Windows.Forms.Label MaxPriceLabel;
        private System.Windows.Forms.Label MinPriceLabel;
        private System.Windows.Forms.GroupBox SchoolRangeBox;
        private System.Windows.Forms.Button SchoolRangeBtn;
        private System.Windows.Forms.Label SchoolRangeLbl;
        private System.Windows.Forms.Label SchoolLabel;
        private System.Windows.Forms.NumericUpDown SchoolRangeUpDown;
        private System.Windows.Forms.ComboBox SelectSchool;
        private System.Windows.Forms.GroupBox BusDistanceBox;
        private System.Windows.Forms.Button HiringBusBtn;
        private System.Windows.Forms.Label BusDistLbl;
        private System.Windows.Forms.Label BusinessRangeLbl;
        private System.Windows.Forms.NumericUpDown BusDistUpDown;
        private System.Windows.Forms.ComboBox SelectBusiness;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox GarageTextBox;
        private System.Windows.Forms.NumericUpDown BathsUpDown;
        private System.Windows.Forms.NumericUpDown SqFeetUpDown;
        private System.Windows.Forms.NumericUpDown BedsUpDown;
        private System.Windows.Forms.CheckBox ApartmentCheckBox;
        private System.Windows.Forms.CheckBox HouseCheckBox;
        private System.Windows.Forms.Button ParameterSearchBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button LocalSearch;
        private System.Windows.Forms.Label SqFeetLabel;
        private System.Windows.Forms.Label BathsLabel;
        private System.Windows.Forms.Label BedsLabel;
        private System.Windows.Forms.RichTextBox OutputArea;
        private System.Windows.Forms.Label QueryResultsLabel;
    }
}