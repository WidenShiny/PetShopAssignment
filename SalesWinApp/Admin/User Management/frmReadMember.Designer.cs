using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    partial class frmReadMember
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
			txtMemberID = new TextBox();
			txtEmail = new TextBox();
			label2 = new Label();
			txtAddress = new TextBox();
			label3 = new Label();
			txtUserName = new TextBox();
			label4 = new Label();
			txtPhone = new TextBox();
			label6 = new Label();
			txtPassword = new TextBox();
			label5 = new Label();
			SuspendLayout();
			// 
			// btnClose
			// 
			btnClose.Location = new Point(168, 370);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(111, 30);
			btnClose.TabIndex = 1;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(38, 41);
			label1.Name = "label1";
			label1.Size = new Size(44, 15);
			label1.TabIndex = 2;
			label1.Text = "User ID";
			// 
			// txtMemberID
			// 
			txtMemberID.Location = new Point(168, 38);
			txtMemberID.Margin = new Padding(3, 2, 3, 2);
			txtMemberID.Name = "txtMemberID";
			txtMemberID.ReadOnly = true;
			txtMemberID.Size = new Size(253, 23);
			txtMemberID.TabIndex = 3;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(168, 154);
			txtEmail.Margin = new Padding(3, 2, 3, 2);
			txtEmail.Name = "txtEmail";
			txtEmail.ReadOnly = true;
			txtEmail.Size = new Size(253, 23);
			txtEmail.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(38, 157);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 4;
			label2.Text = "Email";
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(168, 272);
			txtAddress.Margin = new Padding(3, 2, 3, 2);
			txtAddress.Name = "txtAddress";
			txtAddress.ReadOnly = true;
			txtAddress.Size = new Size(253, 23);
			txtAddress.TabIndex = 9;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(38, 275);
			label3.Name = "label3";
			label3.Size = new Size(49, 15);
			label3.TabIndex = 8;
			label3.Text = "Address";
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(168, 94);
			txtUserName.Margin = new Padding(3, 2, 3, 2);
			txtUserName.Name = "txtUserName";
			txtUserName.ReadOnly = true;
			txtUserName.Size = new Size(253, 23);
			txtUserName.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(38, 328);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 6;
			label4.Text = "Phone";
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(168, 325);
			txtPhone.Margin = new Padding(3, 2, 3, 2);
			txtPhone.Name = "txtPhone";
			txtPhone.ReadOnly = true;
			txtPhone.Size = new Size(253, 23);
			txtPhone.TabIndex = 11;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(38, 97);
			label6.Name = "label6";
			label6.Size = new Size(62, 15);
			label6.TabIndex = 10;
			label6.Text = "UserName";
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(168, 211);
			txtPassword.Margin = new Padding(3, 2, 3, 2);
			txtPassword.Name = "txtPassword";
			txtPassword.ReadOnly = true;
			txtPassword.Size = new Size(253, 23);
			txtPassword.TabIndex = 13;
			txtPassword.Text = "********";
			txtPassword.TextChanged += txtPassword_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(38, 214);
			label5.Name = "label5";
			label5.Size = new Size(57, 15);
			label5.TabIndex = 12;
			label5.Text = "Password";
			label5.Click += label5_Click;
			// 
			// frmReadMember
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(465, 426);
			Controls.Add(txtPassword);
			Controls.Add(label5);
			Controls.Add(txtPhone);
			Controls.Add(label6);
			Controls.Add(txtAddress);
			Controls.Add(label3);
			Controls.Add(txtUserName);
			Controls.Add(label4);
			Controls.Add(txtEmail);
			Controls.Add(label2);
			Controls.Add(txtMemberID);
			Controls.Add(label1);
			Controls.Add(btnClose);
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmReadMember";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Read Member";
			FormClosing += frmReadMember_FormClosing;
			Load += frmReadMember_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClose;
        private Label label1;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtPassword;
        private Label label5;
    }
}