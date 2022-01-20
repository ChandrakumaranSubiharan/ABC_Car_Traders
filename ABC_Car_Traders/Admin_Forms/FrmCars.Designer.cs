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
            this.imgLabl = new System.Windows.Forms.Label();
            this.colorLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.brandLbl = new System.Windows.Forms.Label();
            this.BrandCombo = new System.Windows.Forms.ComboBox();
            this.PriceTbox = new System.Windows.Forms.TextBox();
            this.conditioncombo = new System.Windows.Forms.ComboBox();
            this.fuelcombo = new System.Windows.Forms.ComboBox();
            this.VehicleTypeCombo = new System.Windows.Forms.ComboBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.ModelNotextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchTbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.panel3.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(21, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 2);
            this.panel3.TabIndex = 54;
            // 
            // FrmTitLbl
            // 
            this.FrmTitLbl.AutoSize = true;
            this.FrmTitLbl.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmTitLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FrmTitLbl.Location = new System.Drawing.Point(15, 29);
            this.FrmTitLbl.Name = "FrmTitLbl";
            this.FrmTitLbl.Size = new System.Drawing.Size(66, 33);
            this.FrmTitLbl.TabIndex = 53;
            this.FrmTitLbl.Text = "Cars";
            // 
            // MNlbl
            // 
            this.MNlbl.AutoSize = true;
            this.MNlbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNlbl.Location = new System.Drawing.Point(18, 94);
            this.MNlbl.Name = "MNlbl";
            this.MNlbl.Size = new System.Drawing.Size(106, 22);
            this.MNlbl.TabIndex = 55;
            this.MNlbl.Text = "Model Name";
            // 
            // Cbl
            // 
            this.Cbl.AutoSize = true;
            this.Cbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbl.Location = new System.Drawing.Point(18, 160);
            this.Cbl.Name = "Cbl";
            this.Cbl.Size = new System.Drawing.Size(84, 22);
            this.Cbl.TabIndex = 56;
            this.Cbl.Text = "Condition";
            // 
            // FuelLbl
            // 
            this.FuelLbl.AutoSize = true;
            this.FuelLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLbl.Location = new System.Drawing.Point(292, 160);
            this.FuelLbl.Name = "FuelLbl";
            this.FuelLbl.Size = new System.Drawing.Size(81, 22);
            this.FuelLbl.TabIndex = 58;
            this.FuelLbl.Text = "Fuel Type";
            this.FuelLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(572, 94);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(44, 22);
            this.yearLbl.TabIndex = 57;
            this.yearLbl.Text = "Year";
            this.yearLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // imgLabl
            // 
            this.imgLabl.AutoSize = true;
            this.imgLabl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgLabl.Location = new System.Drawing.Point(292, 230);
            this.imgLabl.Name = "imgLabl";
            this.imgLabl.Size = new System.Drawing.Size(56, 22);
            this.imgLabl.TabIndex = 60;
            this.imgLabl.Text = "Image";
            // 
            // colorLbl
            // 
            this.colorLbl.AutoSize = true;
            this.colorLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLbl.Location = new System.Drawing.Point(18, 230);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(51, 22);
            this.colorLbl.TabIndex = 59;
            this.colorLbl.Text = "Color";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLbl.Location = new System.Drawing.Point(572, 230);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(101, 22);
            this.priceLbl.TabIndex = 63;
            this.priceLbl.Text = "Selling Price";
            this.priceLbl.Click += new System.EventHandler(this.priceLbl_Click);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(572, 160);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(104, 22);
            this.typeLbl.TabIndex = 62;
            this.typeLbl.Text = "Vehicle Type";
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.Location = new System.Drawing.Point(292, 94);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(56, 22);
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
            this.BrandCombo.ItemHeight = 20;
            this.BrandCombo.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asdasda",
            "asfasf"});
            this.BrandCombo.Location = new System.Drawing.Point(296, 117);
            this.BrandCombo.Name = "BrandCombo";
            this.BrandCombo.Size = new System.Drawing.Size(225, 28);
            this.BrandCombo.TabIndex = 65;
            this.BrandCombo.SelectedIndexChanged += new System.EventHandler(this.BrandCombo_SelectedIndexChanged);
            // 
            // PriceTbox
            // 
            this.PriceTbox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTbox.Location = new System.Drawing.Point(576, 255);
            this.PriceTbox.Name = "PriceTbox";
            this.PriceTbox.Size = new System.Drawing.Size(225, 27);
            this.PriceTbox.TabIndex = 67;
            this.PriceTbox.TextChanged += new System.EventHandler(this.PriceTbox_TextChanged);
            // 
            // conditioncombo
            // 
            this.conditioncombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditioncombo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditioncombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.conditioncombo.FormattingEnabled = true;
            this.conditioncombo.IntegralHeight = false;
            this.conditioncombo.ItemHeight = 20;
            this.conditioncombo.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asdasda",
            "asfasf"});
            this.conditioncombo.Location = new System.Drawing.Point(21, 185);
            this.conditioncombo.Name = "conditioncombo";
            this.conditioncombo.Size = new System.Drawing.Size(225, 28);
            this.conditioncombo.TabIndex = 68;
            this.conditioncombo.SelectedIndexChanged += new System.EventHandler(this.conditioncombo_SelectedIndexChanged);
            // 
            // fuelcombo
            // 
            this.fuelcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fuelcombo.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelcombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fuelcombo.FormattingEnabled = true;
            this.fuelcombo.IntegralHeight = false;
            this.fuelcombo.ItemHeight = 20;
            this.fuelcombo.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asdasda",
            "asfasf"});
            this.fuelcombo.Location = new System.Drawing.Point(296, 185);
            this.fuelcombo.Name = "fuelcombo";
            this.fuelcombo.Size = new System.Drawing.Size(225, 28);
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
            this.VehicleTypeCombo.ItemHeight = 20;
            this.VehicleTypeCombo.Items.AddRange(new object[] {
            "asd",
            "asd",
            "asdasda",
            "asfasf"});
            this.VehicleTypeCombo.Location = new System.Drawing.Point(576, 185);
            this.VehicleTypeCombo.Name = "VehicleTypeCombo";
            this.VehicleTypeCombo.Size = new System.Drawing.Size(225, 28);
            this.VehicleTypeCombo.TabIndex = 70;
            this.VehicleTypeCombo.SelectedIndexChanged += new System.EventHandler(this.VehicleTypeCombo_SelectedIndexChanged);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(21, 255);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(225, 27);
            this.colorTextBox.TabIndex = 71;
            this.colorTextBox.TextChanged += new System.EventHandler(this.colorTextBox_TextChanged);
            // 
            // ModelNotextBox
            // 
            this.ModelNotextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelNotextBox.Location = new System.Drawing.Point(21, 118);
            this.ModelNotextBox.Name = "ModelNotextBox";
            this.ModelNotextBox.Size = new System.Drawing.Size(225, 27);
            this.ModelNotextBox.TabIndex = 72;
            this.ModelNotextBox.TextChanged += new System.EventHandler(this.ModelNotextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(576, 117);
            this.YearTextBox.MaxLength = 4;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(225, 27);
            this.YearTextBox.TabIndex = 73;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(296, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 27);
            this.textBox1.TabIndex = 74;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SearchTbox
            // 
            this.SearchTbox.Font = new System.Drawing.Font("Open Sans SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchTbox.Location = new System.Drawing.Point(21, 317);
            this.SearchTbox.Name = "SearchTbox";
            this.SearchTbox.Size = new System.Drawing.Size(321, 35);
            this.SearchTbox.TabIndex = 75;
            this.SearchTbox.Text = "  Search Car.....";
            this.SearchTbox.TextChanged += new System.EventHandler(this.SearchTbox_TextChanged);
            this.SearchTbox.Enter += new System.EventHandler(this.SearchTbox_Enter);
            this.SearchTbox.Leave += new System.EventHandler(this.SearchTbox_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 250);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::ABC_Car_Traders.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(823, 317);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 35);
            this.btnRefresh.TabIndex = 80;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::ABC_Car_Traders.Properties.Resources.deleteSymbol;
            this.btnDelete.Location = new System.Drawing.Point(682, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(123, 35);
            this.btnDelete.TabIndex = 78;
            this.btnDelete.Text = " DELETE";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(143)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::ABC_Car_Traders.Properties.Resources.editSymbol;
            this.btnUpdate.Location = new System.Drawing.Point(534, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
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
            this.btnCreate.Location = new System.Drawing.Point(392, 317);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(125, 35);
            this.btnCreate.TabIndex = 76;
            this.btnCreate.Text = " CREATE";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // FrmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 679);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.SearchTbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.ModelNotextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.VehicleTypeCombo);
            this.Controls.Add(this.fuelcombo);
            this.Controls.Add(this.conditioncombo);
            this.Controls.Add(this.PriceTbox);
            this.Controls.Add(this.BrandCombo);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.imgLabl);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.FuelLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.Cbl);
            this.Controls.Add(this.MNlbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FrmTitLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCars";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label imgLabl;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.ComboBox BrandCombo;
        private System.Windows.Forms.TextBox PriceTbox;
        private System.Windows.Forms.ComboBox conditioncombo;
        private System.Windows.Forms.ComboBox fuelcombo;
        private System.Windows.Forms.ComboBox VehicleTypeCombo;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox ModelNotextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox SearchTbox;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
    }
}