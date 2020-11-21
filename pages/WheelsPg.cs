﻿using System;
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
    public partial class WheelsPg : Form
    {
        public static string wheelsItem = null;
        public static int wheelsQuantity = 0; // # of items to add to cart

        public WheelsPg()
        {
            InitializeComponent();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {

            if(panelParts.Height == 313)
            {

                panelParts.Height = 52;

            }
            else
            {

                panelParts.Height = 313;

            }
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

        private void btnBrakes_Click_1(object sender, EventArgs e) // go to Brakes page
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

        private void btnAddToCart_700_Click(object sender, EventArgs e)
        {

            wheelsItem = lbl700Front.Text;
            // show add to cart and quantity to add
            comboBoxQuantity.Visible = true;
            btnAddToCart.Visible = true;

        }

        private void btnAddToCart_650_Click(object sender, EventArgs e)
        {

            wheelsItem = lbl650Front.Text;
            // show add to cart and quantity to add
            comboBoxQuantity.Visible = true;
            btnAddToCart.Visible = true;

        }

        private void btnAddToCart_Clincher4_Click(object sender, EventArgs e)
        {

            wheelsItem = lblClincher4.Text;
            // show add to cart and quantity to add
            comboBoxQuantity.Visible = true;
            btnAddToCart.Visible = true;

        }

        private void btnAddToCart_Clincher5_Click(object sender, EventArgs e)
        {

            wheelsItem = lblClincher5.Text;
            // show add to cart and quantity to add
            comboBoxQuantity.Visible = true;
            btnAddToCart.Visible = true;

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

            this.Hide();

            AboutUsPg about = new AboutUsPg();

            about.Show();

        }

        private void comboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

            wheelsQuantity = Convert.ToInt32(comboBoxQuantity.Text);

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            string msg = String.Format("Quantity of {0} of {1} was added to the cart!", wheelsQuantity, wheelsItem);

            // display success message
            MessageBox.Show(msg);

            // hide cart buttons now that item is added
            comboBoxQuantity.Visible = false;
            btnAddToCart.Visible = false;

            comboBoxQuantity.Text = "Quantity"; // reset value

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
    }
}
