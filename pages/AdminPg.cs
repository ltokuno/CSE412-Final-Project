using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSE412_Group17.controllers;
using CSE412_Group17.models;

namespace CSE412_Group17
{
    public partial class AdminBox : Form
    {
        // used for comparing login info to existing account
        public static string username = null;
        public static string password = null;

        // used for comparing NEW users to see if account already exists
        public static string new_username = null;
        public static string new_password = null;

        public AdminBox()
        {
            InitializeComponent();
        }

        private void AdminPg_Load(object sender, EventArgs e)
        {
                
        }
    

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSingleton.LogOutUser();
            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GetAllUsersButton_Click(object sender, EventArgs e)
        {
            UsersBox.Items.Clear();
            UserCTRL users = new UserCTRL();
            foreach (User u in users.getAllUsers())
            {
                UsersBox.Items.Add(u);
            }
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.FirstName = FirstNameBox.Text;
            user.LastName = LastNameBox.Text;
            user.PhoneNumber = PhoneNumberBox.Text;
            user.Address = AddressBox.Text;
            user.Email = EmailBox.Text;
            user.DateOfBirth = DateTime.Now;
            if (MaleButton.Checked)
            {
                user.Gender = "male";
            } else
                user.Gender = "female";
            user.IsAdmin = AdminCheckBox.Checked;
            LoginCTRL loginctrl = new LoginCTRL();
            user.ID = loginctrl.saveLoginInfo(UsernameBox.Text, PasswordBox.Text);
            UserCTRL userctrl = new UserCTRL();
            userctrl.addUser(user, user.ID);
            MessageBox.Show("NEW USER ADDED");
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            PhoneNumberBox.Text = "";
            AddressBox.Text = "";
            EmailBox.Text = "";
            MaleButton.Checked = false;
            UsernameBox.Text = "";
            PasswordBox.Text = "";
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)UsersBox.SelectedItem;
            EditFirstNameBox.Text = selectedUser.FirstName;
            EditLastNameBox.Text = selectedUser.LastName;
            EditAddressBox.Text = selectedUser.Address;
            EditEmailBox.Text = selectedUser.Email;
            EditPhoneNumberBox.Text = selectedUser.PhoneNumber;
            EditAdminBox.Checked = selectedUser.IsAdmin;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EditSaveChangesButton_Click(object sender, EventArgs e)
        {
            User selectedUser = (User)UsersBox.SelectedItem;
            selectedUser.FirstName = EditFirstNameBox.Text;
            selectedUser.LastName = EditLastNameBox.Text;
            selectedUser.Address = EditAddressBox.Text;
            selectedUser.Email = EditEmailBox.Text;
            selectedUser.PhoneNumber = EditPhoneNumberBox.Text;
            selectedUser.IsAdmin = EditAdminBox.Checked;
            UserCTRL userctrl = new UserCTRL();
            userctrl.changeUser(selectedUser);
            MessageBox.Show("USER INFO UPDATED");
            EditFirstNameBox.Text = "";
            EditLastNameBox.Text = "";
            EditAddressBox.Text = "";
            EditEmailBox.Text = "";
            EditPhoneNumberBox.Text = "";
            EditAdminBox.Checked = false;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void GetLoginCredentialsButton_Click(object sender, EventArgs e)
        {
            LoginCTRL loginctrl = new LoginCTRL();
            foreach (Login l in loginctrl.getAllLogins())
            {
                LoginBox.Items.Add(l);
            }
        }

        private void EditSelectedCredentialButton_Click(object sender, EventArgs e)
        {
            Login selectedLogin = (Login)LoginBox.SelectedItem;
            EditUsernameBox.Text = selectedLogin.UserName;
            EditPasswordBox.Text = selectedLogin.Password;
            EditPasswordBox2.Text = selectedLogin.Password;
        }

        private void EditCredentialsSaveButton_Click(object sender, EventArgs e)
        {
            if (EditPasswordBox.Text == EditPasswordBox2.Text)
            {
                Login selectedLogin = (Login)LoginBox.SelectedItem;
                UpdateCredentials(selectedLogin);
            }
            else
            {
                MessageBox.Show("PASSWORDS MUST MATCH");
            }
        }

        private void UpdateCredentials(Login selectedLogin)
        {
            selectedLogin.UserName = EditUsernameBox.Text;
            selectedLogin.Password = EditPasswordBox.Text;
            LoginCTRL loginctrl = new LoginCTRL();
            loginctrl.changeLogin(selectedLogin);
            MessageBox.Show("CREDENTIALS UPDATED");
            EditUsernameBox.Text = "";
            EditPasswordBox.Text = "";
            EditPasswordBox2.Text = "";
            LoginBox.Items.Clear();
        }
    }
}
