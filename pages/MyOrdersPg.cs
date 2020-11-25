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
    public partial class MyOrdersPg : Form
    {
        private MyOrdersPg()
        {
            InitializeComponent();
        }

        private static MyOrdersPg curPage = null;

        public static MyOrdersPg getInstance() {
            if (curPage == null) {
                curPage = new MyOrdersPg();
                curPage.InitializeComponent();
            }
            curPage.Show();
            return curPage;
        }

        private void btnParts_Click(object sender, EventArgs e)
        {


            this.Hide();

            ShoppingPg shoppingPg = ShoppingPg.getInstance();

            shoppingPg.Show();

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

            HomePage.getInstance();

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

            this.Hide();

            AboutUsPg.getInstance().Show();

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

            MyCartPg.getInstance();

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

            MyProfilePg.getInstance();

        }

        private void MyOrdersPg_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
