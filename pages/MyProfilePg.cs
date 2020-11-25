using CSE412_Group17.controllers;
using CSE412_Group17.pages;
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
using Microsoft.VisualBasic;

namespace CSE412_Group17
{
    public partial class MyProfilePg : Form
    {
        User user;

        public MyProfilePg()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            ShoppingPg shoppingPg = ShoppingPg.getInstance();

            shoppingPg.Show();

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            ShoppingPg shoppingPg = ShoppingPg.getInstance();

            shoppingPg.Show();

        }

        private void MyProfilePg_Load(object sender, EventArgs e)
        {
            user = UserSingleton.GetUser();
            lblProfileHeader.Text = user.FirstName + "'s Profile";
            FirstNameLabel.Text = user.FirstName;
            LastNameLabel.Text = user.LastName;
            EmailLabel.Text = user.Email;
            PhoneNumberLabel.Text = user.PhoneNumber;
            DateOfBirthLabel.Text = user.DateOfBirth.ToString();
            GenderLabel.Text = user.Gender;
            AddressLabel.Text = user.Address;
            if (!user.IsAdmin)
            {
                AdministratorLabel.Visible = false;
            }
            EmailBox.Visible = false;
            AddressBox.Visible = false;
            PhoneNumberBox.Visible = false;
            SaveButton.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PhoneNumberBox.Text))
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
            user.Email = EmailBox.Text;
            user.Address = AddressBox.Text;
            user.PhoneNumber = PhoneNumberBox.Text;
            UserCTRL userctrl = new UserCTRL();
            userctrl.changeUser(user);
            MessageBox.Show("USER INFO UPDATED");
            this.Hide();

            HomePage home = new HomePage();

            home.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            EmailBox.Visible = true;
            AddressBox.Visible = true;
            PhoneNumberBox.Visible = true;
            EmailBox.Text = user.Email;
            AddressBox.Text = user.Address;
            PhoneNumberBox.Text = user.PhoneNumber;
            UpdateButton.Visible = false;
            SaveButton.Visible = true;
        }
    }
}
