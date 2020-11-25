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
    public partial class AboutUsPg : Form
    {

        public AboutUsPg()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            ShoppingPg brakes = new ShoppingPg();

            brakes.Show();

        }

        private void AboutUsPg_Load(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            ShoppingPg brakes = new ShoppingPg();

            brakes.Show();

        }
    }
}
