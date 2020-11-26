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
    public partial class MyOrdersPg : Form
    {
        protected MyOrdersPg()
        {

        }

        private static MyOrdersPg instance;

        public static MyOrdersPg getInstance() {
            if (instance == null) {
                instance = new MyOrdersPg();
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

            HomePage.getInstance();

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

            this.Hide();

            getInstance();

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyProfilePg.getInstance();

        }

        private void MyOrdersPg_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void MyOrdersPg_Load(object sender, EventArgs e)
        {

        }
    }
}
