using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders.Client_Forms
{
    public partial class FrmOrdersClient : Form
    {
        public FrmOrdersClient()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Orders.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Orders.....";

                SearchTbox.ForeColor = Color.Silver;
            }
        }

        private void FrmOrdersClient_Load(object sender, EventArgs e)
        {

        }
    }
}
