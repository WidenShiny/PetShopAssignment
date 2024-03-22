using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    partial class frmUserUpdateProfile
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
			txtSubmitPassword = new TextBox();
			label5 = new Label();
			txtUserName = new TextBox();
			label4 = new Label();
			txtPhone = new TextBox();
			label3 = new Label();
			txtAddress = new TextBox();
			label2 = new Label();
			txtPassword = new TextBox();
			label1 = new Label();
			btnClose = new Button();
			btnUpdate = new Button();
			SuspendLayout();
			// 
			// txtSubmitPassword
			// 
			txtSubmitPassword.Location = new Point(180, 82);
			txtSubmitPassword.Margin = new Padding(3, 2, 3, 2);
			txtSubmitPassword.Name = "txtSubmitPassword";
			txtSubmitPassword.PasswordChar = '*';
			txtSubmitPassword.Size = new Size(329, 23);
			txtSubmitPassword.TabIndex = 19;
			txtSubmitPassword.TextChanged += txtSubmitPassword_TextChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(54, 84);
			label5.Name = "label5";
			label5.Size = new Size(98, 15);
			label5.TabIndex = 18;
			label5.Text = "Submit Password";
			label5.Click += label5_Click;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(180, 127);
			txtUserName.Margin = new Padding(3, 2, 3, 2);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(329, 23);
			txtUserName.TabIndex = 17;
			txtUserName.TextChanged += txtCompanyName_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(54, 129);
			label4.Name = "label4";
			label4.Size = new Size(65, 15);
			label4.TabIndex = 16;
			label4.Text = "User Name";
			label4.Click += label4_Click;
			// 
			// txtPhone
			// 
			txtPhone.Location = new Point(180, 217);
			txtPhone.Margin = new Padding(3, 2, 3, 2);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(329, 23);
			txtPhone.TabIndex = 15;
			txtPhone.TextChanged += txtCountry_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(54, 219);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 14;
			label3.Text = "Phone";
			label3.Click += label3_Click;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(180, 171);
			txtAddress.Margin = new Padding(3, 2, 3, 2);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(329, 23);
			txtAddress.TabIndex = 13;
			txtAddress.TextChanged += txtCity_TextChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(54, 173);
			label2.Name = "label2";
			label2.Size = new Size(49, 15);
			label2.TabIndex = 12;
			label2.Text = "Address";
			label2.Click += label2_Click;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(180, 37);
			txtPassword.Margin = new Padding(3, 2, 3, 2);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(329, 23);
			txtPassword.TabIndex = 11;
			txtPassword.TextChanged += txtPassword_TextChanged_1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(54, 39);
			label1.Name = "label1";
			label1.Size = new Size(84, 15);
			label1.TabIndex = 10;
			label1.Text = "New Password";
			label1.Click += label1_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(373, 269);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(111, 29);
			btnClose.TabIndex = 21;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.DialogResult = DialogResult.OK;
			btnUpdate.Location = new Point(210, 269);
			btnUpdate.Margin = new Padding(3, 2, 3, 2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(111, 29);
			btnUpdate.TabIndex = 20;
			btnUpdate.Text = "Submit";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// frmUserUpdateProfile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(588, 328);
			Controls.Add(btnClose);
			Controls.Add(btnUpdate);
			Controls.Add(txtSubmitPassword);
			Controls.Add(label5);
			Controls.Add(txtUserName);
			Controls.Add(label4);
			Controls.Add(txtPhone);
			Controls.Add(label3);
			Controls.Add(txtAddress);
			Controls.Add(label2);
			Controls.Add(txtPassword);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmUserUpdateProfile";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Update Profile";
			FormClosing += frmUserUpdateProfile_FormClosing;
			Load += frmUserUpdateProfile_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtSubmitPassword;
        private Label label5;
        private TextBox txtUserName;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
    }
}