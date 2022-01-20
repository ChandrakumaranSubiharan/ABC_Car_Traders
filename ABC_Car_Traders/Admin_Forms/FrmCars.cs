using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders.Admin_Forms
{
    public partial class FrmCars : Form
    {
        public FrmCars()
        {
            InitializeComponent();
            
        }

        private void Car_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModelNotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BrandCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehicleTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fuelcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void conditioncombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void colorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Car.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
                   

        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Car.....";

                SearchTbox.ForeColor = Color.Silver;
            }

        }
    }
}
