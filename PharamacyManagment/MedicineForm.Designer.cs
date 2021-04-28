
namespace PharamacyManagment
{
    partial class MedicineForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MedicinStock = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.MedicineName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.buyingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sellingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.quantatiy = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.expireDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new Guna.UI.WinForms.GunaButton();
            this.deleteBtn = new Guna.UI.WinForms.GunaButton();
            this.update = new Guna.UI.WinForms.GunaButton();
            this.backBtn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicinStock
            // 
            this.MedicinStock.AutoSize = true;
            this.MedicinStock.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinStock.ForeColor = System.Drawing.Color.Brown;
            this.MedicinStock.Location = new System.Drawing.Point(12, 9);
            this.MedicinStock.Name = "MedicinStock";
            this.MedicinStock.Size = new System.Drawing.Size(258, 38);
            this.MedicinStock.TabIndex = 0;
            this.MedicinStock.Text = "Medicine Stock";
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 30;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.quantity,
            this.price,
            this.sPrice,
            this.company,
            this.expdate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.Location = new System.Drawing.Point(528, 12);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 30;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(776, 712);
            this.gunaDataGridView1.TabIndex = 1;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // MedicineName
            // 
            this.MedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicineName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MedicineName.ForeColor = System.Drawing.Color.Brown;
            this.MedicineName.HintForeColor = System.Drawing.Color.Empty;
            this.MedicineName.HintText = "";
            this.MedicineName.isPassword = false;
            this.MedicineName.LineFocusedColor = System.Drawing.Color.Brown;
            this.MedicineName.LineIdleColor = System.Drawing.Color.Gray;
            this.MedicineName.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.MedicineName.LineThickness = 3;
            this.MedicineName.Location = new System.Drawing.Point(19, 96);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(209, 34);
            this.MedicineName.TabIndex = 2;
            this.MedicineName.Text = "Medicine Name";
            this.MedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MedicineName.OnValueChanged += new System.EventHandler(this.MedicineName_OnValueChanged);
            // 
            // buyingPrice
            // 
            this.buyingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buyingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buyingPrice.ForeColor = System.Drawing.Color.Brown;
            this.buyingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.buyingPrice.HintText = "";
            this.buyingPrice.isPassword = false;
            this.buyingPrice.LineFocusedColor = System.Drawing.Color.Brown;
            this.buyingPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.buyingPrice.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.buyingPrice.LineThickness = 3;
            this.buyingPrice.Location = new System.Drawing.Point(285, 96);
            this.buyingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.buyingPrice.Name = "buyingPrice";
            this.buyingPrice.Size = new System.Drawing.Size(209, 34);
            this.buyingPrice.TabIndex = 3;
            this.buyingPrice.Text = "Buying Price";
            this.buyingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sellingPrice
            // 
            this.sellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellingPrice.ForeColor = System.Drawing.Color.Brown;
            this.sellingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.sellingPrice.HintText = "";
            this.sellingPrice.isPassword = false;
            this.sellingPrice.LineFocusedColor = System.Drawing.Color.Brown;
            this.sellingPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.sellingPrice.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.sellingPrice.LineThickness = 3;
            this.sellingPrice.Location = new System.Drawing.Point(285, 183);
            this.sellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.Size = new System.Drawing.Size(209, 34);
            this.sellingPrice.TabIndex = 5;
            this.sellingPrice.Text = "Selling Price";
            this.sellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellingPrice.OnValueChanged += new System.EventHandler(this.sellingPrice_OnValueChanged);
            // 
            // quantatiy
            // 
            this.quantatiy.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantatiy.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantatiy.ForeColor = System.Drawing.Color.Brown;
            this.quantatiy.HintForeColor = System.Drawing.Color.Empty;
            this.quantatiy.HintText = "";
            this.quantatiy.isPassword = false;
            this.quantatiy.LineFocusedColor = System.Drawing.Color.Blue;
            this.quantatiy.LineIdleColor = System.Drawing.Color.Gray;
            this.quantatiy.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.quantatiy.LineThickness = 3;
            this.quantatiy.Location = new System.Drawing.Point(285, 279);
            this.quantatiy.Margin = new System.Windows.Forms.Padding(4);
            this.quantatiy.Name = "quantatiy";
            this.quantatiy.Size = new System.Drawing.Size(209, 34);
            this.quantatiy.TabIndex = 6;
            this.quantatiy.Text = "Quantity";
            this.quantatiy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // expireDate
            // 
            this.expireDate.BaseColor = System.Drawing.Color.Brown;
            this.expireDate.BorderColor = System.Drawing.Color.Brown;
            this.expireDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expireDate.CustomFormat = null;
            this.expireDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.expireDate.FocusedColor = System.Drawing.Color.White;
            this.expireDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDate.ForeColor = System.Drawing.Color.White;
            this.expireDate.Location = new System.Drawing.Point(19, 187);
            this.expireDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.expireDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.expireDate.Name = "expireDate";
            this.expireDate.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.expireDate.OnHoverBorderColor = System.Drawing.Color.Brown;
            this.expireDate.OnHoverForeColor = System.Drawing.Color.White;
            this.expireDate.OnPressedColor = System.Drawing.Color.Black;
            this.expireDate.Size = new System.Drawing.Size(223, 30);
            this.expireDate.TabIndex = 7;
            this.expireDate.Text = "Wednesday, April 28, 2021";
            this.expireDate.Value = new System.DateTime(2021, 4, 28, 2, 36, 39, 704);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(19, 297);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(223, 26);
            this.gunaComboBox1.TabIndex = 8;
            // 
            // Medicine
            // 
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.HeaderText = "BuyingPrice";
            this.price.Name = "price";
            // 
            // sPrice
            // 
            this.sPrice.HeaderText = "Selling Price";
            this.sPrice.Name = "sPrice";
            // 
            // company
            // 
            this.company.HeaderText = "Company";
            this.company.Name = "company";
            // 
            // expdate
            // 
            this.expdate.HeaderText = "Expire Date";
            this.expdate.Name = "expdate";
            // 
            // addBtn
            // 
            this.addBtn.AnimationHoverSpeed = 0.07F;
            this.addBtn.AnimationSpeed = 0.03F;
            this.addBtn.BaseColor = System.Drawing.Color.Brown;
            this.addBtn.BorderColor = System.Drawing.Color.Black;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.FocusedColor = System.Drawing.Color.Empty;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = null;
            this.addBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.addBtn.Location = new System.Drawing.Point(19, 434);
            this.addBtn.Name = "addBtn";
            this.addBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.addBtn.OnHoverImage = null;
            this.addBtn.OnPressedColor = System.Drawing.Color.Black;
            this.addBtn.Size = new System.Drawing.Size(91, 42);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "ADD";
            this.addBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AnimationHoverSpeed = 0.07F;
            this.deleteBtn.AnimationSpeed = 0.03F;
            this.deleteBtn.BaseColor = System.Drawing.Color.Brown;
            this.deleteBtn.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Image = null;
            this.deleteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteBtn.Location = new System.Drawing.Point(382, 434);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnHoverBaseColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnHoverImage = null;
            this.deleteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.deleteBtn.Size = new System.Drawing.Size(103, 42);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "DELETE ";
            this.deleteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // update
            // 
            this.update.AnimationHoverSpeed = 0.07F;
            this.update.AnimationSpeed = 0.03F;
            this.update.BaseColor = System.Drawing.Color.Brown;
            this.update.BorderColor = System.Drawing.Color.Black;
            this.update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.update.FocusedColor = System.Drawing.Color.Empty;
            this.update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Image = null;
            this.update.ImageSize = new System.Drawing.Size(20, 20);
            this.update.Location = new System.Drawing.Point(193, 434);
            this.update.Name = "update";
            this.update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.update.OnHoverForeColor = System.Drawing.Color.White;
            this.update.OnHoverImage = null;
            this.update.OnPressedColor = System.Drawing.Color.Black;
            this.update.Size = new System.Drawing.Size(94, 42);
            this.update.TabIndex = 14;
            this.update.Text = "UPDATE";
            this.update.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backBtn
            // 
            this.backBtn.AnimationHoverSpeed = 0.07F;
            this.backBtn.AnimationSpeed = 0.03F;
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
            this.backBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.backBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.backBtn.OnHoverImage = null;
            this.backBtn.OnPressedColor = System.Drawing.Color.Black;
            this.backBtn.Size = new System.Drawing.Size(94, 42);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "BACK";
            this.backBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 733);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.update);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.expireDate);
            this.Controls.Add(this.quantatiy);
            this.Controls.Add(this.sellingPrice);
            this.Controls.Add(this.buyingPrice);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.MedicinStock);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicinForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel MedicinStock;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MedicineName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buyingPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellingPrice;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantatiy;
        private Guna.UI.WinForms.GunaDateTimePicker expireDate;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn expdate;
        private Guna.UI.WinForms.GunaButton addBtn;
        private Guna.UI.WinForms.GunaButton deleteBtn;
        private Guna.UI.WinForms.GunaButton update;
        private Guna.UI.WinForms.GunaButton backBtn;
    }
}