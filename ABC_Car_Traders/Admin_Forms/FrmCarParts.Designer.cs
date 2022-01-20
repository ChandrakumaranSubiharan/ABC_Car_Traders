namespace ABC_Car_Traders.Admin_Forms
{
    partial class FrmCarParts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarParts));
            this.panel3 = new System.Windows.Forms.Panel();
            this.FrmTitLbl = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SearchTbox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.ModelNotextBox = new System.Windows.Forms.TextBox();
            this.ImgTextBox = new System.Windows.Forms.TextBox();
            this.brandLbl = new System.Windows.Forms.Label();
            this.FuelLbl = new System.Windows.Forms.Label();
            this.yearLbl = new System.Windows.Forms.Label();
            this.Cbl = new System.Windows.Forms.Label();
            this.MNlbl = new System.Windows.Forms.Label();
            this.PriceTbox = new System.Windows.Forms.TextBox();
            this.BrandTbox = new System.Windows.Forms.TextBox();
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
            this.panel3.Size = new System.Drawing.Size(85, 2);
            this.panel3.TabIndex = 56;
            // 
            // FrmTitLbl
            // 
            this.FrmTitLbl.AutoSize = true;
            this.FrmTitLbl.Font = new System.Drawing.Font("Open Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmTitLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FrmTitLbl.Location = new System.Drawing.Point(15, 29);
            this.FrmTitLbl.Name = "FrmTitLbl";
            this.FrmTitLbl.Size = new System.Drawing.Size(120, 33);
            this.FrmTitLbl.TabIndex = 55;
            this.FrmTitLbl.Text = "Car Parts";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::ABC_Car_Traders.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(823, 249);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 35);
            this.btnRefresh.TabIndex = 104;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 317);
            this.dataGridView1.TabIndex = 103;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(59)))), ((int)(((byte)(87)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::ABC_Car_Traders.Properties.Resources.deleteSymbol;
            this.btnDelete.Location = new System.Drawing.Point(682, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(123, 35);
            this.btnDelete.TabIndex = 102;
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
            this.btnUpdate.Location = new System.Drawing.Point(534, 249);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnUpdate.TabIndex = 101;
            this.btnUpdate.Text = " UPDATE";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(173)))), ((int)(((byte)(5)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Open Sans SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.Location = new System.Drawing.Point(392, 249);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCreate.Size = new System.Drawing.Size(125, 35);
            this.btnCreate.TabIndex = 100;
            this.btnCreate.Text = " CREATE";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // SearchTbox
            // 
            this.SearchTbox.Font = new System.Drawing.Font("Open Sans SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTbox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SearchTbox.Location = new System.Drawing.Point(21, 249);
            this.SearchTbox.Name = "SearchTbox";
            this.SearchTbox.Size = new System.Drawing.Size(321, 35);
            this.SearchTbox.TabIndex = 99;
            this.SearchTbox.Text = "  Search Car Part.....";
            this.SearchTbox.TextChanged += new System.EventHandler(this.SearchTbox_TextChanged);
            this.SearchTbox.Enter += new System.EventHandler(this.SearchTbox_Enter);
            this.SearchTbox.Leave += new System.EventHandler(this.SearchTbox_Leave);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(576, 117);
            this.YearTextBox.MaxLength = 4;
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(225, 27);
            this.YearTextBox.TabIndex = 97;
            // 
            // ModelNotextBox
            // 
            this.ModelNotextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelNotextBox.Location = new System.Drawing.Point(21, 118);
            this.ModelNotextBox.Name = "ModelNotextBox";
            this.ModelNotextBox.Size = new System.Drawing.Size(225, 27);
            this.ModelNotextBox.TabIndex = 96;
            // 
            // ImgTextBox
            // 
            this.ImgTextBox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImgTextBox.Location = new System.Drawing.Point(296, 185);
            this.ImgTextBox.Name = "ImgTextBox";
            this.ImgTextBox.Size = new System.Drawing.Size(225, 27);
            this.ImgTextBox.TabIndex = 95;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLbl.Location = new System.Drawing.Point(292, 94);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(114, 22);
            this.brandLbl.TabIndex = 87;
            this.brandLbl.Text = "Manufacturer";
            // 
            // FuelLbl
            // 
            this.FuelLbl.AutoSize = true;
            this.FuelLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuelLbl.Location = new System.Drawing.Point(292, 160);
            this.FuelLbl.Name = "FuelLbl";
            this.FuelLbl.Size = new System.Drawing.Size(56, 22);
            this.FuelLbl.TabIndex = 84;
            this.FuelLbl.Text = "Image";
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLbl.Location = new System.Drawing.Point(572, 94);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(81, 22);
            this.yearLbl.TabIndex = 83;
            this.yearLbl.Text = "Warranty";
            // 
            // Cbl
            // 
            this.Cbl.AutoSize = true;
            this.Cbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbl.Location = new System.Drawing.Point(18, 160);
            this.Cbl.Name = "Cbl";
            this.Cbl.Size = new System.Drawing.Size(101, 22);
            this.Cbl.TabIndex = 82;
            this.Cbl.Text = "Selling Price";
            // 
            // MNlbl
            // 
            this.MNlbl.AutoSize = true;
            this.MNlbl.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNlbl.Location = new System.Drawing.Point(18, 94);
            this.MNlbl.Name = "MNlbl";
            this.MNlbl.Size = new System.Drawing.Size(121, 22);
            this.MNlbl.TabIndex = 81;
            this.MNlbl.Text = "Car Part Name";
            // 
            // PriceTbox
            // 
            this.PriceTbox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTbox.Location = new System.Drawing.Point(21, 185);
            this.PriceTbox.Name = "PriceTbox";
            this.PriceTbox.Size = new System.Drawing.Size(225, 27);
            this.PriceTbox.TabIndex = 91;
            // 
            // BrandTbox
            // 
            this.BrandTbox.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandTbox.Location = new System.Drawing.Point(296, 117);
            this.BrandTbox.Name = "BrandTbox";
            this.BrandTbox.Size = new System.Drawing.Size(225, 27);
            this.BrandTbox.TabIndex = 105;
            // 
            // FrmCarParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 679);
            this.Controls.Add(this.BrandTbox);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.SearchTbox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.ModelNotextBox);
            this.Controls.Add(this.ImgTextBox);
            this.Controls.Add(this.PriceTbox);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.FuelLbl);
            this.Controls.Add(this.yearLbl);
            this.Controls.Add(this.Cbl);
            this.Controls.Add(this.MNlbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FrmTitLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCarParts";
            this.Text = "Car Parts";
            this.Load += new System.EventHandler(this.FrmCarParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FrmTitLbl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox SearchTbox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox ModelNotextBox;
        private System.Windows.Forms.TextBox ImgTextBox;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.Label FuelLbl;
        private System.Windows.Forms.Label yearLbl;
        private System.Windows.Forms.Label Cbl;
        private System.Windows.Forms.Label MNlbl;
        private System.Windows.Forms.TextBox PriceTbox;
        private System.Windows.Forms.TextBox BrandTbox;
    }
}