using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DTO;

namespace ABC_Car_Traders.Admin_Forms
{
    public partial class FrmAccSettings : Form
    {
        public FrmAccSettings()
        {
            InitializeComponent();
        }

        private void FrmAccSettings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Login_Static.user_name.ToString();
            textBox2.Text = Login_Static.Password.ToString();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            login LOGIN = new login();
            LOGIN.login_id = Login_Static.LoginID;
            LOGIN.user_name = textBox1.Text;
            LOGIN.password = textBox2.Text;
            LoginBLL.UpdateLogin(LOGIN);
            MessageBox.Show("Account Has Been Updated Successfully!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
