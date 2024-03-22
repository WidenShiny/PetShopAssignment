using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    public partial class frmReadMember : Form
    {
        public string tmpEmail { get; set; }

        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public User Member { get; set; }

        public frmReadMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReadMember_Load(object sender, EventArgs e)
        {
            txtMemberID.Text = Member.UserId.ToString();
			txtUserName.Text = Member.UserName;
			txtEmail.Text = Member.Email;
            txtAddress.Text = Member.Address;
            txtPhone.Text = Member.Phone;
        }

        private void frmReadMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUsers frmMembers = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail
                };
                frmMembers.Show();
            }
            else
            {
                frmUsers frmMembers = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn
                };
                frmMembers.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}