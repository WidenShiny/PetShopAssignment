using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmUsers
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
			dgvMembers = new DataGridView();
			btnCreate = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			btnClose = new Button();
			btnRead = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
			SuspendLayout();
			// 
			// dgvMembers
			// 
			dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMembers.Location = new Point(32, 75);
			dgvMembers.Margin = new Padding(3, 2, 3, 2);
			dgvMembers.Name = "dgvMembers";
			dgvMembers.ReadOnly = true;
			dgvMembers.RowHeadersWidth = 51;
			dgvMembers.RowTemplate.Height = 29;
			dgvMembers.Size = new Size(638, 180);
			dgvMembers.TabIndex = 6;
			dgvMembers.CellClick += dgvMembers_CellClick;
			dgvMembers.DataBindingComplete += dgvMembers_DataBindingComplete;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(225, 286);
			btnCreate.Margin = new Padding(3, 2, 3, 2);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(105, 26);
			btnCreate.TabIndex = 2;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(379, 286);
			btnUpdate.Margin = new Padding(3, 2, 3, 2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(105, 26);
			btnUpdate.TabIndex = 3;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(525, 286);
			btnDelete.Margin = new Padding(3, 2, 3, 2);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(105, 26);
			btnDelete.TabIndex = 4;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(300, 340);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 5;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(73, 286);
			btnRead.Margin = new Padding(3, 2, 3, 2);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(105, 26);
			btnRead.TabIndex = 1;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			btnRead.Click += btnRead_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(249, 19);
			label1.Name = "label1";
			label1.Size = new Size(235, 37);
			label1.TabIndex = 0;
			label1.Text = "User Management";
			label1.Click += label1_Click;
			// 
			// frmUsers
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(700, 392);
			Controls.Add(label1);
			Controls.Add(btnRead);
			Controls.Add(btnClose);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnCreate);
			Controls.Add(dgvMembers);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmUsers";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Member Management";
			FormClosing += frmMembers_FormClosing;
			Load += frmMembers_Load;
			((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvMembers;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnRead;
        private Label label1;
    }
}