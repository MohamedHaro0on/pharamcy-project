
namespace WindowsFormsApp1
{
    partial class MedicineStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineStockForm));
            this.MedicinStock = new Guna.UI.WinForms.GunaLabel();
            this.medicineGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.medicineNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buyingPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellingPriceTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.quantatiyTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.expireDateTb = new Guna.UI.WinForms.GunaDateTimePicker();
            this.companyTb = new Guna.UI.WinForms.GunaComboBox();
            this.addMedicine = new Guna.UI.WinForms.GunaButton();
            this.deleteMedicine = new Guna.UI.WinForms.GunaButton();
            this.updateMedicine = new Guna.UI.WinForms.GunaButton();
            this.backBtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.medicineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicinStock
            // 
            this.MedicinStock.AutoSize = true;
            this.MedicinStock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinStock.ForeColor = System.Drawing.Color.Brown;
            this.MedicinStock.Location = new System.Drawing.Point(11, 12);
            this.MedicinStock.Name = "MedicinStock";
            this.MedicinStock.Size = new System.Drawing.Size(248, 45);
            this.MedicinStock.TabIndex = 0;
            this.MedicinStock.Text = "Medicine Stock";
            // 
            // medicineGridView
            // 
            this.medicineGridView.AllowUserToAddRows = false;
            this.medicineGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.medicineGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.medicineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medicineGridView.BackgroundColor = System.Drawing.Color.White;
            this.medicineGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.medicineGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicineGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicineGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.medicineGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicineGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.medicineGridView.EnableHeadersVisualStyles = false;
            this.medicineGridView.GridColor = System.Drawing.Color.Brown;
            this.medicineGridView.Location = new System.Drawing.Point(528, 12);
            this.medicineGridView.Name = "medicineGridView";
            this.medicineGridView.RowHeadersVisible = false;
            this.medicineGridView.RowTemplate.Height = 30;
            this.medicineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicineGridView.Size = new System.Drawing.Size(776, 712);
            this.medicineGridView.TabIndex = 1;
            this.medicineGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.medicineGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.medicineGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medicineGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medicineGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.medicineGridView.ThemeStyle.GridColor = System.Drawing.Color.Brown;
            this.medicineGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.medicineGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medicineGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medicineGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.medicineGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.medicineGridView.ThemeStyle.ReadOnly = false;
            this.medicineGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.medicineGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medicineGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.medicineGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Brown;
            this.medicineGridView.ThemeStyle.RowsStyle.Height = 30;
            this.medicineGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.medicineGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.medicineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // medicineNameTb
            // 
            this.medicineNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.medicineNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.medicineNameTb.ForeColor = System.Drawing.Color.Brown;
            this.medicineNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.medicineNameTb.HintText = "";
            this.medicineNameTb.isPassword = false;
            this.medicineNameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.medicineNameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.medicineNameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.medicineNameTb.LineThickness = 3;
            this.medicineNameTb.Location = new System.Drawing.Point(19, 96);
            this.medicineNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.medicineNameTb.Name = "medicineNameTb";
            this.medicineNameTb.Size = new System.Drawing.Size(209, 34);
            this.medicineNameTb.TabIndex = 2;
            this.medicineNameTb.Text = "Medicine Name";
            this.medicineNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.medicineNameTb.OnValueChanged += new System.EventHandler(this.MedicineName_OnValueChanged);
            // 
            // buyingPriceTb
            // 
            this.buyingPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buyingPriceTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buyingPriceTb.ForeColor = System.Drawing.Color.Brown;
            this.buyingPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.buyingPriceTb.HintText = "";
            this.buyingPriceTb.isPassword = false;
            this.buyingPriceTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.buyingPriceTb.LineIdleColor = System.Drawing.Color.Gray;
            this.buyingPriceTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.buyingPriceTb.LineThickness = 3;
            this.buyingPriceTb.Location = new System.Drawing.Point(285, 96);
            this.buyingPriceTb.Margin = new System.Windows.Forms.Padding(4);
            this.buyingPriceTb.Name = "buyingPriceTb";
            this.buyingPriceTb.Size = new System.Drawing.Size(209, 34);
            this.buyingPriceTb.TabIndex = 3;
            this.buyingPriceTb.Text = "Buying Price";
            this.buyingPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellingPriceTb
            // 
            this.sellingPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellingPriceTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellingPriceTb.ForeColor = System.Drawing.Color.Brown;
            this.sellingPriceTb.HintForeColor = System.Drawing.Color.Empty;
            this.sellingPriceTb.HintText = "";
            this.sellingPriceTb.isPassword = false;
            this.sellingPriceTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.sellingPriceTb.LineIdleColor = System.Drawing.Color.Gray;
            this.sellingPriceTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.sellingPriceTb.LineThickness = 3;
            this.sellingPriceTb.Location = new System.Drawing.Point(285, 183);
            this.sellingPriceTb.Margin = new System.Windows.Forms.Padding(4);
            this.sellingPriceTb.Name = "sellingPriceTb";
            this.sellingPriceTb.Size = new System.Drawing.Size(209, 34);
            this.sellingPriceTb.TabIndex = 5;
            this.sellingPriceTb.Text = "Selling Price";
            this.sellingPriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellingPriceTb.OnValueChanged += new System.EventHandler(this.sellingPrice_OnValueChanged);
            // 
            // quantatiyTb
            // 
            this.quantatiyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantatiyTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantatiyTb.ForeColor = System.Drawing.Color.Brown;
            this.quantatiyTb.HintForeColor = System.Drawing.Color.Empty;
            this.quantatiyTb.HintText = "";
            this.quantatiyTb.isPassword = false;
            this.quantatiyTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.quantatiyTb.LineIdleColor = System.Drawing.Color.Gray;
            this.quantatiyTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.quantatiyTb.LineThickness = 3;
            this.quantatiyTb.Location = new System.Drawing.Point(285, 279);
            this.quantatiyTb.Margin = new System.Windows.Forms.Padding(4);
            this.quantatiyTb.Name = "quantatiyTb";
            this.quantatiyTb.Size = new System.Drawing.Size(209, 34);
            this.quantatiyTb.TabIndex = 6;
            this.quantatiyTb.Text = "Quantity";
            this.quantatiyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // expireDateTb
            // 
            this.expireDateTb.BaseColor = System.Drawing.Color.Brown;
            this.expireDateTb.BorderColor = System.Drawing.Color.Brown;
            this.expireDateTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expireDateTb.CustomFormat = null;
            this.expireDateTb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.expireDateTb.FocusedColor = System.Drawing.Color.White;
            this.expireDateTb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDateTb.ForeColor = System.Drawing.Color.White;
            this.expireDateTb.Location = new System.Drawing.Point(19, 187);
            this.expireDateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.expireDateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.expireDateTb.Name = "expireDateTb";
            this.expireDateTb.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.expireDateTb.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.expireDateTb.OnHoverForeColor = System.Drawing.Color.White;
            this.expireDateTb.OnPressedColor = System.Drawing.Color.Black;
            this.expireDateTb.Size = new System.Drawing.Size(223, 30);
            this.expireDateTb.TabIndex = 7;
            this.expireDateTb.Text = "Wednesday, April 28, 2021";
            this.expireDateTb.Value = new System.DateTime(2021, 4, 28, 2, 36, 39, 704);
            // 
            // companyTb
            // 
            this.companyTb.BackColor = System.Drawing.Color.Transparent;
            this.companyTb.BaseColor = System.Drawing.Color.White;
            this.companyTb.BorderColor = System.Drawing.Color.Silver;
            this.companyTb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.companyTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.companyTb.FocusedColor = System.Drawing.Color.Empty;
            this.companyTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.companyTb.ForeColor = System.Drawing.Color.Black;
            this.companyTb.FormattingEnabled = true;
            this.companyTb.Items.AddRange(new object[] {
            "FirstCompany",
            "SecondCompany",
            "ThirdCompany",
            "ForuthCompany ",
            "FifthCompany"});
            this.companyTb.Location = new System.Drawing.Point(19, 297);
            this.companyTb.Name = "companyTb";
            this.companyTb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.companyTb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.companyTb.Size = new System.Drawing.Size(223, 26);
            this.companyTb.TabIndex = 8;
            // 
            // addMedicine
            // 
            this.addMedicine.AnimationHoverSpeed = 0.07F;
            this.addMedicine.AnimationSpeed = 0.03F;
            this.addMedicine.BackColor = System.Drawing.Color.Transparent;
            this.addMedicine.BaseColor = System.Drawing.Color.Brown;
            this.addMedicine.BorderColor = System.Drawing.Color.Black;
            this.addMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.addMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedicine.ForeColor = System.Drawing.Color.White;
            this.addMedicine.Image = null;
            this.addMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.addMedicine.Location = new System.Drawing.Point(19, 434);
            this.addMedicine.Name = "addMedicine";
            this.addMedicine.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.addMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.addMedicine.OnHoverImage = null;
            this.addMedicine.OnPressedColor = System.Drawing.Color.Brown;
            this.addMedicine.Size = new System.Drawing.Size(91, 42);
            this.addMedicine.TabIndex = 9;
            this.addMedicine.Text = "ADD";
            this.addMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addMedicine.Click += new System.EventHandler(this.addMedicine_Click);
            // 
            // deleteMedicine
            // 
            this.deleteMedicine.AnimationHoverSpeed = 0.07F;
            this.deleteMedicine.AnimationSpeed = 0.03F;
            this.deleteMedicine.BackColor = System.Drawing.Color.Transparent;
            this.deleteMedicine.BaseColor = System.Drawing.Color.Brown;
            this.deleteMedicine.BorderColor = System.Drawing.Color.Black;
            this.deleteMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.deleteMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMedicine.ForeColor = System.Drawing.Color.White;
            this.deleteMedicine.Image = null;
            this.deleteMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteMedicine.Location = new System.Drawing.Point(382, 434);
            this.deleteMedicine.Name = "deleteMedicine";
            this.deleteMedicine.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.deleteMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteMedicine.OnHoverImage = null;
            this.deleteMedicine.OnPressedColor = System.Drawing.Color.Brown;
            this.deleteMedicine.Size = new System.Drawing.Size(103, 42);
            this.deleteMedicine.TabIndex = 11;
            this.deleteMedicine.Text = "DELETE ";
            this.deleteMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteMedicine.Click += new System.EventHandler(this.deleteMedicine_Click);
            // 
            // updateMedicine
            // 
            this.updateMedicine.AnimationHoverSpeed = 0.07F;
            this.updateMedicine.AnimationSpeed = 0.03F;
            this.updateMedicine.BackColor = System.Drawing.Color.Transparent;
            this.updateMedicine.BaseColor = System.Drawing.Color.Brown;
            this.updateMedicine.BorderColor = System.Drawing.Color.Black;
            this.updateMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.updateMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMedicine.ForeColor = System.Drawing.Color.White;
            this.updateMedicine.Image = null;
            this.updateMedicine.ImageSize = new System.Drawing.Size(20, 20);
            this.updateMedicine.Location = new System.Drawing.Point(193, 434);
            this.updateMedicine.Name = "updateMedicine";
            this.updateMedicine.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.updateMedicine.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateMedicine.OnHoverForeColor = System.Drawing.Color.White;
            this.updateMedicine.OnHoverImage = null;
            this.updateMedicine.OnPressedColor = System.Drawing.Color.Brown;
            this.updateMedicine.Size = new System.Drawing.Size(94, 42);
            this.updateMedicine.TabIndex = 14;
            this.updateMedicine.Text = "UPDATE";
            this.updateMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateMedicine.Click += new System.EventHandler(this.updateMedicine_Click);
            // 
            // backBtn
            // 
            this.backBtn.AnimationHoverSpeed = 0.07F;
            this.backBtn.AnimationSpeed = 0.03F;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BaseColor = System.Drawing.Color.Brown;
            this.backBtn.BorderColor = System.Drawing.Color.Black;
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backBtn.FocusedColor = System.Drawing.Color.Empty;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = null;
            this.backBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.backBtn.Location = new System.Drawing.Point(193, 542);
            this.backBtn.Name = "backBtn";
            this.backBtn.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.backBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.backBtn.OnHoverImage = null;
            this.backBtn.OnPressedColor = System.Drawing.Color.Brown;
            this.backBtn.Size = new System.Drawing.Size(94, 42);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "BACK";
            this.backBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MedicineStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 733);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateMedicine);
            this.Controls.Add(this.deleteMedicine);
            this.Controls.Add(this.addMedicine);
            this.Controls.Add(this.medicineGridView);
            this.Controls.Add(this.companyTb);
            this.Controls.Add(this.expireDateTb);
            this.Controls.Add(this.quantatiyTb);
            this.Controls.Add(this.sellingPriceTb);
            this.Controls.Add(this.buyingPriceTb);
            this.Controls.Add(this.medicineNameTb);
            this.Controls.Add(this.MedicinStock);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicineStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicinForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel MedicinStock;
        private Guna.UI.WinForms.GunaDataGridView medicineGridView;
        private Bunifu.Framework.UI.BunifuMaterialTextbox medicineNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buyingPriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellingPriceTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantatiyTb;
        private Guna.UI.WinForms.GunaDateTimePicker expireDateTb;
        private Guna.UI.WinForms.GunaComboBox companyTb;
        private Guna.UI.WinForms.GunaButton addMedicine;
        private Guna.UI.WinForms.GunaButton deleteMedicine;
        private Guna.UI.WinForms.GunaButton updateMedicine;
        private Guna.UI.WinForms.GunaButton backBtn;
    }
}