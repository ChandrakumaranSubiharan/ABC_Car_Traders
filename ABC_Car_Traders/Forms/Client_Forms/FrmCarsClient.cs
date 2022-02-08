using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using BLL;
using DAL;
using DAL.DTO;

namespace ABC_Car_Traders.Client_Forms
{
    public partial class FrmCarsClient : Form
    {
        public FrmCarsClient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        List<CarDetailsDTO> list = new List<CarDetailsDTO>();
        private void FrmCarsClient_Load(object sender, EventArgs e)
        {
            list = CARBLL.GetCars();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].HeaderText = "Brand";
            dataGridView1.Columns[3].HeaderText = "Color";
            dataGridView1.Columns[4].HeaderText = "Fuel";
            dataGridView1.Columns[5].HeaderText = "Availability";
            dataGridView1.Columns[6].HeaderText = "Type";
            dataGridView1.Columns[7].HeaderText = "Price";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
        }

        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {
            //Connection String  
            string cs = (@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");

            SqlConnection sqlCon;
            SqlDataAdapter adapt;
            DataTable dt;

            sqlCon = new SqlConnection(cs);
            sqlCon.Open();
            adapt = new SqlDataAdapter("select * from car where modelname like '" + SearchTbox.Text + "%'", sqlCon);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Cars by Model Name.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Cars by Model Name.....";

                SearchTbox.ForeColor = Color.Silver;

                dataGridView1.DataSource = list;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDLbl.Text = row.Cells[0].Value.ToString();
                ModelLbl.Text = row.Cells[1].Value.ToString();
                BrandLbl.Text = row.Cells[2].Value.ToString();
                ColorLbl.Text = row.Cells[3].Value.ToString();
                FuelTypeLbl.Text = row.Cells[4].Value.ToString();
                AvaLbl.Text = row.Cells[5].Value.ToString();
                TypeLbl.Text = row.Cells[6].Value.ToString();
                PriceLbl.Text = row.Cells[7].Value.ToString();
            }

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select image_path from car where car_id = '" + id + "'", con);
            string img = cm.ExecuteScalar().ToString();
            pictureBox1.Image = Image.FromFile(img);
            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ClearData()
        {
            IDLbl.Text = "";
            BrandLbl.Text = "";
            AvaLbl.Text = "";
            ColorLbl.Text = "";
            FuelTypeLbl.Text = "";
            ModelLbl.Text = "";
            TypeLbl.Text = "";
            PriceLbl.Text = "";
            pictureBox1.Image = null;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (IDLbl.Text.Trim() == "")
            {
                MessageBox.Show("Plese Select A Car First.", "Car Selection Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (AvaLbl.Text == "No")
            {
                MessageBox.Show("Car Not Availabile.", "Car Availability Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DateTime dateTimeVariable = DateTime.Now;
                //specifying text boxes and combo boxes to insert Car data's in Cart
                orderDetail OdrDts = new orderDetail();
                car CAR = new car();
                CAR.car_id = Convert.ToInt32(IDLbl.Text);
                CAR.availability = "No";
                CAR.updated_date = Convert.ToString(dateTimeVariable);       
                OdrDts.client_name = Login_Static.user_name.ToString();
                OdrDts.Item_Type = "CAR";
                OdrDts.Item_name = ModelLbl.Text;
                OdrDts.Item_id = Convert.ToInt32(IDLbl.Text);
                OdrDts.quantity = Convert.ToInt32("1");
                OdrDts.pricePerItem = Convert.ToInt32(PriceLbl.Text);
                OdrDts.total_qty_price = Convert.ToInt32("1") * Convert.ToInt32(PriceLbl.Text);
                ////transfering inputs to business logic layer
                BLL.OrderDetailsBLL.AddOrderDetail(OdrDts);
                CARBLL.UpdateCarAva(CAR);
                //success message
                string message = "Item Successfully Added To Your Cart !";
                string title = "Success Message";
                MessageBox.Show(message, title);
                list = CARBLL.GetCars();
                dataGridView1.DataSource = list;
                ClearData();

            }
        }




        private void PriceLbl_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
