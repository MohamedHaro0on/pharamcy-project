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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
        MedicineStockForm st = new MedicineStockForm();
        private void button2_Click(object sender, EventArgs e)
        {
            st.Show();
            this.Hide();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
        MedicineStockForm Ms = new MedicineStockForm();
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            Ms.Show();
            this.Hide();
        }

        private void gunaButton3_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }
    }
}
