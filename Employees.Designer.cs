
namespace WindowsFormsApp1
{
    partial class EmpLabel
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
            this.MedicinStock = new Guna.UI.WinForms.GunaLabel();
            this.employeeGenderTb = new Guna.UI.WinForms.GunaComboBox();
            this.employeeIdTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.employeeNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.employeeSalaryTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.employeeAgeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addEmployee = new Guna.UI.WinForms.GunaButton();
            this.deleteEmployee = new Guna.UI.WinForms.GunaButton();
            this.updateEmployee = new Guna.UI.WinForms.GunaButton();
            this.backBtn = new Guna.UI.WinForms.GunaButton();
            this.employeePhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicinStock
            // 
            this.MedicinStock.AutoSize = true;
            this.MedicinStock.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicinStock.ForeColor = System.Drawing.Color.Brown;
            this.MedicinStock.Location = new System.Drawing.Point(22, 21);
            this.MedicinStock.Name = "MedicinStock";
            this.MedicinStock.Size = new System.Drawing.Size(180, 45);
            this.MedicinStock.TabIndex = 1;
            this.MedicinStock.Text = "Employees";
            // 
            // employeeGenderTb
            // 
            this.employeeGenderTb.BackColor = System.Drawing.Color.Transparent;
            this.employeeGenderTb.BaseColor = System.Drawing.Color.White;
            this.employeeGenderTb.BorderColor = System.Drawing.Color.Silver;
            this.employeeGenderTb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.employeeGenderTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeGenderTb.FocusedColor = System.Drawing.Color.Empty;
            this.employeeGenderTb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.employeeGenderTb.ForeColor = System.Drawing.Color.Black;
            this.employeeGenderTb.FormattingEnabled = true;
            this.employeeGenderTb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.employeeGenderTb.Location = new System.Drawing.Point(306, 218);
            this.employeeGenderTb.Name = "employeeGenderTb";
            this.employeeGenderTb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.employeeGenderTb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.employeeGenderTb.Size = new System.Drawing.Size(209, 26);
            this.employeeGenderTb.TabIndex = 14;
            // 
            // employeeIdTb
            // 
            this.employeeIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeIdTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.employeeIdTb.ForeColor = System.Drawing.Color.Brown;
            this.employeeIdTb.HintForeColor = System.Drawing.Color.Empty;
            this.employeeIdTb.HintText = "";
            this.employeeIdTb.isPassword = false;
            this.employeeIdTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.employeeIdTb.LineIdleColor = System.Drawing.Color.Gray;
            this.employeeIdTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.employeeIdTb.LineThickness = 3;
            this.employeeIdTb.Location = new System.Drawing.Point(30, 112);
            this.employeeIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.employeeIdTb.Name = "employeeIdTb";
            this.employeeIdTb.Size = new System.Drawing.Size(209, 34);
            this.employeeIdTb.TabIndex = 10;
            this.employeeIdTb.Text = "EmployeeId";
            this.employeeIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // employeeNameTb
            // 
            this.employeeNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.employeeNameTb.ForeColor = System.Drawing.Color.Brown;
            this.employeeNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.employeeNameTb.HintText = "";
            this.employeeNameTb.isPassword = false;
            this.employeeNameTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.employeeNameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.employeeNameTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.employeeNameTb.LineThickness = 3;
            this.employeeNameTb.Location = new System.Drawing.Point(30, 210);
            this.employeeNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.employeeNameTb.Name = "employeeNameTb";
            this.employeeNameTb.Size = new System.Drawing.Size(209, 34);
            this.employeeNameTb.TabIndex = 11;
            this.employeeNameTb.Text = "EmployeeName";
            this.employeeNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // employeeSalaryTb
            // 
            this.employeeSalaryTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeSalaryTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.employeeSalaryTb.ForeColor = System.Drawing.Color.Brown;
            this.employeeSalaryTb.HintForeColor = System.Drawing.Color.Empty;
            this.employeeSalaryTb.HintText = "";
            this.employeeSalaryTb.isPassword = false;
            this.employeeSalaryTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.employeeSalaryTb.LineIdleColor = System.Drawing.Color.Gray;
            this.employeeSalaryTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.employeeSalaryTb.LineThickness = 3;
            this.employeeSalaryTb.Location = new System.Drawing.Point(306, 112);
            this.employeeSalaryTb.Margin = new System.Windows.Forms.Padding(4);
            this.employeeSalaryTb.Name = "employeeSalaryTb";
            this.employeeSalaryTb.Size = new System.Drawing.Size(209, 34);
            this.employeeSalaryTb.TabIndex = 12;
            this.employeeSalaryTb.Text = "Salary";
            this.employeeSalaryTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // employeeAgeTb
            // 
            this.employeeAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeeAgeTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.employeeAgeTb.ForeColor = System.Drawing.Color.Brown;
            this.employeeAgeTb.HintForeColor = System.Drawing.Color.Empty;
            this.employeeAgeTb.HintText = "";
            this.employeeAgeTb.isPassword = false;
            this.employeeAgeTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.employeeAgeTb.LineIdleColor = System.Drawing.Color.Gray;
            this.employeeAgeTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.employeeAgeTb.LineThickness = 3;
            this.employeeAgeTb.Location = new System.Drawing.Point(30, 319);
            this.employeeAgeTb.Margin = new System.Windows.Forms.Padding(4);
            this.employeeAgeTb.Name = "employeeAgeTb";
            this.employeeAgeTb.Size = new System.Drawing.Size(209, 34);
            this.employeeAgeTb.TabIndex = 13;
            this.employeeAgeTb.Text = "Age";
            this.employeeAgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addEmployee
            // 
            this.addEmployee.AnimationHoverSpeed = 0.07F;
            this.addEmployee.AnimationSpeed = 0.03F;
            this.addEmployee.BackColor = System.Drawing.Color.Transparent;
            this.addEmployee.BaseColor = System.Drawing.Color.Brown;
            this.addEmployee.BorderColor = System.Drawing.Color.Black;
            this.addEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.addEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.Image = null;
            this.addEmployee.ImageSize = new System.Drawing.Size(20, 20);
            this.addEmployee.Location = new System.Drawing.Point(30, 423);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.addEmployee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addEmployee.OnHoverForeColor = System.Drawing.Color.White;
            this.addEmployee.OnHoverImage = null;
            this.addEmployee.OnPressedColor = System.Drawing.Color.Brown;
            this.addEmployee.Size = new System.Drawing.Size(91, 42);
            this.addEmployee.TabIndex = 32;
            this.addEmployee.Text = "ADD";
            this.addEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.AnimationHoverSpeed = 0.07F;
            this.deleteEmployee.AnimationSpeed = 0.03F;
            this.deleteEmployee.BackColor = System.Drawing.Color.Transparent;
            this.deleteEmployee.BaseColor = System.Drawing.Color.Brown;
            this.deleteEmployee.BorderColor = System.Drawing.Color.Black;
            this.deleteEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.deleteEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployee.ForeColor = System.Drawing.Color.White;
            this.deleteEmployee.Image = null;
            this.deleteEmployee.ImageSize = new System.Drawing.Size(20, 20);
            this.deleteEmployee.Location = new System.Drawing.Point(412, 423);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.deleteEmployee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deleteEmployee.OnHoverForeColor = System.Drawing.Color.White;
            this.deleteEmployee.OnHoverImage = null;
            this.deleteEmployee.OnPressedColor = System.Drawing.Color.Brown;
            this.deleteEmployee.Size = new System.Drawing.Size(103, 42);
            this.deleteEmployee.TabIndex = 33;
            this.deleteEmployee.Text = "DELETE ";
            this.deleteEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateEmployee
            // 
            this.updateEmployee.AnimationHoverSpeed = 0.07F;
            this.updateEmployee.AnimationSpeed = 0.03F;
            this.updateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.updateEmployee.BaseColor = System.Drawing.Color.Brown;
            this.updateEmployee.BorderColor = System.Drawing.Color.Black;
            this.updateEmployee.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateEmployee.FocusedColor = System.Drawing.Color.Empty;
            this.updateEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployee.ForeColor = System.Drawing.Color.White;
            this.updateEmployee.Image = null;
            this.updateEmployee.ImageSize = new System.Drawing.Size(20, 20);
            this.updateEmployee.Location = new System.Drawing.Point(222, 423);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.updateEmployee.OnHoverBorderColor = System.Drawing.Color.Black;
            this.updateEmployee.OnHoverForeColor = System.Drawing.Color.White;
            this.updateEmployee.OnHoverImage = null;
            this.updateEmployee.OnPressedColor = System.Drawing.Color.Brown;
            this.updateEmployee.Size = new System.Drawing.Size(94, 42);
            this.updateEmployee.TabIndex = 34;
            this.updateEmployee.Text = "UPDATE";
            this.updateEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.backBtn.Location = new System.Drawing.Point(222, 517);
            this.backBtn.Name = "backBtn";
            this.backBtn.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.backBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.backBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.backBtn.OnHoverImage = null;
            this.backBtn.OnPressedColor = System.Drawing.Color.Brown;
            this.backBtn.Size = new System.Drawing.Size(94, 42);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "BACK";
            this.backBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeePhoneTb
            // 
            this.employeePhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeePhoneTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.employeePhoneTb.ForeColor = System.Drawing.Color.Brown;
            this.employeePhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.employeePhoneTb.HintText = "";
            this.employeePhoneTb.isPassword = false;
            this.employeePhoneTb.LineFocusedColor = System.Drawing.Color.Brown;
            this.employeePhoneTb.LineIdleColor = System.Drawing.Color.Gray;
            this.employeePhoneTb.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.employeePhoneTb.LineThickness = 3;
            this.employeePhoneTb.Location = new System.Drawing.Point(306, 319);
            this.employeePhoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.employeePhoneTb.Name = "employeePhoneTb";
            this.employeePhoneTb.Size = new System.Drawing.Size(209, 34);
            this.employeePhoneTb.TabIndex = 15;
            this.employeePhoneTb.Text = "Phone Number";
            this.employeePhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gunaDataGridView1
            // 
            this.gunaDataGridView1.AllowUserToAddRows = false;
            this.gunaDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 30;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicine,
            this.quantity,
            this.price,
            this.sPrice,
            this.company,
            this.expdate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.Brown;
            this.gunaDataGridView1.Location = new System.Drawing.Point(539, -2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 40;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(776, 712);
            this.gunaDataGridView1.TabIndex = 36;
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
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            // EmpLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 709);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.addEmployee);
            this.Controls.Add(this.employeePhoneTb);
            this.Controls.Add(this.employeeGenderTb);
            this.Controls.Add(this.employeeAgeTb);
            this.Controls.Add(this.employeeSalaryTb);
            this.Controls.Add(this.employeeNameTb);
            this.Controls.Add(this.employeeIdTb);
            this.Controls.Add(this.MedicinStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpLabel";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel MedicinStock;
        private Guna.UI.WinForms.GunaComboBox employeeGenderTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeeIdTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeeNameTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeeSalaryTb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeeAgeTb;
        private Guna.UI.WinForms.GunaButton addEmployee;
        private Guna.UI.WinForms.GunaButton deleteEmployee;
        private Guna.UI.WinForms.GunaButton updateEmployee;
        private Guna.UI.WinForms.GunaButton backBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox employeePhoneTb;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn expdate;
    }
}