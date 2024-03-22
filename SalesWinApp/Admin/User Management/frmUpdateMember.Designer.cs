using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    partial class frmUpdateMember
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
			label6 = new Label();
			txtPhone = new TextBox();
			label3 = new Label();
			txtAddress = new TextBox();
			txtEmail = new TextBox();
			label2 = new Label();
			txtMemberID = new TextBox();
			label1 = new Label();
			btnClose = new Button();
			btnUpdate = new Button();
			txtPassword = new TextBox();
			label5 = new Label();
			txtUserName = new TextBox();
			label7 = new Label();
			SuspendLayout();
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(38, 247);
			label6.Name = "label6";
			label6.Size = new Size(49, 15);
			label6.TabIndex = 23;
			label6.Text = "Address";
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(168, 294);
			txtPhone.Margin = new Padding(3, 2, 3, 2);
			txtPhone.MaxLength = 15;
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(253, 23);
			txtPhone.TabIndex = 22;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(38, 297);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 21;
			label3.Text = "Phone";
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(168, 244);
			txtAddress.Margin = new Padding(3, 2, 3, 2);
			txtAddress.MaxLength = 40;
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(253, 23);
			txtAddress.TabIndex = 20;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(168, 140);
			txtEmail.Margin = new Padding(3, 2, 3, 2);
			txtEmail.Name = "txtEmail";
			txtEmail.ReadOnly = true;
			txtEmail.Size = new Size(253, 23);
			txtEmail.TabIndex = 18;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(38, 143);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 17;
			label2.Text = "Email";
			// 
			// txtMemberID
			// 
			txtMemberID.Location = new Point(168, 38);
			txtMemberID.Margin = new Padding(3, 2, 3, 2);
			txtMemberID.Name = "txtMemberID";
			txtMemberID.ReadOnly = true;
			txtMemberID.Size = new Size(253, 23);
			txtMemberID.TabIndex = 16;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(38, 40);
			label1.Name = "label1";
			label1.Size = new Size(44, 15);
			label1.TabIndex = 15;
			label1.Text = "User ID";
			// 
			// btnClose
			// 
			btnClose.Location = new Point(310, 361);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(111, 30);
			btnClose.TabIndex = 14;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.DialogResult = DialogResult.OK;
			btnUpdate.Location = new Point(122, 361);
			btnUpdate.Margin = new Padding(3, 2, 3, 2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(111, 30);
			btnUpdate.TabIndex = 27;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(168, 194);
			txtPassword.Margin = new Padding(3, 2, 3, 2);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.ReadOnly = true;
			txtPassword.Size = new Size(253, 23);
			txtPassword.TabIndex = 29;
			txtPassword.Text = "123";
			txtPassword.TextChanged += txtPassword_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(38, 197);
			label5.Name = "label5";
			label5.Size = new Size(57, 15);
			label5.TabIndex = 28;
			label5.Text = "Password";
			label5.Click += label5_Click;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(168, 86);
			txtUserName.Margin = new Padding(3, 2, 3, 2);
			txtUserName.Name = "txtUserName";
			txtUserName.ReadOnly = true;
			txtUserName.Size = new Size(253, 23);
			txtUserName.TabIndex = 18;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(38, 89);
			label7.Name = "label7";
			label7.Size = new Size(62, 15);
			label7.TabIndex = 17;
			label7.Text = "UserName";
			// 
			// frmUpdateMember
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(465, 416);
			Controls.Add(txtPassword);
			Controls.Add(label5);
			Controls.Add(btnUpdate);
			Controls.Add(label6);
			Controls.Add(txtPhone);
			Controls.Add(label3);
			Controls.Add(txtAddress);
			Controls.Add(txtUserName);
			Controls.Add(txtEmail);
			Controls.Add(label7);
			Controls.Add(label2);
			Controls.Add(txtMemberID);
			Controls.Add(label1);
			Controls.Add(btnClose);
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmUpdateMember";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Update Member";
			FormClosing += frmUpdateMember_FormClosing;
			Load += frmUpdateMember_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtCountry;
        private Label label6;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtMemberID;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label label5;
		private TextBox txtUserName;
		private Label label7;
	}
}