using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmMain
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
			btnMemberManagement = new Button();
			btnOrderManagement = new Button();
			btnProductManagement = new Button();
			btnClose = new Button();
			btnLogout = new Button();
			btnStatistics = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(295, 22);
			label1.Name = "label1";
			label1.Size = new Size(102, 45);
			label1.TabIndex = 0;
			label1.Text = "Menu";
			label1.Click += label1_Click;
			// 
			// btnMemberManagement
			// 
			btnMemberManagement.Location = new Point(154, 92);
			btnMemberManagement.Margin = new Padding(3, 2, 3, 2);
			btnMemberManagement.Name = "btnMemberManagement";
			btnMemberManagement.Size = new Size(396, 26);
			btnMemberManagement.TabIndex = 1;
			btnMemberManagement.Text = "User Management";
			btnMemberManagement.UseVisualStyleBackColor = true;
			btnMemberManagement.Click += btnMemberManagement_Click;
			// 
			// btnOrderManagement
			// 
			btnOrderManagement.Location = new Point(154, 208);
			btnOrderManagement.Margin = new Padding(3, 2, 3, 2);
			btnOrderManagement.Name = "btnOrderManagement";
			btnOrderManagement.Size = new Size(396, 26);
			btnOrderManagement.TabIndex = 3;
			btnOrderManagement.Text = "Order Management";
			btnOrderManagement.UseVisualStyleBackColor = true;
			btnOrderManagement.Click += btnOrderManagement_Click;
			// 
			// btnProductManagement
			// 
			btnProductManagement.Location = new Point(154, 150);
			btnProductManagement.Margin = new Padding(3, 2, 3, 2);
			btnProductManagement.Name = "btnProductManagement";
			btnProductManagement.Size = new Size(396, 26);
			btnProductManagement.TabIndex = 2;
			btnProductManagement.Text = "Product Management";
			btnProductManagement.UseVisualStyleBackColor = true;
			btnProductManagement.Click += btnProductManagement_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(154, 316);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(396, 26);
			btnClose.TabIndex = 5;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnLogout
			// 
			btnLogout.Location = new Point(580, 34);
			btnLogout.Margin = new Padding(3, 2, 3, 2);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(94, 29);
			btnLogout.TabIndex = 6;
			btnLogout.Text = "Log out";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// btnStatistics
			// 
			btnStatistics.Location = new Point(154, 262);
			btnStatistics.Margin = new Padding(3, 2, 3, 2);
			btnStatistics.Name = "btnStatistics";
			btnStatistics.Size = new Size(396, 26);
			btnStatistics.TabIndex = 4;
			btnStatistics.Text = "Sales Statistics";
			btnStatistics.UseVisualStyleBackColor = true;
			btnStatistics.Click += btnStatistics_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(700, 386);
			Controls.Add(btnStatistics);
			Controls.Add(btnLogout);
			Controls.Add(btnClose);
			Controls.Add(btnProductManagement);
			Controls.Add(btnOrderManagement);
			Controls.Add(btnMemberManagement);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmMain";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Menu";
			FormClosing += frmMain_FormClosing;
			Load += frmMain_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Button btnMemberManagement;
        private Button btnOrderManagement;
        private Button btnProductManagement;
        private Button btnClose;
        private Button btnLogout;
        private Button btnStatistics;
    }
}