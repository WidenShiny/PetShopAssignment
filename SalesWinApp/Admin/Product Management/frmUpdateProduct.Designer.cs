using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    partial class frmUpdateProduct
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
			txtProductID = new TextBox();
			label1 = new Label();
			btnClose = new Button();
			btnUpdate = new Button();
			txtSpecies = new TextBox();
			label6 = new Label();
			SuspendLayout();
			// 
			// txtUnitInStock
			// 
			txtUnitInStock.Location = new Point(150, 286);
			txtUnitInStock.Margin = new Padding(3, 2, 3, 2);
			txtUnitInStock.MaxLength = 15;
			txtUnitInStock.Name = "txtUnitInStock";
			txtUnitInStock.Size = new Size(220, 23);
			txtUnitInStock.TabIndex = 35;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(47, 289);
			label5.Name = "label5";
			label5.Size = new Size(79, 15);
			label5.TabIndex = 34;
			label5.Text = "Units In Stock";
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(150, 237);
			txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
			txtUnitPrice.MaxLength = 15;
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(220, 23);
			txtUnitPrice.TabIndex = 33;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(47, 240);
			label3.Name = "label3";
			label3.Size = new Size(58, 15);
			label3.TabIndex = 32;
			label3.Text = "Unit Price";
			// 
			// txtWeight
			// 
			txtWeight.Location = new Point(150, 137);
			txtWeight.Margin = new Padding(3, 2, 3, 2);
			txtWeight.MaxLength = 20;
			txtWeight.Name = "txtWeight";
			txtWeight.Size = new Size(220, 23);
			txtWeight.TabIndex = 31;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(47, 140);
			label4.Name = "label4";
			label4.Size = new Size(45, 15);
			label4.TabIndex = 30;
			label4.Text = "Weight";
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(150, 88);
			txtProductName.Margin = new Padding(3, 2, 3, 2);
			txtProductName.MaxLength = 40;
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(220, 23);
			txtProductName.TabIndex = 29;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(47, 90);
			label2.Name = "label2";
			label2.Size = new Size(84, 15);
			label2.TabIndex = 28;
			label2.Text = "Product Name";
			// 
			// txtProductID
			// 
			txtProductID.Location = new Point(150, 38);
			txtProductID.Margin = new Padding(3, 2, 3, 2);
			txtProductID.Name = "txtProductID";
			txtProductID.ReadOnly = true;
			txtProductID.Size = new Size(220, 23);
			txtProductID.TabIndex = 27;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 40);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 26;
			label1.Text = "Product ID";
			// 
			// btnClose
			// 
			btnClose.Location = new Point(250, 339);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 25;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(92, 339);
			btnUpdate.Margin = new Padding(3, 2, 3, 2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(105, 26);
			btnUpdate.TabIndex = 36;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(150, 189);
			txtSpecies.Margin = new Padding(3, 2, 3, 2);
			txtSpecies.MaxLength = 20;
			txtSpecies.Name = "txtSpecies";
			txtSpecies.Size = new Size(220, 23);
			txtSpecies.TabIndex = 31;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(47, 192);
			label6.Name = "label6";
			label6.Size = new Size(46, 15);
			label6.TabIndex = 30;
			label6.Text = "Species";
			// 
			// frmUpdateProduct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(434, 390);
			Controls.Add(btnUpdate);
			Controls.Add(txtUnitInStock);
			Controls.Add(label5);
			Controls.Add(txtUnitPrice);
			Controls.Add(label3);
			Controls.Add(txtSpecies);
			Controls.Add(txtWeight);
			Controls.Add(label6);
			Controls.Add(label4);
			Controls.Add(txtProductName);
			Controls.Add(label2);
			Controls.Add(txtProductID);
			Controls.Add(label1);
			Controls.Add(btnClose);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmUpdateProduct";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmUpdateProduct";
			FormClosing += frmUpdateProduct_FormClosing;
			Load += frmUpdateProduct_Load;
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
        private TextBox txtProductID;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
		private TextBox txtSpecies;
		private Label label6;
	}
}