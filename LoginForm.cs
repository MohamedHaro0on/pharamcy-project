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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            if(UserName.Text == "admin" && Password.Text == "admin")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password !");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
