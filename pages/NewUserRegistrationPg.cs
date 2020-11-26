using CSE412_Group17.controllers;
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
    public partial class NewUserRegistrationPg : Form
    {
        private static NewUserRegistrationPg instance;
        protected NewUserRegistrationPg()
        {
            InitializeComponent();
        }

        public static NewUserRegistrationPg GetInstance()
        {
            if (instance == null)
            {
                instance = new NewUserRegistrationPg();
            }
            instance.Show();
            return instance;
        }

        private void btnBackToLoginPg_Click(object sender, EventArgs e)
        {
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            PhoneNumberBox.Text = "";
            AddressBox.Text = "";
            EmailBox.Text = "";
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            this.Hide();

            SignInRegPg.GetInstance();

        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameBox.Text))
            {
                MessageBox.Show("Please Enter First Name");
                return;
            }
            else if (String.IsNullOrEmpty(LastNameBox.Text))
            {
                MessageBox.Show("Please Enter Last Name");
                return;
            }
            else if (String.IsNullOrEmpty(PhoneNumberBox.Text))
            {
                MessageBox.Show("Please Enter Phone Number");
                return;
            }
            else if (String.IsNullOrEmpty(AddressBox.Text))
            {
                MessageBox.Show("Please Enter Address");
                return;
            }
            if (String.IsNullOrEmpty(EmailBox.Text))
            {
                MessageBox.Show("Please Enter Email");
                return;
            }
            else if (String.IsNullOrEmpty(UsernameBox.Text))
            {
                MessageBox.Show("Please Enter Username");
                return;
            }
            else if (String.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Please Enter Password");
            }
            LoginCTRL loginctrl = new LoginCTRL();
            foreach (Login l in loginctrl.getAllLogins())
            {
                if (l.UserName == UsernameBox.Text)
                {
                    MessageBox.Show("Username Already Exists");
                    return;
                }
            }
            User user = new User();

            user.FirstName = FirstNameBox.Text;
            user.LastName = LastNameBox.Text;
            user.PhoneNumber = PhoneNumberBox.Text;
            user.Address = AddressBox.Text;
            user.Email = EmailBox.Text;
            DateTime dateValue;
            if(DateTime.TryParse(DOBBox.Text, out dateValue))
            {
                user.DateOfBirth = dateValue;
            }
            else
            {
                MessageBox.Show("DATE OF BIRTH MUST BE OF TYPE MM/DD/YYYY");
                return;
            }
            if (MaleButton.Checked)
            {
                user.Gender = "male";
            }
            else
                user.Gender = "female";
            user.IsAdmin = false;
            user.ID = loginctrl.saveLoginInfo(UsernameBox.Text, PasswordBox.Text);
            UserCTRL userctrl = new UserCTRL();
            userctrl.addUser(user, user.ID);
            MessageBox.Show("REGISTRATION COMPLETE, PLEASE LOGIN");
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            PhoneNumberBox.Text = "";
            AddressBox.Text = "";
            EmailBox.Text = "";
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            this.Hide();

            SignInRegPg.GetInstance();
        }

        private void NewUserRegistrationPg_Load(object sender, EventArgs e)
        {

        }

        private void NewUserRegistrationPg_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {

        }
    }
}
