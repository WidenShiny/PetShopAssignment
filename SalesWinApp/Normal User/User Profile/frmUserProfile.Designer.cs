using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    partial class frmUserProfile
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
			label1 = new Label();
			txtEmail = new TextBox();
			txtAddress = new TextBox();
			label2 = new Label();
			txtPhone = new TextBox();
			label3 = new Label();
			txtUserName = new TextBox();
			label4 = new Label();
			txtPassword = new TextBox();
			label5 = new Label();
			btnUpdate = new Button();
			btnClose = new Button();
			btnShowPassword = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(54, 39);
			label1.Name = "label1";
			label1.Size = new Size(36, 15);
			label1.TabIndex = 0;
			label1.Text = "Email";
			label1.Click += label1_Click;
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(180, 37);
			txtEmail.Margin = new Padding(3, 2, 3, 2);
			txtEmail.Name = "txtEmail";
			txtEmail.ReadOnly = true;
			txtEmail.Size = new Size(329, 23);
			txtEmail.TabIndex = 1;
			txtEmail.TextChanged += txtEmail_TextChanged;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(180, 171);
			txtAddress.Margin = new Padding(3, 2, 3, 2);
			txtAddress.Name = "txtAddress";
			txtAddress.ReadOnly = true;
			txtAddress.Size = new Size(329, 23);
			txtAddress.TabIndex = 3;
			txtAddress.TextChanged += txtCity_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(54, 173);
			label2.Name = "label2";
			label2.Size = new Size(49, 15);
			label2.TabIndex = 2;
			label2.Text = "Address";
			label2.Click += label2_Click;
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(180, 217);
			txtPhone.Margin = new Padding(3, 2, 3, 2);
			txtPhone.Name = "txtPhone";
			txtPhone.ReadOnly = true;
			txtPhone.Size = new Size(329, 23);
			txtPhone.TabIndex = 5;
			txtPhone.TextChanged += txtCountry_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(54, 219);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 4;
			label3.Text = "Phone";
			label3.Click += label3_Click;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(180, 127);
			txtUserName.Margin = new Padding(3, 2, 3, 2);
			txtUserName.Name = "txtUserName";
			txtUserName.ReadOnly = true;
			txtUserName.Size = new Size(329, 23);
			txtUserName.TabIndex = 7;
			txtUserName.TextChanged += txtCompanyName_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(54, 129);
			label4.Name = "label4";
			label4.Size = new Size(62, 15);
			label4.TabIndex = 6;
			label4.Text = "UserName";
			label4.Click += label4_Click;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(180, 82);
			txtPassword.Margin = new Padding(3, 2, 3, 2);
			txtPassword.Name = "txtPassword";
			txtPassword.ReadOnly = true;
			txtPassword.Size = new Size(197, 23);
			txtPassword.TabIndex = 9;
			txtPassword.TextChanged += txtPassword_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(54, 84);
			label5.Name = "label5";
			label5.Size = new Size(57, 15);
			label5.TabIndex = 8;
			label5.Text = "Password";
			label5.Click += label5_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(210, 269);
			btnUpdate.Margin = new Padding(3, 2, 3, 2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(111, 29);
			btnUpdate.TabIndex = 10;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(373, 269);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(111, 29);
			btnClose.TabIndex = 11;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnShowPassword
			// 
			btnShowPassword.Location = new Point(396, 80);
			btnShowPassword.Margin = new Padding(3, 2, 3, 2);
			btnShowPassword.Name = "btnShowPassword";
			btnShowPassword.Size = new Size(112, 25);
			btnShowPassword.TabIndex = 12;
			btnShowPassword.Text = "Show Password";
			btnShowPassword.UseVisualStyleBackColor = true;
			btnShowPassword.Click += btnShowPassword_Click;
			// 
			// frmUserProfile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(588, 328);
			Controls.Add(btnShowPassword);
			Controls.Add(btnClose);
			Controls.Add(btnUpdate);
			Controls.Add(txtPassword);
			Controls.Add(label5);
			Controls.Add(txtUserName);
			Controls.Add(label4);
			Controls.Add(txtPhone);
			Controls.Add(label3);
			Controls.Add(txtAddress);
			Controls.Add(label2);
			Controls.Add(txtEmail);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmUserProfile";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Profile";
			FormClosing += frmUserProfile_FormClosing;
			Load += frmUserProfile_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnShowPassword;
    }
}