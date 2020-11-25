using CSE412_Group17.controllers;
using CSE412_Group17.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE412_Group17
{
    public partial class SignInRegPg : Form
    {

        public SignInRegPg()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please Enter Username");
                return;
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter Password");
                return;
            }
            bool notFound = true;
            UserCTRL userctrl = new UserCTRL();
            LoginCTRL loginctrl = new LoginCTRL();
            foreach (Login l in loginctrl.getAllLogins())
            {
                if (l.UserName == txtUsername.Text)
                {
                    if(l.Password == txtPassword.Text)
                    {
                        User user = userctrl.getUserByID(l.ID);
                        UserSingleton.Instance(user);
                        if (user.IsAdmin && SignInAsAdminBox.Checked)
                        {
                            MessageBox.Show("Login Successful");
                            notFound = false;
                            this.Hide();

                            AdminPg.getInstance();

                        }else if (!user.IsAdmin && SignInAsAdminBox.Checked)
                        {
                            MessageBox.Show("User is Not an Admin");
                            notFound = false;
                            this.Hide();

                            ShoppingPg shoppingPg = ShoppingPg.getInstance();

                            shoppingPg.Show();
                        }
                        else
                        {
                            //MessageBox.Show(UserSingleton.GetUser().ToString());
                            MessageBox.Show("Login Successful");
                            notFound = false;
                            this.Hide();

                            ShoppingPg shoppingPg = ShoppingPg.getInstance();

                            shoppingPg.Show();
                        }
                    }
                }
            }
            if (notFound)
            {
                MessageBox.Show("Invalid Username or Password.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            this.Hide();

            NewUserRegistrationPg register = new NewUserRegistrationPg();

            register.Show();


        }

        private void SignInRegPg_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SignInRegPg_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
