using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class MedicineStockForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mohamed Haroon\OneDrive\Documents\PharamacySystem_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void Populate()
        {
            Con.Open();
            string Query = "select * from MedicineStock_tb";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            medicineGridView.ReadOnly = true;
            medicineGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private bool Validated()
        {
            if (medicineNameTb.Text == "" || buyingPriceTb.Text == "" || sellingPriceTb.Text == "" || expireDateTb.Text == "" || companyTb.SelectedItem == null)
            {
                MessageBox.Show("Fill All the Inputs !");
            }
            else if (!Regex.IsMatch(medicineNameTb.Text, "^[A-Z][a-zA-Z]*$") || !Regex.IsMatch(companyTb.Text, "^[A-Z][a-zA-Z]*$"))
            {
                MessageBox.Show("Please enter only String Charachters");
            }
            // This will return true if input is all numbers.

            else if (!Regex.IsMatch(buyingPriceTb.Text, @"^\d+$") || !Regex.IsMatch(sellingPriceTb.Text, @"^\d+$") || !Regex.IsMatch(quantatiyTb.Text, @"^\d+$"))
            {
                MessageBox.Show("Please Enter a Numric Value! ");
            }
            else if (int.Parse(sellingPriceTb.Text) <= int.Parse(buyingPriceTb.Text))
            {
                MessageBox.Show("The Selling Price is less than or equal to the Buying Price !");
            }
            else
            {
                return true; 
            }
            return false;
        }



        public MedicineStockForm()
        {
            InitializeComponent();
        }

        private void MedicineName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void sellingPrice_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            medicineNameTb.Text = medicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            buyingPriceTb.Text = medicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            sellingPriceTb.Text = medicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            quantatiyTb.Text = medicineGridView.SelectedRows[0].Cells[3].Value.ToString();
            companyTb.ValueMember = medicineGridView.SelectedRows[0].Cells[5].ToString() ;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            InventoryForm v = new InventoryForm();
            v.Show();
            this.Hide();

        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand($"insert into MedicineStock_tb values('{medicineNameTb.Text}',{buyingPriceTb.Text},{sellingPriceTb.Text},{quantatiyTb.Text},'{expireDateTb.Text}','{companyTb.SelectedItem.ToString()}')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added!!");
                Con.Close();
                Populate();
            }
 
        }

        private void updateMedicine_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                Con.Open();
                string updateQuery = "UPDATE MedicineStock_tb SET buyingPrice=" + buyingPriceTb.Text + ",sellingPrice=" + sellingPriceTb.Text + ",quantity=" + quantatiyTb.Text + " ,expireDate='" + expireDateTb.Text + "',company='" + companyTb.SelectedItem.ToString() + "' WHERE medicineName='" + medicineNameTb.Text + "';";
                SqlCommand updateCmd = new SqlCommand(updateQuery, Con);
                updateCmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Has been Updated ");
                Con.Close();
                Populate();

            }

        }

        private void deleteMedicine_Click(object sender, EventArgs e)
        {
            if (Validated())
            {
                Con.Open();
                string deleteQuery = $"delete from MedicineStock_tb where medicineName= '{medicineNameTb.Text}';";
                SqlCommand cmd = new SqlCommand(deleteQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Has Been Deleted");
                Con.Close();
                Populate();
            }
        }
    }
}
