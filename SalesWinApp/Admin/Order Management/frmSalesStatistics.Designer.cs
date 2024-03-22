using System.Windows.Forms;

namespace SalesWinApp.Admin
{
    partial class frmSalesStatistics
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
			dgvSales = new DataGridView();
			label1 = new Label();
			btnSearch = new Button();
			label2 = new Label();
			label3 = new Label();
			txtStartDate = new DateTimePicker();
			txtEndDate = new DateTimePicker();
			btnClose = new Button();
			btnRead = new Button();
			((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
			SuspendLayout();
			// 
			// dgvSales
			// 
			dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSales.Location = new Point(35, 160);
			dgvSales.Margin = new Padding(3, 2, 3, 2);
			dgvSales.Name = "dgvSales";
			dgvSales.ReadOnly = true;
			dgvSales.RowHeadersWidth = 51;
			dgvSales.RowTemplate.Height = 29;
			dgvSales.Size = new Size(638, 180);
			dgvSales.TabIndex = 8;
			dgvSales.CellClick += dgvSales_CellClick;
			dgvSales.DataBindingComplete += dgvSales_DataBindingComplete;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(251, 22);
			label1.Name = "label1";
			label1.Size = new Size(186, 37);
			label1.TabIndex = 9;
			label1.Text = "Sales Statistics";
			label1.Click += label1_Click;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(500, 93);
			btnSearch.Margin = new Padding(3, 2, 3, 2);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(96, 29);
			btnSearch.TabIndex = 10;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(101, 78);
			label2.Name = "label2";
			label2.Size = new Size(58, 15);
			label2.TabIndex = 11;
			label2.Text = "Start Date";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(101, 122);
			label3.Name = "label3";
			label3.Size = new Size(54, 15);
			label3.TabIndex = 12;
			label3.Text = "End Date";
			label3.Click += label3_Click;
			// 
			// txtStartDate
			// 
			txtStartDate.Location = new Point(191, 74);
			txtStartDate.Margin = new Padding(3, 2, 3, 2);
			txtStartDate.Name = "txtStartDate";
			txtStartDate.Size = new Size(274, 23);
			txtStartDate.TabIndex = 13;
			txtStartDate.ValueChanged += txtStartDate_ValueChanged;
			// 
			// txtEndDate
			// 
			txtEndDate.Location = new Point(191, 118);
			txtEndDate.Margin = new Padding(3, 2, 3, 2);
			txtEndDate.Name = "txtEndDate";
			txtEndDate.Size = new Size(274, 23);
			txtEndDate.TabIndex = 14;
			txtEndDate.ValueChanged += txtEndDate_ValueChanged;
			// 
			// btnClose
			// 
			btnClose.Location = new Point(402, 368);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(118, 29);
			btnClose.TabIndex = 15;
			btnClose.Text = "Close";
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(191, 368);
			btnRead.Margin = new Padding(3, 2, 3, 2);
			btnRead.Name = "btnRead";
			btnRead.Size = new Size(118, 29);
			btnRead.TabIndex = 16;
			btnRead.Text = "Read";
			btnRead.UseVisualStyleBackColor = true;
			btnRead.Click += btnRead_Click;
			// 
			// frmSalesStatistics
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(710, 422);
			Controls.Add(btnRead);
			Controls.Add(btnClose);
			Controls.Add(txtEndDate);
			Controls.Add(txtStartDate);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(btnSearch);
			Controls.Add(label1);
			Controls.Add(dgvSales);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmSalesStatistics";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Sales Statistics";
			FormClosing += frmSalesStatistics_FormClosing;
			Load += frmSalesStatistics_Load;
			((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvSales;
        private Label label1;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private DateTimePicker txtStartDate;
        private DateTimePicker txtEndDate;
        private Button btnClose;
        private Button btnRead;
    }
}