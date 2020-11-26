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

        private static SignInRegPg instance;
        protected SignInRegPg()
        {
        }

        public static SignInRegPg GetInstance()
        {
            if (instance == null)
            {
                instance = new SignInRegPg();
                instance.InitializeComponent();
            }
            instance.Initialize();
            instance.Show();
            return instance;
        }

        private void Initialize()
        {
            UserSingleton.LogOutUser();
            txtUsername.Clear();
            txtPassword.Clear();
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

                            HomePage.getInstance();
                        }
                        else
                        {
                            //MessageBox.Show(UserSingleton.GetUser().ToString());
                            MessageBox.Show("Login Successful");
                            notFound = false;
                            this.Hide();

                            HomePage.getInstance();
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

            NewUserRegistrationPg.GetInstance();


        }

        private void SignInRegPg_Load(object sender, EventArgs e)
        {
            
        }

        private void SignInRegPg_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
