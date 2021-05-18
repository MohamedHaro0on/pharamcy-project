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
    public partial class MedicineStockForm : Form
    {
        public MedicineStockForm()
        {
            InitializeComponent();
        }

        private void MedicineName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {

        }

        private void sellingPrice_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            InventoryForm v = new InventoryForm();
            v.Show();
            this.Hide();

        }
    }
}
