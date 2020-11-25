using System;
using System.Windows.Forms;

namespace CSE412_Group17 {
    public partial class AboutUsPg : Form
    {

        private static AboutUsPg curPage;

        private AboutUsPg()
        {
            InitializeComponent();
        }

        public static AboutUsPg getInstance() {
            if (curPage == null) {
                curPage = new AboutUsPg();
                curPage.InitializeComponent();
                curPage.Show();
            }
            return curPage;
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
