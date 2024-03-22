using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmOrders
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
			btnRead = new Button();
			btnClose = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			btnCreate = new Button();
			dgvOrders = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(234, 22);
			label1.Name = "label1";
			label1.Size = new Size(250, 37);
			label1.TabIndex = 13;
			label1.Text = "Order Management";
			label1.Click += label1_Click;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(73, 286);
			btnRead.Margin = new Padding(3, 2, 3, 2);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(105, 26);
			btnRead.TabIndex = 12;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			btnRead.Click += btnRead_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(300, 340);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 11;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(525, 286);
			btnDelete.Margin = new Padding(3, 2, 3, 2);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(105, 26);
			btnDelete.TabIndex = 10;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(379, 286);
			btnUpdate.Margin = new Padding(3, 2, 3, 2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(105, 26);
			btnUpdate.TabIndex = 9;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(225, 286);
			btnCreate.Margin = new Padding(3, 2, 3, 2);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(105, 26);
			btnCreate.TabIndex = 8;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// dgvOrders
			// 
			dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrders.Location = new Point(32, 75);
			dgvOrders.Margin = new Padding(3, 2, 3, 2);
			dgvOrders.Name = "dgvOrders";
			dgvOrders.ReadOnly = true;
			dgvOrders.RowHeadersWidth = 51;
			dgvOrders.RowTemplate.Height = 29;
			dgvOrders.Size = new Size(638, 180);
			dgvOrders.TabIndex = 7;
			dgvOrders.CellClick += dgvOrders_CellClick;
			dgvOrders.DataBindingComplete += dgvOrders_DataBindingComplete;
			// 
			// frmOrders
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
			Controls.Add(dgvOrders);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmOrders";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Order Management";
			FormClosing += frmOrders_FormClosing;
			Load += frmOrders_Load;
			((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Button btnRead;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private DataGridView dgvOrders;
    }
}