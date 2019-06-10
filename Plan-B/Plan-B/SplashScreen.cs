using System;
using System.Windows.Forms;

namespace Plan_B
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if (panel2.Width >= 340)
            {

                timer1.Stop();
                Auth auth = new Auth();
                auth.Show();
                this.Hide();
            }
        }
    }
}
