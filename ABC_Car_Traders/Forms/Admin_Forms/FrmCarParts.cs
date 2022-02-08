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
    public partial class FrmCarParts : Form
    {
        public FrmCarParts()
        {

            InitializeComponent();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            partnamebox.Text = "";
            menfebox.Text = "";
            pricebox.Text = "";
            qantibox.Text = "";
            warrentybox.Text = "";
            ImgPathTextBox.Text = "";
            pictureBox1.Image = null;

        }

        List<sparepart> list = new List<sparepart>();

        void FillAllData()
        {
            list = CarPartsBLL.GetCarParts();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Part ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Menufecturer";
            dataGridView1.Columns[3].HeaderText = "Warrenty";
            dataGridView1.Columns[4].HeaderText = "Price";
            dataGridView1.Columns[5].HeaderText = "Quantity";
            dataGridView1.Columns[6].HeaderText = "Img Path";
            dataGridView1.Columns[7].HeaderText = "Added Date";
            dataGridView1.Columns[8].HeaderText = "Updated Date";
        }



        private void FrmCarParts_Load(object sender, EventArgs e)
        {

            FillAllData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
               {
                 pictureBox1.Load(openFileDialog1.FileName);
                 ImgPathTextBox.Text = openFileDialog1.FileName;
                }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                partnamebox.Text = row.Cells[1].Value.ToString();
                menfebox.Text = row.Cells[2].Value.ToString();
                warrentybox.Text = row.Cells[3].Value.ToString();
                pricebox.Text = row.Cells[4].Value.ToString();
                qantibox.Text = row.Cells[5].Value.ToString();
                ImgPathTextBox.Text = row.Cells[6].Value.ToString();
                ImgPathTextBox.Text = row.Cells[6].Value.ToString();

            }

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select image_path from sparepart where part_id = '" + id + "'", con);
            string img = cm.ExecuteScalar().ToString();
            pictureBox1.Image = System.Drawing.Image.FromFile(img);
            con.Close();
        }

        private void FuelLbl_Click(object sender, EventArgs e)
        {

        }

        private void ImgPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            //-------Validation Start-------
            if (partnamebox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Spare Part Name", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                partnamebox.Focus();
            }

            else if (pricebox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Spare Part Price", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                partnamebox.Focus();
            }

            else if (warrentybox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Spare Part Warrenty", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                warrentybox.Focus();
            }

            else if (menfebox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Spare Pare Menufecturer", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                menfebox.Focus();
            }

            else if (qantibox.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Spare Pare Quantity", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                qantibox.Focus();
            }

            else if (ImgPathTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please Select a Spare Part Image", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else if (pictureBox1 == null || pictureBox1.Image == null)
            {
                MessageBox.Show("Please Select a Spare Part Image", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                partnamebox.Focus();
            }

            //-------Validation End-------

            else
            {
                try
                {

                    //specifying text boxes and combo boxes to insert CarPart data's
                    sparepart CARPART = new sparepart();
                    CARPART.part_name = partnamebox.Text;
                    CARPART.part_menufecturer = menfebox.Text;
                    CARPART.part_warrenty = warrentybox.Text;
                    CARPART.part_price = Convert.ToInt32(pricebox.Text);
                    CARPART.part_quentity = Convert.ToInt32(qantibox.Text);
                    CARPART.image_path = ImgPathTextBox.Text;
                    CARPART.date_added = DateTime.Now;
                    CARPART.date_updated = Convert.ToString("not yet");
                    //transfering inputs to business logic layer
                    CarPartsBLL.AddCarPart(CARPART);
                    //success message
                    MessageBox.Show("Car has been added Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    list = CarPartsBLL.GetCarParts();
                    dataGridView1.DataSource = list;
                    partnamebox.Focus();
                    ClearData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
                MessageBox.Show("Select a Spare Part to Update");

            else if (partnamebox.Text.Trim() == "")
                MessageBox.Show("Enter Spare Part Name");

            else if (warrentybox.Text.Trim() == "")
                MessageBox.Show("Enter Spare Part Warrenty");

            else if (qantibox.Text.Trim() == "")
                MessageBox.Show("Enter Spare Part Quantity");

            else if (menfebox.Text.Trim() == "")
                MessageBox.Show("Enter Spare Part Menufecturer");

            else if (pricebox.Text.Trim() == "")
                MessageBox.Show("Enter Selling Price");

            else if (ImgPathTextBox.Text.Trim() == "")
                MessageBox.Show("Select a Car Image");

            else
            {
                DateTime dateTimeVariable = DateTime.Now;
                sparepart CARPART = new sparepart();
                CARPART.part_id = Convert.ToInt32(textBox1.Text);
                CARPART.image_path = ImgPathTextBox.Text;
                CARPART.part_name = partnamebox.Text;
                CARPART.part_menufecturer = menfebox.Text;
                CARPART.part_warrenty = warrentybox.Text;
                CARPART.part_price = Convert.ToInt32(pricebox.Text);
                CARPART.part_quentity = Convert.ToInt32(qantibox.Text);
                CARPART.date_updated = Convert.ToString(dateTimeVariable);
                CarPartsBLL.UpdateCarPart(CARPART);
                MessageBox.Show("Car Has Been Updated Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                list = CarPartsBLL.GetCarParts();
                dataGridView1.DataSource = list;
                partnamebox.Focus();
                ClearData();


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Select a Spare Part to Delete", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this Spare Part", "Warning!!", MessageBoxButtons.YesNo);
                try
                {
                    sparepart CARPART = new sparepart();
                    CARPART.part_id = Convert.ToInt32(textBox1.Text);
                    BLL.CarPartsBLL.DeleteCarPart(CARPART);
                    MessageBox.Show("SparePart was Deleted");
                    list = CarPartsBLL.GetCarParts();
                    dataGridView1.DataSource = list;
                    partnamebox.Focus();
                    ClearData();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Car Part.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Car Part.....";

                SearchTbox.ForeColor = Color.Silver;

                dataGridView1.DataSource = list;

            }
        }

        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {
            string cs = (@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");
            SqlConnection sqlCon;
            SqlDataAdapter adapt;
            DataTable dt;
            sqlCon = new SqlConnection(cs);
            sqlCon.Open();
            adapt = new SqlDataAdapter("select * from sparepart where part_name like '" + SearchTbox.Text + "%'", sqlCon);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToPDF.PdfExport(dataGridView1);
        }

        private void pricebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void qantibox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
