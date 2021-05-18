
namespace WindowsFormsApp1
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryButton = new Guna.UI.WinForms.GunaImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.Biling = new System.Windows.Forms.Label();
            this.MedicationReport = new System.Windows.Forms.Label();
            this.Syndicate = new System.Windows.Forms.Label();
            this.gunaImageButton2 = new Guna.UI.WinForms.GunaImageButton();
            this.SyndicateButton = new Guna.UI.WinForms.GunaImageButton();
            this.gunaImageButton4 = new Guna.UI.WinForms.GunaImageButton();
            this.ExitButton = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 39);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(152, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Page";
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackColor = System.Drawing.Color.Transparent;
            this.InventoryButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.drugs;
            this.InventoryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.InventoryButton.Image = global::WindowsFormsApp1.Properties.Resources.drugs;
            this.InventoryButton.ImageSize = new System.Drawing.Size(64, 64);
            this.InventoryButton.Location = new System.Drawing.Point(93, 123);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.OnHoverImage = null;
            this.InventoryButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.InventoryButton.Size = new System.Drawing.Size(89, 53);
            this.InventoryButton.TabIndex = 1;
            this.InventoryButton.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 74);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Size = new System.Drawing.Size(104, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Inventory";
            // 
            // Biling
            // 
            this.Biling.AutoSize = true;
            this.Biling.BackColor = System.Drawing.Color.Transparent;
            this.Biling.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biling.ForeColor = System.Drawing.Color.White;
            this.Biling.Location = new System.Drawing.Point(607, 253);
            this.Biling.Name = "Biling";
            this.Biling.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Biling.Size = new System.Drawing.Size(73, 30);
            this.Biling.TabIndex = 5;
            this.Biling.Text = "Billing";
            // 
            // MedicationReport
            // 
            this.MedicationReport.AutoSize = true;
            this.MedicationReport.BackColor = System.Drawing.Color.Transparent;
            this.MedicationReport.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicationReport.ForeColor = System.Drawing.Color.White;
            this.MedicationReport.Location = new System.Drawing.Point(607, 74);
            this.MedicationReport.Name = "MedicationReport";
            this.MedicationReport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.MedicationReport.Size = new System.Drawing.Size(187, 30);
            this.MedicationReport.TabIndex = 6;
            this.MedicationReport.Text = "Medication Report";
            // 
            // Syndicate
            // 
            this.Syndicate.AutoSize = true;
            this.Syndicate.BackColor = System.Drawing.Color.Transparent;
            this.Syndicate.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syndicate.ForeColor = System.Drawing.Color.White;
            this.Syndicate.Location = new System.Drawing.Point(88, 253);
            this.Syndicate.Name = "Syndicate";
            this.Syndicate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Syndicate.Size = new System.Drawing.Size(103, 30);
            this.Syndicate.TabIndex = 7;
            this.Syndicate.Text = "Syndicate";
            // 
            // gunaImageButton2
            // 
            this.gunaImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.drugs;
            this.gunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton2.Image = global::WindowsFormsApp1.Properties.Resources.bill;
            this.gunaImageButton2.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton2.Location = new System.Drawing.Point(612, 286);
            this.gunaImageButton2.Name = "gunaImageButton2";
            this.gunaImageButton2.OnHoverImage = null;
            this.gunaImageButton2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton2.Size = new System.Drawing.Size(89, 67);
            this.gunaImageButton2.TabIndex = 8;
            this.gunaImageButton2.Click += new System.EventHandler(this.gunaImageButton2_Click);
            // 
            // SyndicateButton
            // 
            this.SyndicateButton.BackColor = System.Drawing.Color.Transparent;
            this.SyndicateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SyndicateButton.Image = global::WindowsFormsApp1.Properties.Resources.Layer_0;
            this.SyndicateButton.ImageSize = new System.Drawing.Size(64, 64);
            this.SyndicateButton.Location = new System.Drawing.Point(93, 286);
            this.SyndicateButton.Name = "SyndicateButton";
            this.SyndicateButton.OnHoverImage = null;
            this.SyndicateButton.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.SyndicateButton.Size = new System.Drawing.Size(89, 67);
            this.SyndicateButton.TabIndex = 9;
            this.SyndicateButton.Click += new System.EventHandler(this.gunaImageButton3_Click);
            // 
            // gunaImageButton4
            // 
            this.gunaImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaImageButton4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.drugs;
            this.gunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaImageButton4.Image = global::WindowsFormsApp1.Properties.Resources.report;
            this.gunaImageButton4.ImageSize = new System.Drawing.Size(64, 64);
            this.gunaImageButton4.Location = new System.Drawing.Point(612, 123);
            this.gunaImageButton4.Name = "gunaImageButton4";
            this.gunaImageButton4.OnHoverImage = null;
            this.gunaImageButton4.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton4.Size = new System.Drawing.Size(89, 53);
            this.gunaImageButton4.TabIndex = 10;
            this.gunaImageButton4.Click += new System.EventHandler(this.gunaImageButton4_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AnimationHoverSpeed = 0.07F;
            this.ExitButton.AnimationSpeed = 0.03F;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BaseColor = System.Drawing.Color.Red;
            this.ExitButton.BorderColor = System.Drawing.Color.White;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.FocusedColor = System.Drawing.Color.Empty;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = null;
            this.ExitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.ExitButton.Location = new System.Drawing.Point(332, 362);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.OnHoverBaseColor = System.Drawing.Color.Brown;
            this.ExitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ExitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.ExitButton.OnHoverImage = null;
            this.ExitButton.OnPressedColor = System.Drawing.Color.Brown;
            this.ExitButton.Radius = 20;
            this.ExitButton.Size = new System.Drawing.Size(185, 42);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.istockphoto_1255471603_612x6123;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.gunaImageButton4);
            this.Controls.Add(this.SyndicateButton);
            this.Controls.Add(this.gunaImageButton2);
            this.Controls.Add(this.Syndicate);
            this.Controls.Add(this.MedicationReport);
            this.Controls.Add(this.Biling);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton InventoryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Biling;
        private System.Windows.Forms.Label MedicationReport;
        private System.Windows.Forms.Label Syndicate;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton2;
        private Guna.UI.WinForms.GunaImageButton SyndicateButton;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton4;
        private Guna.UI.WinForms.GunaButton ExitButton;
    }
}

