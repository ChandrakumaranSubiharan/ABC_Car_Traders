using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders.Client_Forms
{
    public partial class FrmMainMenuClient : Form
    {

        //Fields
        private Button currentButton;
        private Form activeForm;

        //Constructor
        public FrmMainMenuClient()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.WhiteSmoke;
                    currentButton.ForeColor = Color.FromArgb(0, 144, 255);
                    currentButton.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1title_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btncars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client_Forms.FrmCarsClient(), sender);
        }
       

        private void Reset()
        {
            DisableButton();
            btnDashboard.BackColor = Color.WhiteSmoke;
            btnDashboard.ForeColor = Color.FromArgb(0, 144, 255);
            btnDashboard.Font = new System.Drawing.Font("Open Sans SemiBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnCarParts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client_Forms.FrmCarPartsClient(), sender);
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client_Forms.FrmCartClient(), sender);

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client_Forms.FrmAccSettingsClient(), sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Client_Forms.FrmOrdersClient(), sender);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmLogin().Show();
        }

        private void FrmMainMenuClient_Load(object sender, EventArgs e)
        {
            UserRoleLbl.Text = Login_Static.user_name.ToString();
        }
    }
}
