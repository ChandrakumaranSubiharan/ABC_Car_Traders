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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRegister().Show();
        }

        private void bg_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogn_Click(object sender, EventArgs e)
        {
            //-------Validation Start------//
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter User Name", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }

            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Password", "Input Empty Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            //-------Validation End------//


            else
            {
                List<login> loginlist = LoginBLL.GetLogins(textBox1.Text, textBox2.Text);
                if (loginlist.Count == 0)
                {
                    MessageBox.Show("UserName or Password is Incorrect. Please Check Your Username/Password and Try Again.", "Input Incorrect Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                }
                else
                {
                    login LOGIN = new login();

                    LOGIN = loginlist.First();

                    Login_Static.LoginID = LOGIN.login_id;
                    Login_Static.user_name = LOGIN.user_name;
                    Login_Static.Password = LOGIN.password;
                    Login_Static.isAdmin = Convert.ToBoolean(LOGIN.isAdmin);

                    //if the input is equals to admin true below code will run 
                    if (Login_Static.isAdmin == true)
                    {
                        this.Hide();
                        new FrmMainMenuAdmin().Show();
                    }

                    //if the input is not-equals to admin true below code will run 
                    else
                    {
                        client CLT = new client();
                        CLT = ClientBLL.GetClients().First(c => c.login_id == LOGIN.login_id);
                        Login_Static.Address = CLT.clt_address;
                        Login_Static.Email = CLT.clt_email;
                        Login_Static.MobileNumber = CLT.clt_mobileNumber;
                        this.Hide();
                        new Client_Forms.FrmMainMenuClient().Show();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bg_Click(object sender, EventArgs e)
        {

        }
    }
}
