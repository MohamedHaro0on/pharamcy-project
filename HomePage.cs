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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        InventoryForm ven = new InventoryForm();
        SyndicateForm sy = new SyndicateForm();
        MedicationReportForm MR = new MedicationReportForm();
        BillingForm b = new BillingForm();
        

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            ven.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
            sy.Show();
            this.Hide();
        }

        private void gunaImageButton4_Click(object sender, EventArgs e)
        {
            MR.Show();
            this.Hide();
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            b.Show();
            this.Hide();
        }
    }
}
