
using System.Windows.Forms;

namespace SalesWinApp.Admin.Order_Management
{
    partial class frmReadOrder
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
			txtQuantity = new TextBox();
			label11 = new Label();
			label10 = new Label();
			txtUnitPrice = new TextBox();
			label6 = new Label();
			txtTotalMoney = new TextBox();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			txtProductName = new TextBox();
			label5 = new Label();
			txtProductID = new TextBox();
			label4 = new Label();
			txtMemberEmail = new TextBox();
			label3 = new Label();
			txtUserID = new TextBox();
			label2 = new Label();
			txtOrderID = new TextBox();
			label1 = new Label();
			btnClose = new Button();
			txtOrderDate = new TextBox();
			txtRequiredDate = new TextBox();
			txtShippedDate = new TextBox();
			SuspendLayout();
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(468, 254);
			txtQuantity.Margin = new Padding(3, 2, 3, 2);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.ReadOnly = true;
			txtQuantity.Size = new Size(182, 23);
			txtQuantity.TabIndex = 59;
			txtQuantity.TextChanged += txtQuantity_TextChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(369, 256);
			label11.Name = "label11";
			label11.Size = new Size(53, 15);
			label11.TabIndex = 58;
			label11.Text = "Quantity";
			label11.Click += label11_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(369, 70);
			label10.Name = "label10";
			label10.Size = new Size(64, 15);
			label10.TabIndex = 57;
			label10.Text = "Order Date";
			label10.Click += label10_Click;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(468, 216);
			txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.ReadOnly = true;
			txtUnitPrice.Size = new Size(182, 23);
			txtUnitPrice.TabIndex = 56;
			txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(369, 218);
			label6.Name = "label6";
			label6.Size = new Size(58, 15);
			label6.TabIndex = 55;
			label6.Text = "Unit Price";
			label6.Click += label6_Click;
			// 
			// txtTotalMoney
			// 
			txtTotalMoney.Location = new Point(468, 178);
			txtTotalMoney.Margin = new Padding(3, 2, 3, 2);
			txtTotalMoney.Name = "txtTotalMoney";
			txtTotalMoney.ReadOnly = true;
			txtTotalMoney.Size = new Size(182, 23);
			txtTotalMoney.TabIndex = 54;
			txtTotalMoney.TextChanged += txtFreight_TextChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(369, 181);
			label7.Name = "label7";
			label7.Size = new Size(69, 15);
			label7.TabIndex = 53;
			label7.Text = "TotalMoney";
			label7.Click += label7_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(369, 143);
			label8.Name = "label8";
			label8.Size = new Size(77, 15);
			label8.TabIndex = 52;
			label8.Text = "Shipped Date";
			label8.Click += label8_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(369, 106);
			label9.Name = "label9";
			label9.Size = new Size(81, 15);
			label9.TabIndex = 51;
			label9.Text = "Required Date";
			label9.Click += label9_Click;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(145, 237);
			txtProductName.Margin = new Padding(3, 2, 3, 2);
			txtProductName.Name = "txtProductName";
			txtProductName.ReadOnly = true;
			txtProductName.Size = new Size(182, 23);
			txtProductName.TabIndex = 50;
			txtProductName.TextChanged += txtProductName_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(45, 239);
			label5.Name = "label5";
			label5.Size = new Size(84, 15);
			label5.TabIndex = 49;
			label5.Text = "Product Name";
			label5.Click += label5_Click;
			// 
			// txtProductID
			// 
			txtProductID.Location = new Point(145, 200);
			txtProductID.Margin = new Padding(3, 2, 3, 2);
			txtProductID.Name = "txtProductID";
			txtProductID.ReadOnly = true;
			txtProductID.Size = new Size(182, 23);
			txtProductID.TabIndex = 48;
			txtProductID.TextChanged += txtProductID_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(45, 202);
			label4.Name = "label4";
			label4.Size = new Size(63, 15);
			label4.TabIndex = 47;
			label4.Text = "Product ID";
			label4.Click += label4_Click;
			// 
			// txtMemberEmail
			// 
			txtMemberEmail.Location = new Point(145, 162);
			txtMemberEmail.Margin = new Padding(3, 2, 3, 2);
			txtMemberEmail.Name = "txtMemberEmail";
			txtMemberEmail.ReadOnly = true;
			txtMemberEmail.Size = new Size(182, 23);
			txtMemberEmail.TabIndex = 46;
			txtMemberEmail.TextChanged += txtMemberEmail_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(45, 164);
			label3.Name = "label3";
			label3.Size = new Size(62, 15);
			label3.TabIndex = 45;
			label3.Text = "User Email";
			label3.Click += label3_Click;
			// 
			// txtUserID
			// 
			txtUserID.Location = new Point(145, 125);
			txtUserID.Margin = new Padding(3, 2, 3, 2);
			txtUserID.Name = "txtUserID";
			txtUserID.ReadOnly = true;
			txtUserID.Size = new Size(182, 23);
			txtUserID.TabIndex = 44;
			txtUserID.TextChanged += txtMemberID_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 128);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 43;
			label2.Text = "User ID";
			label2.Click += label2_Click;
			// 
			// txtOrderID
			// 
			txtOrderID.Location = new Point(302, 24);
			txtOrderID.Margin = new Padding(3, 2, 3, 2);
			txtOrderID.Name = "txtOrderID";
			txtOrderID.ReadOnly = true;
			txtOrderID.Size = new Size(182, 23);
			txtOrderID.TabIndex = 42;
			txtOrderID.TextChanged += txtOrderID_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(206, 26);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 41;
			label1.Text = "Order ID";
			label1.Click += label1_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(302, 341);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 40;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// txtOrderDate
			// 
			txtOrderDate.Location = new Point(468, 68);
			txtOrderDate.Margin = new Padding(3, 2, 3, 2);
			txtOrderDate.Name = "txtOrderDate";
			txtOrderDate.ReadOnly = true;
			txtOrderDate.Size = new Size(182, 23);
			txtOrderDate.TabIndex = 62;
			txtOrderDate.TextChanged += txtOrderDate_TextChanged;
			// 
			// txtRequiredDate
			// 
			txtRequiredDate.Location = new Point(468, 104);
			txtRequiredDate.Margin = new Padding(3, 2, 3, 2);
			txtRequiredDate.Name = "txtRequiredDate";
			txtRequiredDate.ReadOnly = true;
			txtRequiredDate.Size = new Size(182, 23);
			txtRequiredDate.TabIndex = 63;
			txtRequiredDate.TextChanged += txtRequiredDate_TextChanged;
			// 
			// txtShippedDate
			// 
			txtShippedDate.Location = new Point(468, 141);
			txtShippedDate.Margin = new Padding(3, 2, 3, 2);
			txtShippedDate.Name = "txtShippedDate";
			txtShippedDate.ReadOnly = true;
			txtShippedDate.Size = new Size(182, 23);
			txtShippedDate.TabIndex = 64;
			txtShippedDate.TextChanged += txtShippedDate_TextChanged;
			// 
			// frmReadOrder
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(700, 388);
			Controls.Add(txtShippedDate);
			Controls.Add(txtRequiredDate);
			Controls.Add(txtOrderDate);
			Controls.Add(txtQuantity);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(txtUnitPrice);
			Controls.Add(label6);
			Controls.Add(txtTotalMoney);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(txtProductName);
			Controls.Add(label5);
			Controls.Add(txtProductID);
			Controls.Add(label4);
			Controls.Add(txtMemberEmail);
			Controls.Add(label3);
			Controls.Add(txtUserID);
			Controls.Add(label2);
			Controls.Add(txtOrderID);
			Controls.Add(label1);
			Controls.Add(btnClose);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmReadOrder";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Read Order Details";
			FormClosing += frmReadOrder_FormClosing;
			Load += frmReadOrder_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtQuantity;
        private Label label11;
        private Label label10;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtTotalMoney;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtProductName;
        private Label label5;
        private TextBox txtProductID;
        private Label label4;
        private TextBox txtMemberEmail;
        private Label label3;
        private TextBox txtUserID;
        private Label label2;
        private TextBox txtOrderID;
        private Label label1;
        private Button btnClose;
        private TextBox txtOrderDate;
        private TextBox txtRequiredDate;
        private TextBox txtShippedDate;
    }
}