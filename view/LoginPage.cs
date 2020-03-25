using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExpenseManager.model;
using ExpenseManager.model.service;
using ExpenseManager.utils;

namespace ExpenseManager.view
{
    public partial class LoginPage : Form
    {
        public static int userId;

        IUserService userService = new UserService();
        User user = null;
        PasswordUtil passwordUtil = new PasswordUtil();


        public LoginPage()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (this.isUserValid())
            {
                if (this.CheckPassword())
                {
                    LoginPage.userId = userService.GetUserByUsername(this.txtUsername.Text).Id;
                    this.Hide();
                    var formExpenseManager = new FormExpenseManager();
                    formExpenseManager.FormClosed += (s, args) => this.Close();
                    formExpenseManager.Show();
                }
                else
                {
                    this.lblInvalidUser.Visible = false;
                    this.lblInvalidPassword.Visible = true;
                    this.txtPassword.Text = "";
                }
            }
            else
            {
                this.lblInvalidUser.Visible = true;
                this.lblInvalidPassword.Visible = false;
                this.txtUsername.Text = "";
                this.txtPassword.Text = "";
                this.SelectNextControl((Control)sender, true, false, true, true);
            }
        }

        private bool isUserValid()
        {
            user = userService.GetUserByUsername(this.txtUsername.Text);

            return user.Username != null;
        }

        private bool CheckPassword()
        {
            user = userService.GetUserByUsername(this.txtUsername.Text);

            return passwordUtil.VerifyHash(this.txtPassword.Text, user.Password);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
                
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
