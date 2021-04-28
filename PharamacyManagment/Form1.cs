using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharamacyManagment
{
    public partial class Form1 : Form
    {
        int startPoint = 0;

        public Form1()
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
                Login myLogin = new Login();
                this.Hide();
                myLogin.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
