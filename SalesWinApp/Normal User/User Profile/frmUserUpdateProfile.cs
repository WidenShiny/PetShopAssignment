using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    public partial class frmUserUpdateProfile : Form
    {
        public IUserRepository _memberRepository;

        public User Member { get; set; }

        public string tmpEmail { get; set; }

        public frmUserUpdateProfile()
        {
            InitializeComponent();
            _memberRepository = new UserRepository();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtSubmitPassword.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtUserName.Text != "")
            {
                if (txtPassword.Text == txtSubmitPassword.Text)
                {
                    if (txtPassword.Text != Member.Password)
                    {
                        Member.Password = txtPassword.Text;
                        Member.UserName = txtUserName.Text;
                        Member.Address = txtAddress.Text;
                        Member.Phone = txtPhone.Text;
                        _memberRepository.Update();
                        MessageBox.Show("Update successfully!");
                        btnClose_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("New Password must be different from Current Password!");
                    }
                }
                else
                {
                    MessageBox.Show("Submit Password must be the same as New Password!");
                }
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserUpdateProfile_Load(object sender, EventArgs e)
        {
            Member = _memberRepository.Getusers().Where(x => x.Email == tmpEmail).FirstOrDefault();
            txtUserName.Text = Member.UserName;
            txtAddress.Text = Member.Address;
            txtPhone.Text = Member.Phone;
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSubmitPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUserUpdateProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserProfile frmUserProfile = new()
                {
                    tmpEmail = tmpEmail
                };
                frmUserProfile.Show();
            }
            else
            {
                frmUserProfile frmUserProfile = new();
                frmUserProfile.Show();
            }
        }
    }
}