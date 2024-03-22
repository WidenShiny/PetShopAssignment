using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    public partial class frmAddUser : Form
    {
        public static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public Regex ValidEmailRegex = CreateValidEmailRegex();

        public bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);
            return isValid;
        }

        private bool isAdded = false;

        public IUserRepository _memberRepository;

        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public string tmpEmail { get; set; }

        public frmAddUser()
        {
            _memberRepository = new UserRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAdded)
            {
                if (tmpEmail != null)
                {
                    frmUsers frmMembers = new()
                    {
                        tmpEmail = tmpEmail
                    };
                    frmMembers.Show();
                }
                else
                {
                    frmUsers frmMembers = new();
                    frmMembers.Show();
                }
            }
            else
            {
                if (tmpEmail != null)
                {
                    frmUsers frmMembers = new()
                    {
                        tmpEmail = tmpEmail,
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var checkEmail = _memberRepository.Getusers()
                .Where(c => c.Email.Trim().ToLower().Equals(txtEmail.Text.Trim().ToLower()))
                .SingleOrDefault();
            if (txtEmail.Text != "" && txtUserName.Text != "" && txtAddress.Text != "" && txtPhone.Text != "")
            {
                if (checkEmail == null)
                {
                    if (EmailIsValid(txtEmail.Text))
                    {
                        User member = new()
                        {
                            Email = txtEmail.Text,
                            UserName = txtUserName.Text,
                            Address = txtAddress.Text,
                            Phone = txtPhone.Text,
                            Password = txtPassword.Text
                        };
                        _memberRepository.Create(member);
                        MessageBox.Show("Added successfully!");
                        isAdded = true;
                        btnClose_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Email is not in correct format!");
                    }
                }
                else
                {
                    MessageBox.Show("This Email has been used!");
                }
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }
        private void frmAddMember_Load(object sender, EventArgs e)
        {

        }
    }
}