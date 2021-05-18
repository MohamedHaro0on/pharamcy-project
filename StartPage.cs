using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StartPage : Form
    {
        int startPoint = 0;

        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            bunifuCircleProgressbar1.Value = startPoint;
            if (bunifuCircleProgressbar1.Value == 100 )
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                LoginForm myLogin = new LoginForm();
                this.Hide();
                myLogin.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
