using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllChat.Controller;

namespace AllChat
{
    public partial class ucLogin : UserControl
    {
        private Controll control = new Controll();

        public ucLogin()
        {
            InitializeComponent();
            pnlRegister.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string userPass = txtPassword.Text;
            txtPassword.Text = ""; //Make password retrievable once

            try
            {
                control.DoLogin(userName, userPass);
                MessageBox.Show("Succesfully logged int!");
            }
            catch (Exception ex)
            {

                lblInvalid1.Text = "The account name or password you entered is invalid.";
                lblInvalid2.Text = "Please check your information and try again.";
                txtUsername.Text = "";
            }
        }

        private void lblNew_Click(object sender, EventArgs e)
        {

        }

        private void lblNewUser_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlRegister.Visible = true;
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInvalid1_Click(object sender, EventArgs e)
        {

        }

        private void lblInvalid2_Click(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
