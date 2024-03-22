using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    partial class frmAddProduct
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
			txtUnitInStock = new TextBox();
			label5 = new Label();
			txtUnitPrice = new TextBox();
			label3 = new Label();
			txtWeight = new TextBox();
			label4 = new Label();
			txtProductName = new TextBox();
			label2 = new Label();
			btnClose = new Button();
			btnCreate = new Button();
			label1 = new Label();
			txtSpecies = new TextBox();
			SuspendLayout();
			// 
			// txtUnitInStock
			// 
			txtUnitInStock.Location = new Point(152, 238);
			txtUnitInStock.Margin = new Padding(3, 2, 3, 2);
			txtUnitInStock.MaxLength = 15;
			txtUnitInStock.Name = "txtUnitInStock";
			txtUnitInStock.Size = new Size(220, 23);
			txtUnitInStock.TabIndex = 33;
			txtUnitInStock.TextChanged += txtUnitInStock_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(49, 241);
			label5.Name = "label5";
			label5.Size = new Size(79, 15);
			label5.TabIndex = 32;
			label5.Text = "Units In Stock";
			label5.Click += label5_Click;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(152, 191);
			txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
			txtUnitPrice.MaxLength = 15;
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(220, 23);
			txtUnitPrice.TabIndex = 31;
			txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(49, 194);
			label3.Name = "label3";
			label3.Size = new Size(58, 15);
			label3.TabIndex = 30;
			label3.Text = "Unit Price";
			label3.Click += label3_Click;
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(152, 100);
			txtWeight.Margin = new Padding(3, 2, 3, 2);
			txtWeight.MaxLength = 20;
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(220, 23);
			txtWeight.TabIndex = 29;
			txtWeight.TextChanged += txtWeight_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(49, 103);
			label4.Name = "label4";
			label4.Size = new Size(45, 15);
			label4.TabIndex = 28;
			label4.Text = "Weight";
			label4.Click += label4_Click;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(152, 51);
			txtProductName.Margin = new Padding(3, 2, 3, 2);
			txtProductName.MaxLength = 40;
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(220, 23);
			txtProductName.TabIndex = 27;
			txtProductName.TextChanged += txtProductName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(49, 53);
			label2.Name = "label2";
			label2.Size = new Size(84, 15);
			label2.TabIndex = 26;
			label2.Text = "Product Name";
			label2.Click += label2_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(267, 280);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 25;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(104, 280);
			btnCreate.Margin = new Padding(3, 2, 3, 2);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(105, 26);
			btnCreate.TabIndex = 34;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(49, 148);
			label1.Name = "label1";
			label1.Size = new Size(46, 15);
			label1.TabIndex = 28;
			label1.Text = "Species";
			label1.Click += label4_Click;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(152, 145);
			txtSpecies.Margin = new Padding(3, 2, 3, 2);
			txtSpecies.MaxLength = 20;
			txtSpecies.Name = "txtSpecies";
			txtSpecies.Size = new Size(220, 23);
			txtSpecies.TabIndex = 29;
			txtSpecies.TextChanged += txtWeight_TextChanged;
			// 
			// frmAddProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(434, 327);
			Controls.Add(btnCreate);
			Controls.Add(txtUnitInStock);
			Controls.Add(label5);
			Controls.Add(txtUnitPrice);
			Controls.Add(label3);
			Controls.Add(txtSpecies);
			Controls.Add(txtWeight);
			Controls.Add(label1);
			Controls.Add(label4);
			Controls.Add(txtProductName);
			Controls.Add(label2);
			Controls.Add(btnClose);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmAddProduct";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Product";
			FormClosing += frmAddProduct_FormClosing;
			Load += frmAddProduct_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtUnitInStock;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtProductName;
        private Label label2;
        private Button btnClose;
        private Button btnCreate;
		private Label label1;
		private TextBox txtSpecies;
	}
}