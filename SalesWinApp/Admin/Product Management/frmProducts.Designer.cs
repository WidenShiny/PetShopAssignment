using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmProducts
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
			dgvProducts = new DataGridView();
			txtSearch = new TextBox();
			txtSearchCatagory = new ComboBox();
			btnSearch = new Button();
			((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(207, 21);
			label1.Name = "label1";
			label1.Size = new Size(274, 37);
			label1.TabIndex = 13;
			label1.Text = "Product Management";
			label1.Click += label1_Click;
			// 
			// btnRead
			// 
			btnRead.Location = new Point(73, 338);
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
			btnClose.Location = new Point(300, 393);
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
			btnDelete.Location = new Point(525, 338);
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
			btnUpdate.Location = new Point(379, 338);
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
			btnCreate.Location = new Point(225, 338);
			btnCreate.Margin = new Padding(3, 2, 3, 2);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(105, 26);
			btnCreate.TabIndex = 8;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// dgvProducts
			// 
			dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProducts.Location = new Point(32, 128);
			dgvProducts.Margin = new Padding(3, 2, 3, 2);
			dgvProducts.Name = "dgvProducts";
			dgvProducts.ReadOnly = true;
			dgvProducts.RowHeadersWidth = 51;
			dgvProducts.RowTemplate.Height = 29;
			dgvProducts.Size = new Size(638, 180);
			dgvProducts.TabIndex = 7;
			dgvProducts.CellClick += dgvProducts_CellClick;
			dgvProducts.DataBindingComplete += dgvProducts_DataBindingComplete;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(47, 80);
			txtSearch.Margin = new Padding(3, 2, 3, 2);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(322, 23);
			txtSearch.TabIndex = 14;
			txtSearch.TextChanged += txtSearch_TextChanged;
			// 
			// txtSearchCatagory
			// 
			txtSearchCatagory.FormattingEnabled = true;
			txtSearchCatagory.Items.AddRange(new object[] { "By ID", "By Name", "By UnitPrice", "By UnitsInStock" });
			txtSearchCatagory.Location = new Point(403, 80);
			txtSearchCatagory.Margin = new Padding(3, 2, 3, 2);
			txtSearchCatagory.Name = "txtSearchCatagory";
			txtSearchCatagory.Size = new Size(113, 23);
			txtSearchCatagory.TabIndex = 15;
			txtSearchCatagory.SelectedIndexChanged += txtSearchCatagory_SelectedIndexChanged;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(548, 80);
			btnSearch.Margin = new Padding(3, 2, 3, 2);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(105, 21);
			btnSearch.TabIndex = 16;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// frmProducts
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(700, 450);
			Controls.Add(btnSearch);
			Controls.Add(txtSearchCatagory);
			Controls.Add(txtSearch);
			Controls.Add(label1);
			Controls.Add(btnRead);
			Controls.Add(btnClose);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnCreate);
			Controls.Add(dgvProducts);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmProducts";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Product Management";
			FormClosing += frmProducts_FormClosing;
			Load += frmProducts_Load;
			((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
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
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private ComboBox txtSearchCatagory;
        private Button btnSearch;
    }
}