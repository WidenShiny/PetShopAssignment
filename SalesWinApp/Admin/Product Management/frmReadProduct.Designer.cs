using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    partial class frmReadProduct
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
			btnClose = new Button();
			label1 = new Label();
			txtProductID = new TextBox();
			txtProductName = new TextBox();
			label2 = new Label();
			txtUnitPrice = new TextBox();
			label3 = new Label();
			txtWeight = new TextBox();
			label4 = new Label();
			txtUnitInStock = new TextBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			txtSpecies = new TextBox();
			SuspendLayout();
			// 
			// btnClose
			// 
			btnClose.Location = new Point(169, 308);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 14;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 40);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 15;
			label1.Text = "Product ID";
			label1.Click += label1_Click;
			// 
			// txtProductID
			// 
			txtProductID.Location = new Point(150, 38);
			txtProductID.Margin = new Padding(3, 2, 3, 2);
			txtProductID.Name = "txtProductID";
			txtProductID.ReadOnly = true;
			txtProductID.Size = new Size(220, 23);
			txtProductID.TabIndex = 16;
			txtProductID.TextChanged += txtProductID_TextChanged;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(150, 88);
			txtProductName.Margin = new Padding(3, 2, 3, 2);
			txtProductName.Name = "txtProductName";
			txtProductName.ReadOnly = true;
			txtProductName.Size = new Size(220, 23);
			txtProductName.TabIndex = 18;
			txtProductName.TextChanged += txtProductName_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(47, 90);
			label2.Name = "label2";
			label2.Size = new Size(84, 15);
			label2.TabIndex = 17;
			label2.Text = "Product Name";
			label2.Click += label2_Click;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(150, 230);
			txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.ReadOnly = true;
			txtUnitPrice.Size = new Size(220, 23);
			txtUnitPrice.TabIndex = 22;
			txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(47, 233);
			label3.Name = "label3";
			label3.Size = new Size(58, 15);
			label3.TabIndex = 21;
			label3.Text = "Unit Price";
			label3.Click += label3_Click;
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(150, 137);
			txtWeight.Margin = new Padding(3, 2, 3, 2);
			txtWeight.Name = "txtWeight";
			txtWeight.ReadOnly = true;
			txtWeight.Size = new Size(220, 23);
			txtWeight.TabIndex = 20;
			txtWeight.TextChanged += txtWeight_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(47, 140);
			label4.Name = "label4";
			label4.Size = new Size(45, 15);
			label4.TabIndex = 19;
			label4.Text = "Weight";
			label4.Click += label4_Click;
			// 
			// txtUnitInStock
			// 
			txtUnitInStock.Location = new Point(150, 271);
			txtUnitInStock.Margin = new Padding(3, 2, 3, 2);
			txtUnitInStock.Name = "txtUnitInStock";
			txtUnitInStock.ReadOnly = true;
			txtUnitInStock.Size = new Size(220, 23);
			txtUnitInStock.TabIndex = 24;
			txtUnitInStock.TextChanged += txtUnitInStock_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(47, 274);
			label5.Name = "label5";
			label5.Size = new Size(79, 15);
			label5.TabIndex = 23;
			label5.Text = "Units In Stock";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(47, 186);
			label6.Name = "label6";
			label6.Size = new Size(46, 15);
			label6.TabIndex = 19;
			label6.Text = "Species";
			label6.Click += label4_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(47, 230);
			label7.Name = "label7";
			label7.Size = new Size(45, 15);
			label7.TabIndex = 19;
			label7.Text = "Weight";
			label7.Click += label4_Click;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(150, 183);
			txtSpecies.Margin = new Padding(3, 2, 3, 2);
			txtSpecies.Name = "txtSpecies";
			txtSpecies.ReadOnly = true;
			txtSpecies.Size = new Size(220, 23);
			txtSpecies.TabIndex = 20;
			txtSpecies.TextChanged += txtWeight_TextChanged;
			// 
			// frmReadProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(434, 354);
			Controls.Add(txtUnitInStock);
			Controls.Add(label5);
			Controls.Add(txtUnitPrice);
			Controls.Add(label3);
			Controls.Add(txtSpecies);
			Controls.Add(txtWeight);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(txtProductName);
			Controls.Add(label2);
			Controls.Add(txtProductID);
			Controls.Add(label1);
			Controls.Add(btnClose);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmReadProduct";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Read Product";
			FormClosing += frmReadProduct_FormClosing;
			Load += frmReadProduct_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClose;
        private Label label1;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtUnitInStock;
        private Label label5;
		private Label label6;
		private Label label7;
		private TextBox txtSpecies;
	}
}