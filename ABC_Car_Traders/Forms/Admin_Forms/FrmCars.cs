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

namespace ABC_Car_Traders.Admin_Forms
{
    public partial class FrmCars : Form
    {

        public FrmCars()
        {
            InitializeComponent();
        }


        List<CarDetailsDTO> list = new List<CarDetailsDTO>();
        CarDetailsDTO detail = new CarDetailsDTO();

        private void Car_Load(object sender, EventArgs e)
        {


            //listing CAR Table data's to datagridview with colomn modification
            list = CARBLL.GetCars();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Car ID";
            dataGridView1.Columns[1].HeaderText = "Model";
            dataGridView1.Columns[2].HeaderText = "Brand";
            dataGridView1.Columns[3].HeaderText = "Color";
            dataGridView1.Columns[4].HeaderText = "Fuel";
            dataGridView1.Columns[5].HeaderText = "Availability";
            dataGridView1.Columns[6].HeaderText = "Type";
            dataGridView1.Columns[7].HeaderText = "Price";
            dataGridView1.Columns[8].HeaderText = "Added Date";
            dataGridView1.Columns[9].HeaderText = "Img Path";
            dataGridView1.Columns[10].HeaderText = "Updated Date";
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
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Select a Car to Update");

            else if (ModelNotextBox.Text.Trim() == "")
                MessageBox.Show("Enter Model Name");

            else if (BrandCombo.SelectedIndex == -1)
                MessageBox.Show("Select a Brand");

            else if (avacombo.SelectedIndex == -1)
                MessageBox.Show("Select Availability");

            else if (fuelcombo.SelectedIndex == -1)
                MessageBox.Show("Select Fuel Type");

            else if (fuelcombo.SelectedIndex == -1)
                MessageBox.Show("Select Car Type");

            else if (colorTextBox.Text.Trim() == "")
                MessageBox.Show("Enter Car Color");

            else if (ModelNotextBox.Text.Trim() == "")
                MessageBox.Show("Enter Selling Price");

            else if (ImgPathTextBox.Text.Trim() == "")
                MessageBox.Show("Select a Car Image");

            else
            {
                DateTime dateTimeVariable = DateTime.Now;
                car CAR = new car();
                CAR.car_id = Convert.ToInt32(textBox1.Text);
                CAR.image_path = ImgPathTextBox.Text;
                CAR.modelname = ModelNotextBox.Text;
                CAR.brand = BrandCombo.Text;
                CAR.color = colorTextBox.Text;
                CAR.availability = avacombo.Text;
                CAR.fueltype = fuelcombo.Text;
                CAR.price = Convert.ToInt32(PriceTbox.Text);
                CAR.type = VehicleTypeCombo.Text;
                CAR.updated_date = Convert.ToString(dateTimeVariable);
                CARBLL.UpdateCar(CAR);
                MessageBox.Show("Car Has Been Updated Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                list = CARBLL.GetCars();
                dataGridView1.DataSource = list;
                ModelNotextBox.Focus();
                ClearData();
            }


        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                dataGridView1.DataSource = list;

            }
        }

        private void ClearData()
        {
            textBox1.Text = "";
            ModelNotextBox.Text = "";
            BrandCombo.SelectedIndex = -1;
            colorTextBox.Text = "";
            avacombo.SelectedIndex = -1;
            fuelcombo.SelectedIndex = -1;
            PriceTbox.Text = "";
            ImgPathTextBox.Text = "";
            VehicleTypeCombo.SelectedIndex = -1;
            pictureBox1.Image = null;

        }


        //Car Adding
        private void btnCreate_Click(object sender, EventArgs e)
        {


            //-------Validation Start-------
            if (ModelNotextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Car Model Name", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (BrandCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Car Brand Name", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (ImgPathTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a Car Image", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (avacombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Car Availability", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (fuelcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Car Fuel Type", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (VehicleTypeCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Car Type", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (colorTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Car Color", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (PriceTbox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Car Selling Price", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            else if (pictureBox1 == null || pictureBox1.Image == null)
            {
                MessageBox.Show("Please Select a Car Image", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ModelNotextBox.Focus();
            }

            //-------Validation End-------

            else
            {
                try
                {
                    //specifying text boxes and combo boxes to insert Car data's
                    car CAR = new car();
                    CAR.modelname = ModelNotextBox.Text;
                    CAR.brand = BrandCombo.Text;
                    CAR.color = colorTextBox.Text;
                    CAR.availability = avacombo.Text;
                    CAR.fueltype = fuelcombo.Text;
                    CAR.price = Convert.ToInt32(PriceTbox.Text);
                    CAR.type = VehicleTypeCombo.Text;
                    CAR.image_path = ImgPathTextBox.Text;
                    CAR.added_date = DateTime.Now;
                    CAR.updated_date = Convert.ToString("not yet");
                    File.Copy(ImgPathTextBox.Text, Path.Combine(@"E:\BEng Degree Documents\Top-Up\Application Development\Flat Design System\ABC_Car_Traders\ABC_Car_Traders\Resources\Cars\", Path.GetFileName(ImgPathTextBox.Text)), true);
                    //transfering inputs to business logic layer
                    var result = BLL.CARBLL.AddCar(CAR);

                    if(!result)
                    {
                        MessageBox.Show("Failed to add car", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    }
                    else
                    {
                        //success message
                        MessageBox.Show("Car has been added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        list = CARBLL.GetCars();
                        dataGridView1.DataSource = list;
                        ModelNotextBox.Focus();
                        ClearData();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                ImgPathTextBox.Text = openFileDialog1.FileName;
            }
        }




        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //    textBox1.Text = row.Cells[0].Value.ToString();
            //    ModelNotextBox.Text = row.Cells[1].Value.ToString();
            //    BrandCombo.Text = row.Cells[2].Value.ToString();
            //    colorTextBox.Text = row.Cells[3].Value.ToString();
            //    fuelcombo.Text = row.Cells[4].Value.ToString();
            //    avacombo.Text = row.Cells[5].Value.ToString();
            //    VehicleTypeCombo.Text = row.Cells[6].Value.ToString();
            //    PriceTbox.Text = row.Cells[7].Value.ToString();
            //    ImgPathTextBox.Text = row.Cells[9].Value.ToString();
            //}

            //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");
            //con.Open();
            //SqlCommand cm = new SqlCommand ("select image_path from car where car_id = '"+id+"'",con);
            //string img = cm.ExecuteScalar().ToString();
            //pictureBox1.Image = Image.FromFile(img);
            //con.Close();

        }

        private void typeLbl_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Select a Car to Delete", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to delete this Car !", "Car Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        car CAR = new car();
                        CAR.car_id = Convert.ToInt32(textBox1.Text);
                        BLL.CARBLL.DeleteCar(CAR);
                        MessageBox.Show("Car was Deleted");
                        list = CARBLL.GetCars();
                        dataGridView1.DataSource = list;
                        ModelNotextBox.Focus();
                        ClearData();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToPDF.PdfExport(dataGridView1);
        }

        private void PriceTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
