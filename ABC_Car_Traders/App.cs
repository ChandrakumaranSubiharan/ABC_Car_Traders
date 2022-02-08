using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void lod_timer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 700)
            {
                lod_timer.Stop();
                this.Hide();
                new FrmLogin().Show();
            }
        }

        private void App_Load(object sender, EventArgs e)
        {

        }
    }
}
