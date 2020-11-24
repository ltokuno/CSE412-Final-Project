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
    public partial class AddPartsPg : Form
    {
        public AddPartsPg()
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

        private void GetAllUsersButton_Click(object sender, EventArgs e)
        {
            //UsersBox.Items.Clear();
            //UserCTRL users = new UserCTRL();
            //foreach (User u in users.getAllUsers())
            //{
            //    UsersBox.Items.Add(u);
            //}
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(FirstNameBox.Text))
            //{
            //    MessageBox.Show("Please Enter First Name");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(LastNameBox.Text))
            //{
            //    MessageBox.Show("Please Enter Last Name");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(PhoneNumberBox.Text))
            //{
            //    MessageBox.Show("Please Enter Phone Number");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(AddressBox.Text))
            //{
            //    MessageBox.Show("Please Enter Address");
            //    return;
            //}
            //if (String.IsNullOrEmpty(EmailBox.Text))
            //{
            //    MessageBox.Show("Please Enter Email");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(UsernameBox.Text))
            //{
            //    MessageBox.Show("Please Enter Username");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(PasswordBox.Text))
            //{
            //    MessageBox.Show("Please Enter Password");
            //}
            //LoginCTRL loginctrl = new LoginCTRL();
            //foreach (Login l in loginctrl.getAllLogins())
            //{
            //    if (l.UserName == UsernameBox.Text)
            //    {
            //        MessageBox.Show("Username Already Exists");
            //        return;
            //    }
            //}
            //User user = new User();

            //user.FirstName = FirstNameBox.Text;
            //user.LastName = LastNameBox.Text;
            //user.PhoneNumber = PhoneNumberBox.Text;
            //user.Address = AddressBox.Text;
            //user.Email = EmailBox.Text;
            //DateTime dateValue;
            //if (DateTime.TryParse(DOBBox.Text, out dateValue))
            //{
            //    user.DateOfBirth = dateValue;
            //}
            //else
            //{
            //    MessageBox.Show("DATE OF BIRTH MUST BE OF TYPE MM/DD/YYYY");
            //    return;
            //}
            //if (MaleButton.Checked)
            //{
            //    user.Gender = "male";
            //}
            //else
            //    user.Gender = "female";
            //user.IsAdmin = AdminCheckBox.Checked;

            //user.ID = loginctrl.saveLoginInfo(UsernameBox.Text, PasswordBox.Text);
            //UserCTRL userctrl = new UserCTRL();
            //userctrl.addUser(user, user.ID);
            //MessageBox.Show("NEW USER ADDED");
            //FirstNameBox.Text = "";
            //LastNameBox.Text = "";
            //PhoneNumberBox.Text = "";
            //AddressBox.Text = "";
            //EmailBox.Text = "";
            //AdminCheckBox.Checked = false;
            //UsernameBox.Text = "";
            //PasswordBox.Text = "";
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            //User selectedUser = (User)UsersBox.SelectedItem;
            //txtEditItemNameBox.Text = selectedUser.FirstName;
            //txtEditCategoryBox.Text = selectedUser.LastName;
            //txtEditRetailPriceBox.Text = selectedUser.Address;
            //txtEditStockQuantityBox.Text = selectedUser.Email;
            //txtEditCostPriceBox.Text = selectedUser.PhoneNumber;
            //EditAdminBox.Checked = selectedUser.IsAdmin;
        }

        private void EditSaveChangesButton_Click(object sender, EventArgs e)
        {
            //User selectedUser = (User)UsersBox.SelectedItem;
            //selectedUser.FirstName = txtEditItemNameBox.Text;
            //selectedUser.LastName = txtEditCategoryBox.Text;
            //selectedUser.Address = txtEditRetailPriceBox.Text;
            //selectedUser.Email = txtEditStockQuantityBox.Text;
            //selectedUser.PhoneNumber = txtEditCostPriceBox.Text;
            //selectedUser.IsAdmin = EditAdminBox.Checked;
            //UserCTRL userctrl = new UserCTRL();
            //userctrl.changeUser(selectedUser);
            //MessageBox.Show("USER INFO UPDATED");
            //txtEditItemNameBox.Text = "";
            //txtEditCategoryBox.Text = "";
            //txtEditRetailPriceBox.Text = "";
            //txtEditStockQuantityBox.Text = "";
            //txtEditCostPriceBox.Text = "";
            //EditAdminBox.Checked = false;
        }

        private void GetLoginCredentialsButton_Click(object sender, EventArgs e)
        {
            //LoginCTRL loginctrl = new LoginCTRL();
            //foreach (Login l in loginctrl.getAllLogins())
            //{
            //    LoginBox.Items.Add(l);
            //}
        }

        private void EditSelectedCredentialButton_Click(object sender, EventArgs e)
        {
            //Login selectedLogin = (Login)LoginBox.SelectedItem;
            //EditUsernameBox.Text = selectedLogin.UserName;
            //EditPasswordBox.Text = selectedLogin.Password;
            //EditPasswordBox2.Text = selectedLogin.Password;
        }

        private void EditCredentialsSaveButton_Click(object sender, EventArgs e)
        {
            //if (EditPasswordBox.Text == EditPasswordBox2.Text)
            //{
            //    Login selectedLogin = (Login)LoginBox.SelectedItem;
            //    UpdateCredentials(selectedLogin);
            //}
            //else
            //{
            //    MessageBox.Show("PASSWORDS MUST MATCH");
            //}
        }

        private void UpdateCredentials(Login selectedLogin)
        {
            //selectedLogin.UserName = EditUsernameBox.Text;
            //selectedLogin.Password = EditPasswordBox.Text;
            //LoginCTRL loginctrl = new LoginCTRL();
            //loginctrl.changeLogin(selectedLogin);
            //MessageBox.Show("CREDENTIALS UPDATED");
            //EditUsernameBox.Text = "";
            //EditPasswordBox.Text = "";
            //EditPasswordBox2.Text = "";
            //LoginBox.Items.Clear();
        }

        private void btnBackToAdminPg_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            AdminBox adminPg = new AdminBox();

            adminPg.Show();

        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
