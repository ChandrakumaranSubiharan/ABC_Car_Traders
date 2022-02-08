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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Client by Name.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Client by Name.....";

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
            adapt = new SqlDataAdapter("select * from client where clt_name like '" + SearchTbox.Text + "%'", sqlCon);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlCon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (idbox.Text.Trim() == "")
            {
                MessageBox.Show("Select a Client to Delete", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to Remove this Client", "Warning!!", MessageBoxButtons.YesNo);
                try
                {
                    client CLR = new client();
                    CLR.clt_id = Convert.ToInt32(idbox.Text);
                    ClientBLL.DeleteClient(CLR);
                    MessageBox.Show("Client was Deleted");
                    list = ClientBLL.GetClients();
                    dataGridView1.DataSource = list;
                    Namebox.Focus();
                    ClearData();
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



        List<client> list = new List<client>();
        private void FrmClient_Load(object sender, EventArgs e)
        {
            list = ClientBLL.GetClients();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Client ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Mobile Number";
            dataGridView1.Columns[4].HeaderText = "Registred Date";
            dataGridView1.Columns[5].HeaderText = "Updated Date";

        }

        private void ClearData()
        {
            idbox.Text = "";
            Namebox.Text = "";
            MobileNum.Text = "";
            Address.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Namebox.Text.Trim() == "")
                MessageBox.Show("Enter Name to Update");

            else if (Address.Text.Trim() == "")
                MessageBox.Show("Enter Address to Update");

            else if (MobileNum.Text.Trim() == "")
                MessageBox.Show("Enter Mobile Number to Update");
            else
            {
                DateTime dateTimeVariable = DateTime.Now;
                client CLT = new client();
                CLT.clt_id = Convert.ToInt32(idbox.Text);
                //CLT.clt_name = Namebox.Text; //change
                CLT.clt_address = Address.Text;
                CLT.clt_mobileNumber = MobileNum.Text;
                CLT.clt_updated_date = Convert.ToString(dateTimeVariable);
                ClientBLL.UpdateClient(CLT);
                MessageBox.Show("Client Has Been Updated Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                list = ClientBLL.GetClients();
                dataGridView1.DataSource = list;
                Namebox.Focus();
                ClearData();
            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idbox.Text = row.Cells[0].Value.ToString();
                Namebox.Text = row.Cells[1].Value.ToString();
                Address.Text = row.Cells[2].Value.ToString();
                MobileNum.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            ExportToPDF.PdfExport(dataGridView1);
        }

        private void MobileNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void MobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
