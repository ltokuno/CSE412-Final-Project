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
    public partial class NewUserRegistrationPg : Form
    {
        public static string chainItem = null;
        public static int chainQuantity = 0; // # of items to add to cart

        public NewUserRegistrationPg()
        {
            InitializeComponent();
        }

        private void btnHomePage_Click(object sender, EventArgs e) // go to Home page
        {

            this.Hide();

            NewUserRegistrationPg register = new NewUserRegistrationPg();

            register.Show();

        }


        private void btnBackToLoginPg_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
