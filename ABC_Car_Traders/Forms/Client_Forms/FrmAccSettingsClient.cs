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
    public partial class FrmAccSettingsClient : Form
    {
        public FrmAccSettingsClient()
        {
            InitializeComponent();
        }

        private void FrmAccSettingsClient_Load(object sender, EventArgs e)
        {
            UserNameBox.Text = Login_Static.user_name.ToString();
            PasswordBox.Text = Login_Static.Password.ToString();
            AddressBox.Text = Login_Static.Address.ToString();
            MobileNumberBox.Text = Login_Static.MobileNumber.ToString();
            EmailBox.Text = Login_Static.Email.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
