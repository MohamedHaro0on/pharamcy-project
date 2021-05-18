namespace WindowsFormsApp1
{
    partial class SyndicateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyndicateForm));
            this.Organization = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.membership = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxOrganization = new System.Windows.Forms.ComboBox();
            this.cbxDiscount = new System.Windows.Forms.ComboBox();
            this.textBoxMembership = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // Organization
            // 
            this.Organization.AutoSize = true;
            this.Organization.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Organization.ForeColor = System.Drawing.Color.Brown;
            this.Organization.Location = new System.Drawing.Point(13, 91);
            this.Organization.Name = "Organization";
            this.Organization.Size = new System.Drawing.Size(126, 28);
            this.Organization.TabIndex = 2;
            this.Organization.Text = "Organization";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.ForeColor = System.Drawing.Color.Brown;
            this.Discount.Location = new System.Drawing.Point(13, 218);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(133, 28);
            this.Discount.TabIndex = 3;
            this.Discount.Text = "Discount Rate";
            // 
            // membership
            // 
            this.membership.AutoSize = true;
            this.membership.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membership.ForeColor = System.Drawing.Color.Brown;
            this.membership.Location = new System.Drawing.Point(13, 152);
            this.membership.Name = "membership";
            this.membership.Size = new System.Drawing.Size(199, 28);
            this.membership.TabIndex = 4;
            this.membership.Text = "Membership Number";
            this.membership.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 7;
            // 
            // cbxOrganization
            // 
            this.cbxOrganization.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxOrganization.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrganization.FormattingEnabled = true;
            this.cbxOrganization.Items.AddRange(new object[] {
            "Engineers",
            "Medical",
            "Agricultural"});
            this.cbxOrganization.Location = new System.Drawing.Point(279, 98);
            this.cbxOrganization.Name = "cbxOrganization";
            this.cbxOrganization.Size = new System.Drawing.Size(121, 21);
            this.cbxOrganization.TabIndex = 8;
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxDiscount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxDiscount.FormattingEnabled = true;
            this.cbxDiscount.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%"});
            this.cbxDiscount.Location = new System.Drawing.Point(279, 225);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(121, 21);
            this.cbxDiscount.TabIndex = 9;
            // 
            // textBoxMembership
            // 
            this.textBoxMembership.Location = new System.Drawing.Point(279, 161);
            this.textBoxMembership.Name = "textBoxMembership";
            this.textBoxMembership.Size = new System.Drawing.Size(121, 20);
            this.textBoxMembership.TabIndex = 10;
            this.textBoxMembership.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Syndicate Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(18, 299);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Brown;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(94, 42);
            this.gunaButton1.TabIndex = 18;
            this.gunaButton1.Text = "BACK";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.Brown;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(306, 299);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Brown;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(94, 42);
            this.gunaButton2.TabIndex = 19;
            this.gunaButton2.Text = "New Bill";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SyndicateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 364);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMembership);
            this.Controls.Add(this.cbxDiscount);
            this.Controls.Add(this.cbxOrganization);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.membership);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Organization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SyndicateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyndicateForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Organization;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label membership;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxOrganization;
        private System.Windows.Forms.ComboBox cbxDiscount;
        private System.Windows.Forms.TextBox textBoxMembership;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
    }
}

