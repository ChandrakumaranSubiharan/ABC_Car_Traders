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
    public partial class FrmCarParts : Form
    {
        public FrmCarParts()
        {
            InitializeComponent();
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
            }
        }

        private void SearchTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCarParts_Load(object sender, EventArgs e)
        {

        }
    }
}
