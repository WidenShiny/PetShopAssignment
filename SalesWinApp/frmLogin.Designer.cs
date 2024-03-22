using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmLogin
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			txtEmail = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			btnClose = new Button();
			pictureBox1 = new PictureBox();
			label3 = new Label();
			label4 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(496, 154);
			txtEmail.Margin = new Padding(3, 2, 3, 2);
			txtEmail.MaxLength = 100;
			txtEmail.Name = "txtEmail";
			txtEmail.PlaceholderText = "Enter email";
			txtEmail.Size = new Size(214, 23);
			txtEmail.TabIndex = 2;
			txtEmail.TextChanged += txtEmail_TextChanged;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(496, 226);
			txtPassword.Margin = new Padding(3, 2, 3, 2);
			txtPassword.MaxLength = 30;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.PlaceholderText = "Enter password";
			txtPassword.Size = new Size(214, 23);
			txtPassword.TabIndex = 3;
			txtPassword.TextChanged += txtPassword_TextChanged;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(496, 295);
			btnLogin.Margin = new Padding(3, 2, 3, 2);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(86, 39);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(588, 295);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(97, 39);
			btnClose.TabIndex = 6;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(41, 117);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(183, 152);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(355, 149);
			label3.Name = "label3";
			label3.Size = new Size(59, 28);
			label3.TabIndex = 10;
			label3.Text = "Email";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(355, 221);
			label4.Name = "label4";
			label4.Size = new Size(93, 28);
			label4.TabIndex = 11;
			label4.Text = "Password";
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(265, 40);
			label1.Name = "label1";
			label1.Size = new Size(276, 43);
			label1.TabIndex = 12;
			label1.Text = "Welcome To PetShop";
			// 
			// frmLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(829, 444);
			Controls.Add(label1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(pictureBox1);
			Controls.Add(btnClose);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtEmail);
			ForeColor = SystemColors.ActiveCaptionText;
			FormBorderStyle = FormBorderStyle.None;
			KeyPreview = true;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			Load += frmLogin_Load;
			KeyDown += frmLogin_KeyDown;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClose;
		private PictureBox pictureBox1;
		private Label label3;
		private Label label4;
		private Label label1;
	}
}