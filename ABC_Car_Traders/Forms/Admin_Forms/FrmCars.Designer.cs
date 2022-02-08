namespace ABC_Car_Traders.Admin_Forms
{
    partial class FrmCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCars));
            this.panel3 = new System.Windows.Forms.Panel();
            this.FrmTitLbl = new System.Windows.Forms.Label();
            this.MNlbl = new System.Windows.Forms.Label();
            this.Cbl = new System.Windows.Forms.Label();
            this.FuelLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.colorLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.brandLbl = new System.Windows.Forms.Label();
            this.BrandCombo = new System.Windows.Forms.ComboBox();
            this.PriceTbox = new System.Windows.Forms.TextBox();
            this.avacombo = new System.Windows.Forms.ComboBox();
            this.fuelcombo = new System.Windows.Forms.ComboBox();
            this.VehicleTypeCombo = new System.Windows.Forms.ComboBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.ModelNotextBox = new System.Windows.Forms.TextBox();
            this.ImgPathTextBox = new System.Windows.Forms.TextBox();
            this.SearchTbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImgBrowseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(28, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 2);
            this.panel3.TabIndex = 54;
            // 
            // FrmTitLbl
            // 
            this.FrmTitLbl.AutoSize = true;
            this.FrmTitLbl.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmTitLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FrmTitLbl.Location = new System.Drawing.Point(20, 36);
            this.FrmTitLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrmTitLbl.Name = "FrmTitLbl";
            this.FrmTitLbl.Size = new System.Drawing.Size(82, 41);
            this.FrmTitLbl.TabIndex = 53;
            this.FrmTitLbl.Text = "Cars";
            // 
            // MNlbl
            // 
            this.MNlbl.AutoSize = true;
            this.MNlbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNlbl.Location = new System.Drawing.Point(316, 116);
            this.MNlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MNlbl.Name = "MNlbl";
            this.MNlbl.Size = new System.Drawing.Size(131, 27);
            this.MNlbl.TabIndex = 55;
            this.MNlbl.Text = "Model Name";
            // 
            // Cbl
            // 
            this.Cbl.AutoSize = true;
            this.Cbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbl.Location = new System.Drawing.Point(24, 197);
            this.Cbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cbl.Name = "Cbl";
            this.Cbl.Size = new System.Drawing.Size(111, 27);
            this.Cbl.TabIndex = 56;
            this.Cbl.Text = "Availability";
            // 
            // FuelLbl
            // 
            this.FuelLbl.AutoSize = true;
            this.FuelLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLbl.Location = new System.Drawing.Point(315, 197);
            this.FuelLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FuelLbl.Name = "FuelLbl";
            this.FuelLbl.Size = new System.Drawing.Size(99, 27);
            this.FuelLbl.TabIndex = 58;
            this.FuelLbl.Text = "Fuel Type";
            this.FuelLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(611, 286);
            this.yearLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(117, 27);
            this.yearLbl.TabIndex = 57;
            this.yearLbl.Text = "Image Path";
            this.yearLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // colorLbl
            // 
            this.colorLbl.AutoSize = true;
            this.colorLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLbl.Location = new System.Drawing.Point(24, 283);
            this.colorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(62, 27);
            this.colorLbl.TabIndex = 59;
            this.colorLbl.Text = "Color";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(315, 283);
            this.priceLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(123, 27);
            this.priceLbl.TabIndex = 63;
            this.priceLbl.Text = "Selling Price";
            this.priceLbl.Click += new System.EventHandler(this.priceLbl_Click);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(611, 197);
            this.typeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(93, 27);
            this.typeLbl.TabIndex = 62;
            this.typeLbl.Text = "Car Type";
            this.typeLbl.Click += new System.EventHandler(this.typeLbl_Click);
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.Location = new System.Drawing.Point(611, 117);
            this.brandLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(68, 27);
            this.brandLbl.TabIndex = 61;
            this.brandLbl.Text = "Brand";
            // 
            // BrandCombo
            // 
            this.BrandCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrandCombo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BrandCombo.FormattingEnabled = true;
            this.BrandCombo.IntegralHeight = false;
            this.BrandCombo.ItemHeight = 24;
            this.BrandCombo.Items.AddRange(new object[] {
            "Honda",
            "Toyota",
            "Suzuki",
            "Hyundai",
            "KIA",
            "Mahindra",
            "Tata Motors"});
            this.BrandCombo.Location = new System.Drawing.Point(616, 145);
            this.BrandCombo.Margin = new System.Windows.Forms.Padding(4);
            this.BrandCombo.Name = "BrandCombo";
            this.BrandCombo.Size = new System.Drawing.Size(217, 32);
            this.BrandCombo.TabIndex = 65;
            this.BrandCombo.SelectedIndexChanged += new System.EventHandler(this.BrandCombo_SelectedIndexChanged);
            // 
            // PriceTbox
            // 
            this.PriceTbox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTbox.Location = new System.Drawing.Point(320, 314);
            this.PriceTbox.Margin = new System.Windows.Forms.Padding(4);
            this.PriceTbox.Name = "PriceTbox";
            this.PriceTbox.Size = new System.Drawing.Size(217, 32);
            this.PriceTbox.TabIndex = 67;
            this.PriceTbox.TextChanged += new System.EventHandler(this.PriceTbox_TextChanged);
            this.PriceTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTbox_KeyPress);
            // 
            // avacombo
            // 
            this.avacombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.avacombo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avacombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avacombo.FormattingEnabled = true;
            this.avacombo.IntegralHeight = false;
            this.avacombo.ItemHeight = 24;
            this.avacombo.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.avacombo.Location = new System.Drawing.Point(28, 228);
            this.avacombo.Margin = new System.Windows.Forms.Padding(4);
            this.avacombo.Name = "avacombo";
            this.avacombo.Size = new System.Drawing.Size(217, 32);
            this.avacombo.TabIndex = 68;
            this.avacombo.SelectedIndexChanged += new System.EventHandler(this.conditioncombo_SelectedIndexChanged);
            // 
            // fuelcombo
            // 
            this.fuelcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelcombo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fuelcombo.FormattingEnabled = true;
            this.fuelcombo.IntegralHeight = false;
            this.fuelcombo.ItemHeight = 24;
            this.fuelcombo.Items.AddRange(new object[] {
            "Petrol",
            "Diesel"});
            this.fuelcombo.Location = new System.Drawing.Point(320, 228);
            this.fuelcombo.Margin = new System.Windows.Forms.Padding(4);
            this.fuelcombo.Name = "fuelcombo";
            this.fuelcombo.Size = new System.Drawing.Size(217, 32);
            this.fuelcombo.TabIndex = 69;
            this.fuelcombo.SelectedIndexChanged += new System.EventHandler(this.fuelcombo_SelectedIndexChanged);
            // 
            // VehicleTypeCombo
            // 
            this.VehicleTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehicleTypeCombo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.VehicleTypeCombo.FormattingEnabled = true;
            this.VehicleTypeCombo.IntegralHeight = false;
            this.VehicleTypeCombo.ItemHeight = 24;
            this.VehicleTypeCombo.Items.AddRange(new object[] {
            "SEDAN",
            "SPORTS CAR",
            "MINIVAN",
            "SUV",
            "MICRO"});
            this.VehicleTypeCombo.Location = new System.Drawing.Point(616, 228);
            this.VehicleTypeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleTypeCombo.Name = "VehicleTypeCombo";
            this.VehicleTypeCombo.Size = new System.Drawing.Size(217, 32);
            this.VehicleTypeCombo.TabIndex = 70;
            this.VehicleTypeCombo.SelectedIndexChanged += new System.EventHandler(this.VehicleTypeCombo_SelectedIndexChanged);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(28, 314);
            this.colorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(217, 32);
            this.colorTextBox.TabIndex = 71;
            this.colorTextBox.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // ModelNotextBox
            // 
            this.ModelNotextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelNotextBox.Location = new System.Drawing.Point(320, 145);
            this.ModelNotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ModelNotextBox.Name = "ModelNotextBox";
            this.ModelNotextBox.Size = new System.Drawing.Size(217, 32);
            this.ModelNotextBox.TabIndex = 72;
            this.ModelNotextBox.TextChanged += new System.EventHandler(this.ModelNotextBox_TextChanged);
            // 
            // ImgPathTextBox
            // 
            this.ImgPathTextBox.Enabled = false;
            this.ImgPathTextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgPathTextBox.Location = new System.Drawing.Point(616, 314);
            this.ImgPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImgPathTextBox.MaxLength = 4;
            this.ImgPathTextBox.Name = "ImgPathTextBox";
            this.ImgPathTextBox.Size = new System.Drawing.Size(217, 32);
            this.ImgPathTextBox.TabIndex = 73;
            this.ImgPathTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // SearchTbox
            // 
            this.SearchTbox.Font = new System.Drawing.Font("Open Sans SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchTbox.Location = new System.Drawing.Point(28, 390);
            this.SearchTbox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTbox.Name = "SearchTbox";
            this.SearchTbox.Size = new System.Drawing.Size(268, 42);
            this.SearchTbox.TabIndex = 75;
            this.SearchTbox.Text = "  Search Car.....";
            this.SearchTbox.TextChanged += new System.EventHandler(this.SearchTbox_TextChanged);
            this.SearchTbox.Enter += new System.EventHandler(this.SearchTbox_Enter);
            this.SearchTbox.Leave += new System.EventHandler(this.SearchTbox_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 464);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1128, 308);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // ImgBrowseBtn
            // 
            this.ImgBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.ImgBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgBrowseBtn.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgBrowseBtn.ForeColor = System.Drawing.Color.White;
            this.ImgBrowseBtn.Location = new System.Drawing.Point(909, 314);
            this.ImgBrowseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ImgBrowseBtn.Name = "ImgBrowseBtn";
            this.ImgBrowseBtn.Size = new System.Drawing.Size(247, 33);
            this.ImgBrowseBtn.TabIndex = 82;
            this.ImgBrowseBtn.Text = "Browse Car Image";
            this.ImgBrowseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImgBrowseBtn.UseVisualStyleBackColor = false;
            this.ImgBrowseBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(909, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::ABC_Car_Traders.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(1097, 390);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 43);
            this.btnRefresh.TabIndex = 80;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::ABC_Car_Traders.Properties.Resources.deleteSymbol;
            this.btnDelete.Location = new System.Drawing.Point(909, 390);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(164, 43);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = " DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::ABC_Car_Traders.Properties.Resources.editSymbol;
            this.btnUpdate.Location = new System.Drawing.Point(712, 390);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(173, 43);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = " UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(523, 390);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(167, 43);
            this.btnCreate.TabIndex = 76;
            this.btnCreate.Text = " CREATE";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ABC_Car_Traders.Properties.Resources.reportW;
            this.button2.Location = new System.Drawing.Point(324, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(173, 43);
            this.button2.TabIndex = 131;
            this.button2.Text = " REPORT";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 145);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 32);
            this.textBox1.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 134;
            this.label3.Text = "Car ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 836);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ImgBrowseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.SearchTbox);
            this.Controls.Add(this.ImgPathTextBox);
            this.Controls.Add(this.ModelNotextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.VehicleTypeCombo);
            this.Controls.Add(this.fuelcombo);
            this.Controls.Add(this.avacombo);
            this.Controls.Add(this.PriceTbox);
            this.Controls.Add(this.BrandCombo);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.FuelLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.Cbl);
            this.Controls.Add(this.MNlbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FrmTitLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCars";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FrmTitLbl;
        private System.Windows.Forms.Label MNlbl;
        private System.Windows.Forms.Label Cbl;
        private System.Windows.Forms.Label FuelLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.ComboBox BrandCombo;
        private System.Windows.Forms.TextBox PriceTbox;
        private System.Windows.Forms.ComboBox avacombo;
        private System.Windows.Forms.ComboBox fuelcombo;
        private System.Windows.Forms.ComboBox VehicleTypeCombo;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox ModelNotextBox;
        private System.Windows.Forms.TextBox ImgPathTextBox;
        private System.Windows.Forms.TextBox SearchTbox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ImgBrowseBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}