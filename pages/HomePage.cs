using CSE412_Group17.controllers;
using CSE412_Group17.pages;
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
using CSE412_Group17.models;

namespace CSE412_Group17
{
    public partial class HomePage : Form
    {
        private BindingList<Order> myOrdersDS = new BindingList<Order>();

        private enum PanelsEnum
        {
            MyOrders
        }

        protected HomePage()
        {

        }

        private static HomePage instance;

        public static HomePage getInstance() {
            if (instance == null) {
                instance = new HomePage();
                instance.InitializeComponent();
            }
            instance.Initialize();
            instance.Show();
            return instance;
        }

        private void Initialize()
        {
            panelAccount.Height = 52;
            panelResources.Height = 52;

        }

        private void btnParts_Click(object sender, EventArgs e)
        {

            this.Hide();

            ShoppingPg.getInstance();

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

            getInstance();

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

            this.Hide();

            AboutUsPg.getInstance();

        }

        private void btnSignInRegister_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignInRegPg.GetInstance();

        }

        private void btnMyCart_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyCartPg.getInstance();

        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {

            lblHomeMessage1.Visible = false;
            lblBrakesMessage1.Visible = true;
            lblBrakesMessage2.Visible = true;

            if (panelAccount.Height == 165)
            {
                panelAccount.Height = 52;
            }
            else
            {
                panelAccount.Height = 165;
            }

            //fill out the controls
            myOrdersDS.Clear();
            OrderCTRL orderCTRL = new OrderCTRL();
            foreach (Order o in orderCTRL.getOrdersByUser((UserSingleton.GetUser()).ID))
            {
                myOrdersDS.Add(o);
            }
            this.Hide();
            ShoppingPg.getInstance();
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyProfilePg.getInstance();

        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
