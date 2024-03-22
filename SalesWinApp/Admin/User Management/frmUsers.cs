using DataAccess.Models;
using DataAccess.Repository;
using SalesWinApp.Admin.Member_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SalesWinApp
{
    public partial class frmUsers : Form
    {
        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }

        public IUserRepository _memberRepository;
        public IOrderRepository _orderRepository;

        BindingSource _source;

        public User CurrentGrid = new();

        public frmUsers()
        {
            _memberRepository = new UserRepository();
            _orderRepository = new OrderRepository();
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUpdateMember frmUpdateMember = new()
                {
                    Member = CurrentGrid,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmUpdateMember.Show();
            }
            else
            {
                frmUpdateMember frmUpdateMember = new()
                {
                    Member = CurrentGrid,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                };
                this.Hide();
                frmUpdateMember.Show();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmReadMember frmReadMember = new()
                {
                    Member = CurrentGrid,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmReadMember.Show();
            }
            else
            {
                frmReadMember frmReadMember = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    Member = CurrentGrid
                };
                this.Hide();
                frmReadMember.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmAddUser frmAddMember = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmAddMember.Show();
            }
            else
            {
                frmAddUser frmAddMember = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn
                };
                this.Hide();
                frmAddMember.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var comfirmationResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CurrentGrid.Email != "admin@petshop.com" && comfirmationResult == DialogResult.Yes)
            {
                var check = _orderRepository.GetOrders().FirstOrDefault(c => c.UserId == CurrentGrid.UserId);
                if (check == null)
                {
                    _memberRepository.Delete(CurrentGrid.Email);
                    MessageBox.Show("Delete successfully!");
                    LoadAllMembers();
                }
                else
                {
                    MessageBox.Show("This user cannot be deleted because there is an Order that involves them!");
                }
            }
            else
            {
                //MessageBox.Show("You cannot delete an administrator!");
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadAllMembers();
            if (dgvMembers.Rows.Count > 0)
            {
                //dgvMembers.CurrentCell = dgvMembers.Rows[CurrentRow].Cells[CurrentColumn];
                CurrentGrid.UserId = int.Parse(dgvMembers.Rows[CurrentRow].Cells[0].Value.ToString());
				CurrentGrid.UserName = dgvMembers.Rows[CurrentRow].Cells[1].Value.ToString();
				CurrentGrid.Email = dgvMembers.Rows[CurrentRow].Cells[2].Value.ToString();
                CurrentGrid.Address = dgvMembers.Rows[CurrentRow].Cells[3].Value.ToString();
                CurrentGrid.Phone = dgvMembers.Rows[CurrentRow].Cells[4].Value.ToString();
            }
        }

        private void LoadAllMembers()
        {
            var allMembers = _memberRepository.Getusers();
            try
            {
                _source = new BindingSource();
                _source.DataSource = allMembers;

                dgvMembers.DataSource = null;
                dgvMembers.DataSource = _source;

                if (allMembers.Count() == 0)
                {
                    btnRead.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnRead.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    CurrentGrid.UserId = int.Parse(dgvMembers.Rows[0].Cells[0].Value.ToString());
					CurrentGrid.UserName = dgvMembers.Rows[0].Cells[1].Value.ToString();
					CurrentGrid.Email = dgvMembers.Rows[0].Cells[2].Value.ToString();
                    CurrentGrid.Address = dgvMembers.Rows[0].Cells[3].Value.ToString();
                    CurrentGrid.Phone = dgvMembers.Rows[0].Cells[4].Value.ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _memberRepository.Getusers().Count && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                CurrentRow = e.RowIndex;
                CurrentColumn = e.ColumnIndex;

				CurrentGrid.UserId = int.Parse(dgvMembers.Rows[e.RowIndex].Cells[0].Value.ToString());
				CurrentGrid.UserName = dgvMembers.Rows[e.RowIndex].Cells[1].Value.ToString();
				CurrentGrid.Email = dgvMembers.Rows[e.RowIndex].Cells[2].Value.ToString();
				CurrentGrid.Address = dgvMembers.Rows[e.RowIndex].Cells[3].Value.ToString();
				CurrentGrid.Phone = dgvMembers.Rows[e.RowIndex].Cells[4].Value.ToString();
			}
            else
            {
                btnRead.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void frmMembers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmMain frmMain = new()
                {
                    tmpEmail = tmpEmail
                };
                frmMain.Show();
            }
            else
            {
                frmMain frmMain = new();
                frmMain.Show();
            }
        }

        private void dgvMembers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvMembers.Columns["Orders"].Visible = false;
            this.dgvMembers.Columns["Password"].Visible = false;
        }
    }
}