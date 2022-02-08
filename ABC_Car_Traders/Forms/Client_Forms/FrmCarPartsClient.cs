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
    public partial class FrmCarPartsClient : Form
    {
        public FrmCarPartsClient()
        {
            InitializeComponent();
        }

        List<sparepart> list = new List<sparepart>();
        private void FrmCarPartsClient_Load(object sender, EventArgs e)
        {
            list = CarPartsBLL.GetCarParts();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[2].HeaderText = "Menufecturer";
            dataGridView1.Columns[3].HeaderText = "Warrenty";
            dataGridView1.Columns[4].HeaderText = "Price";
            dataGridView1.Columns[5].HeaderText = "Qty Available";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }
        

        //private void QtyOrderControl()
        //{
        //    try
        //    {
        //        var Avaqty = Convert.ToInt32(Qtylbl.Text);
        //        var qtyNeed = Convert.ToInt32(textBox1.Text);

        //        if (Avaqty <= qtyNeed)
        //        {
        //            string message = "Sorry, Currently We Don't have the Number's of Qty's that you Needed. Kindly, add lower number than available Qty.";
        //            string title = "Success Message";
        //            MessageBox.Show(message, title);
        //            textBox1.Focus();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }

        //}

        private void QtyAvaCheck()
        {
            if (Qtylbl.Text == "0")
                Qtylbl.Text = "Out of Stock";
        }


        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Spare Part by Name.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
            
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Spare Part by Name.....";

                SearchTbox.ForeColor = Color.Silver;

                dataGridView1.DataSource = list;
            }
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
            adapt = new SqlDataAdapter("select * from sparepart where part_name like '" + SearchTbox.Text + "%'", sqlCon);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDLbl.Text = row.Cells[0].Value.ToString();
                NameLbl.Text = row.Cells[1].Value.ToString();
                MenuLbl.Text = row.Cells[2].Value.ToString();
                Warrtylbl.Text = row.Cells[3].Value.ToString();
                PriceLbl.Text = row.Cells[4].Value.ToString();
                Qtylbl.Text = row.Cells[5].Value.ToString();
            }

            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue);
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");
            con.Open();
            SqlCommand cm = new SqlCommand("select image_path from sparepart where part_id = '" + id + "'", con);
            string img = cm.ExecuteScalar().ToString();
            pictureBox1.Image = Image.FromFile(img);
            con.Close();
            QtyAvaCheck();


        }

        private void ClearData()
        {
            IDLbl.Text = "";
            NameLbl.Text = "";
            MenuLbl.Text = "";
            Warrtylbl.Text = "";
            PriceLbl.Text = "";
            Qtylbl.Text = "";
            pictureBox1.Image = null;
            textBox1.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (IDLbl.Text.Trim() == "")
            {
                MessageBox.Show("Plese Select A Spare Part First.");
            }

            else if (Qtylbl.Text.Trim() == "Out of Stock")
            {
                MessageBox.Show("Sorry, Selected Spare Part Currently Not Availabile");
            }

            else if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please Select the Number of Qty You Needed");
            }

            else
            {

                var Avaqty = Convert.ToInt32(Qtylbl.Text);
                var qtyNeed = Convert.ToInt32(textBox1.Text);

                if (Avaqty <= qtyNeed)
                {
                    string message = "Sorry, Currently We Don't have the Number's of Qty's that you Needed. Kindly, add lower number than available Qty.";
                    string title = "Success Message";
                    MessageBox.Show(message, title);
                    textBox1.Focus();
                }

               
                else
                {
                    try
                    {
                        int AVAQTY = 0;
                        int TOTALQTYPRICE = 0;
                        int QtyPrice = Convert.ToInt32(PriceLbl.Text);
                        int AvAqty = Convert.ToInt32(Qtylbl.Text);
                        int QtYNeed = Convert.ToInt32(textBox1.Text);
                        AVAQTY = AvAqty - QtYNeed;
                        TOTALQTYPRICE = QtYNeed * QtyPrice;

                        DateTime dateTimeVariable = DateTime.Now;
                        //specifying text boxes and combo boxes to insert Car data's in Cart
                        orderDetail OdrDts = new orderDetail();
                        sparepart CARPART = new sparepart();
                        CARPART.part_id = Convert.ToInt32(IDLbl.Text);
                        CARPART.part_quentity = Convert.ToInt32(AVAQTY);
                        CARPART.date_updated = Convert.ToString(dateTimeVariable);
                        OdrDts.client_name = Login_Static.user_name.ToString();
                        OdrDts.Item_Type = "Spare Part";
                        OdrDts.Item_name = NameLbl.Text;
                        OdrDts.Item_id = Convert.ToInt32(IDLbl.Text);
                        OdrDts.quantity = Convert.ToInt32(textBox1.Text);
                        OdrDts.pricePerItem = Convert.ToInt32(PriceLbl.Text);
                        OdrDts.total_qty_price = Convert.ToInt32(TOTALQTYPRICE);
                        //////transfering inputs to business logic layer
                        BLL.OrderDetailsBLL.AddOrderDetail(OdrDts);
                        CarPartsBLL.UpdateCarPartQty(CARPART);
                        ////success message
                        string message = "Item Successfully Added To Your Cart !";
                        string title = "Success Message";
                        MessageBox.Show(message, title);
                        list = CarPartsBLL.GetCarParts();
                        dataGridView1.DataSource = list;
                        ClearData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
