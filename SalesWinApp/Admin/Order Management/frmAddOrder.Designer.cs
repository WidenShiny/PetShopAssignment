using System.Windows.Forms;

namespace SalesWinApp.Admin.Order_Management
{
    partial class frmAddOrder
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
			txtMemberID = new TextBox();
			label2 = new Label();
			txtMemberEmail = new TextBox();
			label3 = new Label();
			txtProductID = new TextBox();
			label4 = new Label();
			txtProductName = new TextBox();
			label5 = new Label();
			txtUnitPrice = new TextBox();
			label6 = new Label();
			txtTotalMoney = new TextBox();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			txtQuantity = new TextBox();
			label11 = new Label();
			txtOrderDate = new DateTimePicker();
			txtRequiredDate = new DateTimePicker();
			txtShippedDate = new DateTimePicker();
			btnCreate = new Button();
			SuspendLayout();
			// 
			// btnClose
			// 
			btnClose.Location = new Point(390, 315);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 12;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// txtMemberID
			// 
			txtMemberID.Location = new Point(145, 99);
			txtMemberID.Margin = new Padding(3, 2, 3, 2);
			txtMemberID.MaxLength = 30;
			txtMemberID.Name = "txtMemberID";
			txtMemberID.Size = new Size(182, 23);
			txtMemberID.TabIndex = 16;
			txtMemberID.TextChanged += txtMemberID_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 101);
			label2.Name = "label2";
			label2.Size = new Size(44, 15);
			label2.TabIndex = 15;
			label2.Text = "User ID";
			label2.Click += label2_Click;
			// 
			// txtMemberEmail
			// 
			txtMemberEmail.Location = new Point(145, 136);
			txtMemberEmail.Margin = new Padding(3, 2, 3, 2);
			txtMemberEmail.Name = "txtMemberEmail";
			txtMemberEmail.ReadOnly = true;
			txtMemberEmail.Size = new Size(182, 23);
			txtMemberEmail.TabIndex = 18;
			txtMemberEmail.TextChanged += txtMemberEmail_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(45, 138);
			label3.Name = "label3";
			label3.Size = new Size(62, 15);
			label3.TabIndex = 17;
			label3.Text = "User Email";
			label3.Click += label3_Click;
			// 
			// txtProductID
			// 
			txtProductID.Location = new Point(145, 173);
			txtProductID.Margin = new Padding(3, 2, 3, 2);
			txtProductID.MaxLength = 30;
			txtProductID.Name = "txtProductID";
			txtProductID.Size = new Size(182, 23);
			txtProductID.TabIndex = 20;
			txtProductID.TextChanged += txtProductID_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(45, 176);
			label4.Name = "label4";
			label4.Size = new Size(63, 15);
			label4.TabIndex = 19;
			label4.Text = "Product ID";
			label4.Click += label4_Click;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(145, 211);
			txtProductName.Margin = new Padding(3, 2, 3, 2);
			txtProductName.Name = "txtProductName";
			txtProductName.ReadOnly = true;
			txtProductName.Size = new Size(182, 23);
			txtProductName.TabIndex = 22;
			txtProductName.TextChanged += txtProductName_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(45, 213);
			label5.Name = "label5";
			label5.Size = new Size(84, 15);
			label5.TabIndex = 21;
			label5.Text = "Product Name";
			label5.Click += label5_Click;
			// 
			// txtUnitPrice
			// 
			txtUnitPrice.Location = new Point(468, 190);
			txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
			txtUnitPrice.MaxLength = 15;
			txtUnitPrice.Name = "txtUnitPrice";
			txtUnitPrice.Size = new Size(182, 23);
			txtUnitPrice.TabIndex = 30;
			txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(369, 192);
			label6.Name = "label6";
			label6.Size = new Size(58, 15);
			label6.TabIndex = 29;
			label6.Text = "Unit Price";
			label6.Click += label6_Click;
			// 
			// txtTotalMoney
			// 
			txtTotalMoney.Location = new Point(468, 152);
			txtTotalMoney.Margin = new Padding(3, 2, 3, 2);
			txtTotalMoney.MaxLength = 15;
			txtTotalMoney.Name = "txtTotalMoney";
			txtTotalMoney.Size = new Size(182, 23);
			txtTotalMoney.TabIndex = 28;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(369, 154);
			label7.Name = "label7";
			label7.Size = new Size(69, 15);
			label7.TabIndex = 27;
			label7.Text = "TotalMoney";
			label7.Click += label7_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(369, 117);
			label8.Name = "label8";
			label8.Size = new Size(77, 15);
			label8.TabIndex = 25;
			label8.Text = "Shipped Date";
			label8.Click += label8_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(369, 80);
			label9.Name = "label9";
			label9.Size = new Size(81, 15);
			label9.TabIndex = 23;
			label9.Text = "Required Date";
			label9.Click += label9_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(369, 44);
			label10.Name = "label10";
			label10.Size = new Size(64, 15);
			label10.TabIndex = 31;
			label10.Text = "Order Date";
			label10.Click += label10_Click;
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(468, 228);
			txtQuantity.Margin = new Padding(3, 2, 3, 2);
			txtQuantity.MaxLength = 15;
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new Size(182, 23);
			txtQuantity.TabIndex = 34;
			txtQuantity.TextChanged += txtQuantity_TextChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(369, 230);
			label11.Name = "label11";
			label11.Size = new Size(53, 15);
			label11.TabIndex = 33;
			label11.Text = "Quantity";
			label11.Click += label11_Click;
			// 
			// txtOrderDate
			// 
			txtOrderDate.Location = new Point(468, 40);
			txtOrderDate.Margin = new Padding(3, 2, 3, 2);
			txtOrderDate.Name = "txtOrderDate";
			txtOrderDate.Size = new Size(182, 23);
			txtOrderDate.TabIndex = 37;
			txtOrderDate.ValueChanged += txtOrderDate_ValueChanged_1;
			// 
			// txtRequiredDate
			// 
			txtRequiredDate.Location = new Point(468, 76);
			txtRequiredDate.Margin = new Padding(3, 2, 3, 2);
			txtRequiredDate.Name = "txtRequiredDate";
			txtRequiredDate.Size = new Size(182, 23);
			txtRequiredDate.TabIndex = 38;
			txtRequiredDate.ValueChanged += txtRequiredDate_ValueChanged_1;
			// 
			// txtShippedDate
			// 
			txtShippedDate.Location = new Point(468, 113);
			txtShippedDate.Margin = new Padding(3, 2, 3, 2);
			txtShippedDate.Name = "txtShippedDate";
			txtShippedDate.Size = new Size(182, 23);
			txtShippedDate.TabIndex = 39;
			txtShippedDate.ValueChanged += txtShippedDate_ValueChanged_1;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(209, 315);
			btnCreate.Margin = new Padding(3, 2, 3, 2);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(105, 26);
			btnCreate.TabIndex = 40;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// frmAddOrder
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(700, 377);
			Controls.Add(btnCreate);
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
			Controls.Add(txtMemberID);
			Controls.Add(label2);
			Controls.Add(btnClose);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmAddOrder";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Add Order";
			FormClosing += frmAddOrder_FormClosing;
			Load += frmAddOrder_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClose;
        private TextBox txtMemberID;
        private Label label2;
        private TextBox txtMemberEmail;
        private Label label3;
        private TextBox txtProductID;
        private Label label4;
        private TextBox txtProductName;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtTotalMoney;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtQuantity;
        private Label label11;
        private DateTimePicker txtOrderDate;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtShippedDate;
        private Button btnCreate;
    }
}