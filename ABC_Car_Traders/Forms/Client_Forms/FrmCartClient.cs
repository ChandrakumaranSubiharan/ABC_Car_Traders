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
using BLL;
using DAL;
using DAL.DTO;

namespace ABC_Car_Traders.Client_Forms
{
    public partial class FrmCartClient : Form
    {
        public FrmCartClient()
        {
            InitializeComponent();
        }

        List<orderDetail> list = new List<orderDetail>();
        private void FrmCartClient_Load(object sender, EventArgs e)
        {
            List<orderDetail> ClientCartOrderDetaillist = OrderDetailsBLL.GetOrderDetails(Login_Static.user_name);
            dataGridView1.DataSource = ClientCartOrderDetaillist;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Item ID";
            dataGridView1.Columns[2].HeaderText = "Item Name";
            dataGridView1.Columns[3].HeaderText = "Item Type";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "Qty";
            dataGridView1.Columns[6].HeaderText = "Price Per Qty(LKR)";
            dataGridView1.Columns[7].HeaderText = "Total Price For Qty's(LKR)";
            TotalAmount();
        }

        private void TotalAmount()
        {
            int total = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells[7].Value));
            textBox4.Text = total.ToString();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDTbox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void ClearData()
        {
            IDTbox.Text = "ITEM ID";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IDTbox.Text.Trim() == "ITEM ID")
            {
                MessageBox.Show("Please Select The Item You Wanted To Remove From Cart.", "Item Selection Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are You Sure To Remove this Item From Cart !", "Item Removing Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        orderDetail OdrDts = new orderDetail();
                        OdrDts.Item_id = Convert.ToInt32(IDTbox.Text);
                        OrderDetailsBLL.DeleteOrderDetail(OdrDts);
                        MessageBox.Show("Item was Removed");
                        List<orderDetail> ClientCartOrderDetaillist = OrderDetailsBLL.GetOrderDetails(Login_Static.user_name);
                        dataGridView1.DataSource = ClientCartOrderDetaillist;
                        TotalAmount();
                        ClearData();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void IDTbox_Enter(object sender, EventArgs e)
        {

        }

        private void IDTbox_Leave(object sender, EventArgs e)
        {

        }

        private void IDTbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
