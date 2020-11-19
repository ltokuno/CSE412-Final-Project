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
    public partial class SignInRegPg : Form
    {
        // used for comparing login info to existing account
        public static string username = null;
        public static string password = null;

        // used for comparing NEW users to see if account already exists
        public static string new_username = null;
        public static string new_password = null;

        public SignInRegPg()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // get user input to compare
            username = txtUsername.Text;
            password = txtPassword.Text;

            // compare
            if(username == "test" && password == "123")
            {

                this.Hide();

                HomePage home = new HomePage();

                home.Show();

            }
            else
            {

                MessageBox.Show("Invalid Username or Password.");

            }

            //reset fields
            txtUsername.Text = null;
            txtPassword.Text = null;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // get user input to compare
            new_username = txtNewUser.Text;
            new_password = txtNewPassword.Text;

            // compare
            if (new_username != "test")
            {

                MessageBox.Show("Register Successful.");

            }
            else
            {

                MessageBox.Show("Username Already Taken.");

            }

            //reset fields
            txtNewUser.Text = null;
            txtNewPassword.Text = null;
        }

        private void btnSignInRegister_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void SignInRegPg_Load(object sender, EventArgs e)
        {

        }
    }
}
