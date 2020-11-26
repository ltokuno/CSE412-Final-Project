using System;
using System.Windows.Forms;

namespace CSE412_Group17 {
    public partial class AboutUsPg : Form
    {
        protected AboutUsPg()
        {
        }

        private static AboutUsPg instance;
        public static AboutUsPg getInstance() {
            if (instance == null) {
                instance = new AboutUsPg();

            }
            instance.InitializeComponent();
            instance.Show();
            return instance;
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            HomePage.getInstance();

        }

        private void AboutUsPg_Load(object sender, EventArgs e)
        {

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            HomePage.getInstance();

        }

        private void AboutUsPg_Closed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void btnHomePage_Click_1(object sender, EventArgs e)
        {

            this.Hide();

            ShoppingPg.getInstance();

        }
    }
}
