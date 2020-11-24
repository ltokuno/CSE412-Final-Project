﻿using CSE412_Group17.controllers;
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
    public partial class MyProfilePg : Form
    {
        User user;

        public MyProfilePg()
        {
            InitializeComponent();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {


            this.Hide();

            BrakesPg brakes = new BrakesPg();

            brakes.Show();

        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {

            if (panelAccount.Height == 165)
            {

                panelAccount.Height = 52;

            }
            else
            {

                panelAccount.Height = 165;

            }
        }

        private void btnResources_Click(object sender, EventArgs e)
        {

            if (panelResources.Height == 89)
            {

                panelResources.Height = 52;

            }
            else
            {

                panelResources.Height = 89;

            }
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            HomePage home = new HomePage();

            home.Show();

        }

        private void btnBrakes_Click(object sender, EventArgs e) // go to Brakes page
        {

            this.Hide();

            BrakesPg brakes = new BrakesPg();

            brakes.Show();

        }

        private void btnChains_Click(object sender, EventArgs e)
        {

            this.Hide();

            ChainsPg chains = new ChainsPg();

            chains.Show();

        }

        private void btnForks_Click(object sender, EventArgs e)
        {

            this.Hide();

            ForksPg forks = new ForksPg();

            forks.Show();

        }

        private void btnHandlebars_Click(object sender, EventArgs e)
        {

            this.Hide();

            HandleBarsPg handlebars = new HandleBarsPg();

            handlebars.Show();

        }

        private void btnPedals_Click(object sender, EventArgs e)
        {

            this.Hide();

            PedalsPg pedals = new PedalsPg();

            pedals.Show();

        }

        private void btnWheels_Click(object sender, EventArgs e)
        {

            this.Hide();

            WheelsPg wheels = new WheelsPg();

            wheels.Show();

        }

        private void btnTiresTubes_Click(object sender, EventArgs e)
        {

            this.Hide();

            TireTubesPg tiretubes = new TireTubesPg();

            tiretubes.Show();

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

            this.Hide();

            AboutUsPg about = new AboutUsPg();

            about.Show();

        }

        private void btnSignInRegister_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void btnMyCart_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyCartPg cart = new MyCartPg();

            cart.Show();

        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyOrdersPg orders = new MyOrdersPg();

            orders.Show();

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyProfilePg profilePg = new MyProfilePg();

            profilePg.Show();

        }

        private void MyProfilePg_Load(object sender, EventArgs e)
        {
            user = UserSingleton.GetUser();
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
