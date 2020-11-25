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
    public partial class ShoppingPg : Form
    {
        private BindingList<Item> itemsListDS = new BindingList<Item>();
        private BindingList<LineItem> cartItemsDS = new BindingList<LineItem>();
        private BindingList<Order> myOrdersDS = new BindingList<Order>();
        private BindingList<LineItem> myOrdersItemsDS = new BindingList<LineItem>();

        private enum PanelsEnum {
            MyOrders, Profile, Admin, Shopping, Checkout, Account, Resources
        }
        private void ShowPanel(PanelsEnum thePanel) {
            List<Panel> thePanels = new List<Panel>();
            //thePanels.Add(panelParts);
            //thePanels.Add(panelAccount);
            //thePanels.Add(panelResources);
            thePanels.Add(MyOrdersPanel);
            thePanels.Add(orderPanel);
            thePanels.Add(shoppingPanel);

            foreach(Panel p in thePanels) {
                p.Visible = false;
            }

            switch (thePanel) {
                case PanelsEnum.Admin:
                    break;
                case PanelsEnum.Checkout:
                    orderPanel.Visible = true;
                    break;
                case PanelsEnum.MyOrders:
                    MyOrdersPanel.Visible = true;
                    break;
                case PanelsEnum.Shopping:
                    shoppingPanel.Visible = true;
                    break;
                case PanelsEnum.Profile:
                    break;
                case PanelsEnum.Account:
                    panelAccount.Visible = true;
                    break;
                case PanelsEnum.Resources:
                    panelResources.Visible = true;
                    break;
            }
        }

       

        private ShoppingPg()
        {
            InitializeComponent();
        }

        private static ShoppingPg curPage = null;

        public static ShoppingPg getInstance() {
            if (curPage == null) {
                curPage = new ShoppingPg();
            }
            return curPage;
        }



        private void btnParts_Click(object sender, EventArgs e)
        {
            ShowPanel(PanelsEnum.Shopping);
            /*this.Hide();

            ShoppingPg brakes = new ShoppingPg();

            brakes.Show();*/

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

            ShoppingPg brakes = new ShoppingPg();

            brakes.Show();

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

            cartItemsDS.Add(line);

        }

        private void btnSignInRegister_Click(object sender, EventArgs e)
        {

            this.Hide();
            UserSingleton.LogOutUser();
            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {

            this.Hide();

            MyProfilePg profilePg = new MyProfilePg();

            profilePg.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ItemsCTRL items = new ItemsCTRL();

            itemsListDS.Clear();
            
            foreach(Item i in items.geItemsByCategory(comboBox1.Text)) {
                itemsListDS.Add(i);
            }
        }

        private void BrakesPg_Load(object sender, EventArgs e) {
            ItemsCTRL items = new ItemsCTRL();
            foreach (String s in items.getItemCategories()) {
                comboBox1.Items.Add(s);
            }

            listBox1.DataSource = itemsListDS;
            ShoppingCart.DataSource = cartItemsDS;
            cartItemsDS.ListChanged += new ListChangedEventHandler(list_ListChanged);
            MyOrdersListbox.DataSource = myOrdersDS;
            MyItemsListbox.DataSource = myOrdersItemsDS;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // show add to cart and quantity to add
            lblQty.Visible = true;
            quantityUpDn.Visible = true;
            btnAddToCart.Visible = true;

        }

        private decimal totalPrice(BindingList<LineItem> theList) {
            decimal output = 0;

            LineItem tmp;

            foreach (Object i in theList) {
                tmp = (LineItem)i;

                output += (tmp.RetailPrice * tmp.quantity);

            }
            
            return output;
        }

        private void btnDeletItem_Click(object sender, EventArgs e) {
            if(ShoppingCart.SelectedIndex > -1) {
                cartItemsDS.RemoveAt(ShoppingCart.SelectedIndex);
            } 
        }

        //Change Qty in shopping cart
        private void button2_Click(object sender, EventArgs e) {
            if (ShoppingCart.SelectedIndex > - 1) {
                
                int newQty;

                if(int.TryParse(Interaction.InputBox("Enter a Quantity", "Quantity"), out newQty)) {

                    if (newQty > 0) {
                        ((LineItem)ShoppingCart.SelectedItem).quantity = newQty;

                        ShoppingCart.DataSource = null;
                        ShoppingCart.DataSource = cartItemsDS;
                        ListChangedEventArgs args = new ListChangedEventArgs(
                            ListChangedType.ItemChanged, ShoppingCart.SelectedIndex);
                        list_ListChanged(bntChangeQty, args);
                    } else {
                        cartItemsDS.RemoveAt(ShoppingCart.SelectedIndex);
                    }
                }

                
            }
        }

        void list_ListChanged(object sender, ListChangedEventArgs e) {
            lblTotal.Text = totalPrice(cartItemsDS).ToString();
        }

        private void btnCartClear_Click(object sender, EventArgs e) {
            cartItemsDS.Clear();
        }

        private void btnCheckout_Click(object sender, EventArgs e) {

            if (cartItemsDS.Count > 0) {
                //swap out the panels
                ShowPanel(PanelsEnum.Checkout);

                //save the order
                OrderCTRL orderCTRL = new OrderCTRL();

                Order newOrder = new Order();
                newOrder.ConfirmationNumber = orderCTRL.generateConfirmationNumber();
                newOrder.OrderDateTime = DateAndTime.Today.Date.ToShortDateString();
                newOrder.TotalPrice = totalPrice(cartItemsDS);
                newOrder.UserID = (UserSingleton.GetUser()).ID;

                int orderId = orderCTRL.saveOrder(newOrder);

                //save the items in the order

                List<ItemList> newItems = new List<ItemList>();

                foreach(LineItem line in cartItemsDS) {
                    ItemList newIL = new ItemList();
                    newIL.ItemID = line.ItemID;
                    newIL.OrderID = orderId;
                    newIL.Quantity = line.quantity;
                    newItems.Add(newIL);
                }

                orderCTRL.saveItemList(newItems);

                OrderConfListBox.DataSource = cartItemsDS;
                lblOrderID.Text = orderId.ToString();
                lblConfNumber.Text = newOrder.ConfirmationNumber;

            }
        }

        private void btnOrderDone_Click(object sender, EventArgs e) {
            //swap out the panels
            ShowPanel(PanelsEnum.Shopping);
        }

        private void btnMyOrders_Click(object sender, EventArgs e) {
            //this.Hide();

            //MyOrdersPg orders = new MyOrdersPg();

            //orders.Show();

            if (panelAccount.Height == 165) {
                panelAccount.Height = 52;
            } else {
                panelAccount.Height = 165;
            }
            ShowPanel(PanelsEnum.MyOrders);

            //fill out the controls
            myOrdersDS.Clear();
            OrderCTRL orderCTRL = new OrderCTRL();
            foreach(Order o in orderCTRL.getOrdersByUser((UserSingleton.GetUser()).ID)) {
                myOrdersDS.Add(o);
            }

        }

        private void MyOrdersListbox_SelectedIndexChanged(object sender, EventArgs e) {

            clearMyOderItems();

            if (MyOrdersListbox.SelectedItem != null) {
                OrderCTRL orderCTRL = new OrderCTRL();
                Order curOrder = (Order)MyOrdersListbox.SelectedItem;

                List<ItemList> itemLists = orderCTRL.getOrderLineItems(curOrder.OrderID);
                List<Item> items = orderCTRL.getOrderItems(curOrder.OrderID);

                foreach (ItemList il in itemLists) {
                    LineItem tmp = new LineItem();
                    tmp.ItemID = il.ItemID;
                    tmp.quantity = il.Quantity;
                    tmp.ItemName = items.Find(item => item.ItemID == il.ItemID).ItemName;
                    tmp.RetailPrice = items.Find(item => item.ItemID == il.ItemID).RetailPrice;
                    tmp.Category = items.Find(item => item.ItemID == il.ItemID).Category;
                    myOrdersItemsDS.Add(tmp);
                }

                lblMyTotal.Text = totalPrice(myOrdersItemsDS).ToString();
                lblMyOrderID.Text = itemLists[0].OrderID.ToString();
                lblMyConfNum.Text = curOrder.ConfirmationNumber;
            }
        }

        private void clearMyOderItems() {
            myOrdersItemsDS.Clear();
            lblMyTotal.Text = "";
            lblMyOrderID.Text = "";
            lblMyConfNum.Text = "";
        }

    } //end class
}
