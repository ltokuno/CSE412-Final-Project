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
    public partial class AdminPg : Form
    {
        // used for comparing login info to existing account
        public static string username = null;
        public static string password = null;

        // used for comparing NEW users to see if account already exists
        public static string new_username = null;
        public static string new_password = null;

        public AdminPg()
        {
            InitializeComponent();
        }

        private void AdminPg_Load(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }
    }
}
