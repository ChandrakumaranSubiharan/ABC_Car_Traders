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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void SearchTbox_Enter(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "  Search Client.....")
            {
                SearchTbox.Text = "";

                SearchTbox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void SearchTbox_Leave(object sender, EventArgs e)
        {
            if (SearchTbox.Text == "")
            {
                SearchTbox.Text = "  Search Client.....";

                SearchTbox.ForeColor = Color.Silver;
            }

        }
    }
}
