using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ABC_Car_Traders
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-------Validation Start------ -
            if (textname.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter a UserName", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textname.Focus();
            }

            else if (textmail.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Email", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textname.Focus();
            }

            else if (textaddress.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Address", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textname.Focus();
            }

            else if (textmobile.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Your Mobile Number", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textname.Focus();
            }

            else if (textpassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Password", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textname.Focus();
            }

            //-------Validation End-------

            else
            {
                try
                {
                    //Connecting DB Table Client &Login via DAL
                    client CLT = new client();
                    login LOGIN = new login();

                    LOGIN.user_name = textname.Text;
                    LOGIN.password = textpassword.Text;
                    LOGIN.isAdmin = false;
                    //this variable created to return client login data's from login table via BLL and add new login.
                    var loginData = BLL.LoginBLL.AddLogins(LOGIN);

                    CLT.clt_email = textmail.Text;
                    CLT.clt_address = textaddress.Text;
                    CLT.clt_mobileNumber = textmobile.Text;
                    CLT.clt_registered_date = DateTime.Now;
                    CLT.clt_updated_date = Convert.ToString("not yet");
                    CLT.login_id = loginData.login_id;

                    //transfering inputs to business logic layer
                    BLL.ClientBLL.AddClient(CLT);
                    //success message
                    MessageBox.Show("Your Account has been Successfully Created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    FrmLogin f1 = new FrmLogin();
                    f1.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                //MessageBox.Show("Sorry, an unexpected error occurred. Please Try Again or Contact our Customer Service Representative ", "Registration Faild", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bg_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmRegister_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
