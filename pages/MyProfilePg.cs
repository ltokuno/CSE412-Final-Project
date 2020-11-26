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

        protected MyProfilePg()
        {

        }
        
        private static MyProfilePg instance;

        public static MyProfilePg getInstance() {
            if (instance == null) {
                instance = new MyProfilePg();
                instance.InitializeComponent();
                
            }
            instance.Initialize();
            instance.Show();
            return instance;
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            HomePage.getInstance();

        }

        private void MyProfilePg_Load(object sender, EventArgs e)
        {
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
            Initialize();
            MessageBox.Show("USER INFO UPDATED");
            this.Hide();

            HomePage.getInstance();

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

        private void MyProfilePg_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Initialize()
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
            UpdateButton.Visible = true;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage.getInstance();
        }
    }
}
