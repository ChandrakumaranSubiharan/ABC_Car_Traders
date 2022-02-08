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
    public partial class FrmOrders : Form
    {
        public FrmOrders()
        {
            InitializeComponent();
        }

        private void MNlbl_Click(object sender, EventArgs e)
        {

        }

        private void ModelNotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        List<order> list = new List<order>();

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            list = OrderBLL.GetOrder();
            dataGridView2.DataSource = list;
            dataGridView2.Columns[0].HeaderText = "Order ID";
            dataGridView2.Columns[1].HeaderText = "Status";
            dataGridView2.Columns[2].HeaderText = "Date Added";
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            //dataGridView2.Columns[3].HeaderText = "Quantitiy";
            //dataGridView2.Columns[4].HeaderText = "Price Per Unit";
            //dataGridView2.Columns[5].HeaderText = "Total Amount";
            //dataGridView2.Columns[5].HeaderText = "Payment Type";
        }

        private void OrderIDCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Order by Clt Name.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Order by Clt Name.....";

                SearchTbox.ForeColor = Color.Silver;
            }
        }

        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {

            ////Connection String  
            string cs = (@"Data Source=DESKTOP-7HINSPN\SUBIHARAN;Initial Catalog=abc_car_traders;Integrated Security=True");

            SqlConnection sqlCon;
            SqlDataAdapter adapt;
            DataTable dt;

            sqlCon = new SqlConnection(cs);
            sqlCon.Open();
            adapt = new SqlDataAdapter("select * from order where order_id like '" + SearchTbox.Text + "%'", sqlCon);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView2.DataSource = dt;
            sqlCon.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            OrderIDCombo.Text = "";
            clientBox.Text = "";
            paymentbox.Text = "";
            statusbox.Text = "";
            quanbox.Text = "";
            amubox.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExportToPDF.PdfExport(dataGridView2);
        }
    }
}
