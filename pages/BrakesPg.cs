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

namespace CSE412_Group17
{
    public partial class BrakesPg : Form
    {
        BindingList<Item> itemsList = new BindingList<Item>();
        BindingList<LineItem> cartItems = new BindingList<LineItem>();

        public BrakesPg()
        {
            InitializeComponent();
        }

        private void btnParts_Click(object sender, EventArgs e)
        {

            this.Hide();

            BrakesPg brakes = new BrakesPg();

            brakes.Show();

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

        private void btnAboutUs_Click(object sender, EventArgs e)
        {

            this.Hide();

            AboutUsPg about = new AboutUsPg();

            about.Show();

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            // hide cart buttons now that item is added
            lblQty.Visible = false;
            quantityUpDn.Visible = false;
            btnAddToCart.Visible = false;

            LineItem line = new LineItem();
            Item curItem = (Item)listBox1.SelectedItem;

            line.ItemID = curItem.ItemID;
            line.ItemName = curItem.ItemName;
            line.quantity = (int)quantityUpDn.Value;
            line.RetailPrice = curItem.RetailPrice;
            line.StockQuantity = curItem.StockQuantity;

            cartItems.Add(line);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ItemsCTRL items = new ItemsCTRL();

            itemsList.Clear();
            
            foreach(Item i in items.geItemsByCategory(comboBox1.Text)) {
                itemsList.Add(i);
            }
        }

        private void BrakesPg_Load(object sender, EventArgs e) {
            ItemsCTRL items = new ItemsCTRL();
            foreach (String s in items.getItemCategories()) {
                comboBox1.Items.Add(s);
            }

            listBox1.DataSource = itemsList;
            ShoppingCart.DataSource = cartItems;
            cartItems.ListChanged += new ListChangedEventHandler(list_ListChanged);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // show add to cart and quantity to add
            lblQty.Visible = true;
            quantityUpDn.Visible = true;
            btnAddToCart.Visible = true;

        }


        private decimal totalCartPrice() {
            decimal output = 0;

            LineItem tmp;

            foreach (Object i in ShoppingCart.Items) {
                tmp = (LineItem)i;

                output += (tmp.RetailPrice * tmp.quantity);

            }
            
            return output;
        }

        private void btnDeletItem_Click(object sender, EventArgs e) {
            if(ShoppingCart.SelectedIndex > -1) {
                ShoppingCart.Items.RemoveAt(ShoppingCart.SelectedIndex);
            } 
        }

        //Change Qty in shopping cart
        private void button2_Click(object sender, EventArgs e) {
            if (ShoppingCart.SelectedIndex > - 1) {

                int newQty;

                if(int.TryParse(Interaction.InputBox("Enter a Quantity", "Quantity"), out newQty)) {
                    ((LineItem)ShoppingCart.SelectedItem).quantity = newQty;
                }


                
            }
        }


        //todo: update the ui controls here
        void list_ListChanged(object sender, ListChangedEventArgs e) {

            lblTotal.Text = totalCartPrice().ToString();

            System.Console.WriteLine("You are here");

            //switch (e.ListChangedType) {
            //    case ListChangedType.ItemAdded:
            //        break;
            //    case ListChangedType.ItemChanged:
            //        break;
            //    case ListChangedType.ItemDeleted:
            //        break;
            //}
        }
    } //end class
}
