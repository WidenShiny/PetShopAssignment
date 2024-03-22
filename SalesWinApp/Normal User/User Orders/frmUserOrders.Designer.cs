using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    partial class frmUserOrders
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
			dgvOrders = new DataGridView();
			label1 = new Label();
			btnClose = new Button();
			btnRead = new Button();
			((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
			SuspendLayout();
			// 
			// dgvOrders
			// 
			dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvOrders.Location = new Point(32, 79);
			dgvOrders.Margin = new Padding(3, 2, 3, 2);
			dgvOrders.Name = "dgvOrders";
			dgvOrders.ReadOnly = true;
			dgvOrders.RowHeadersWidth = 51;
			dgvOrders.RowTemplate.Height = 29;
			dgvOrders.Size = new Size(638, 180);
			dgvOrders.TabIndex = 1;
			dgvOrders.CellClick += dgvOrders_CellClick;
			dgvOrders.DataBindingComplete += dgvOrders_DataBindingComplete;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(269, 22);
			label1.Name = "label1";
			label1.Size = new Size(156, 37);
			label1.TabIndex = 2;
			label1.Text = "Your Orders";
			label1.Click += label1_Click;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(403, 289);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(105, 26);
			btnClose.TabIndex = 12;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(199, 289);
			btnRead.Margin = new Padding(3, 2, 3, 2);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(105, 26);
			btnRead.TabIndex = 13;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			btnRead.Click += btnRead_Click;
			// 
			// frmUserOrders
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(700, 344);
			Controls.Add(btnRead);
			Controls.Add(btnClose);
			Controls.Add(label1);
			Controls.Add(dgvOrders);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmUserOrders";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Orders";
			FormClosing += frmUserOrders_FormClosing;
			Load += frmUserOrders_Load;
			((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvOrders;
        private Label label1;
        private Button btnClose;
        private Button btnRead;
    }
}