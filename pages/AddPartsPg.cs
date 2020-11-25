using System;
using System.Windows.Forms;
using CSE412_Group17.controllers;
using CSE412_Group17.models;

namespace CSE412_Group17 {
    public partial class AddPartsPg : Form
    {
        private AddPartsPg()
        {
            InitializeComponent();
        }

        private static AddPartsPg curPage = null;

        public static AddPartsPg getInstance() {
            if (curPage == null) {
                curPage = new AddPartsPg();
                curPage.InitializeComponent();

            }
            curPage.Show();
            return curPage;
        }


        private void AdminPg_Load(object sender, EventArgs e)
        {
            VendorCTRL vendorctrl = new VendorCTRL();
            foreach(Vendor v in vendorctrl.getAllVendors())
            {
                VendorSelectBox.Items.Add(v);
            }
            ItemsCTRL itemctrl = new ItemsCTRL();
            foreach(String category in itemctrl.getItemCategories())
            {
                CategorySelectBox.Items.Add(category);
                EditCategoryBox.Items.Add(category);
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSingleton.LogOutUser();
            this.Hide();

            SignInRegPg signIn = new SignInRegPg();

            signIn.Show();

        }

        private void btnBackToAdminPg_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            AdminPg.getInstance();

        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            ItemsCTRL itemctrl = new ItemsCTRL();
            Vendor vendor = (Vendor)VendorSelectBox.SelectedItem;
            if (String.IsNullOrEmpty(txtItemNameBox.Text))
            {
                MessageBox.Show("Please Enter Part Name");
                return;
            }
            else if (String.IsNullOrEmpty(txtCostPriceBox.Text))
            {
                MessageBox.Show("Please Enter Cost");
                return;
            }
            else if (String.IsNullOrEmpty(txtRetailPriceBox.Text))
            {
                MessageBox.Show("Please Enter Retail Price");
                return;
            }
            else if (String.IsNullOrEmpty(txtStockQuantityBox.Text))
            {
                MessageBox.Show("Please Enter Stock Quantity");
                return;
            }
            Item item = new Item();
            item.Category = (String)CategorySelectBox.SelectedItem;
            item.CostPrice = Convert.ToDecimal(txtCostPriceBox.Text);
            item.RetailPrice = Convert.ToDecimal(txtRetailPriceBox.Text);
            item.StockQuantity = Convert.ToInt32(txtStockQuantityBox.Text);
            item.ItemName = txtItemNameBox.Text;
            itemctrl.addItem(item, vendor);
            MessageBox.Show("ITEM ADDED TO INVENTORY");
            CategorySelectBox.ResetText();
            VendorSelectBox.ResetText();
            txtCostPriceBox.Clear();
            txtRetailPriceBox.Clear();
            txtStockQuantityBox.Clear();
            txtItemNameBox.Clear();
        }

        private void btnGetAllParts_Click(object sender, EventArgs e)
        {
            string category;
            ItemsCTRL itemctrl = new ItemsCTRL();
            if (EditCategoryBox.SelectedIndex > -1)
            {
                category = EditCategoryBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("SELECT CATEGORY"); 
                return;
            }
            
            foreach(Item item in itemctrl.geItemsByCategory(category))
            {
                PartsBox.Items.Add(item);
            }
        }

        private void btnSaveEditedPart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEditItemNameBox.Text))
            {
                MessageBox.Show("Please Enter Part Name");
                return;
            }
            else if (String.IsNullOrEmpty(txtEditCostPriceBox.Text))
            {
                MessageBox.Show("Please Enter Cost");
                return;
            }
            else if (String.IsNullOrEmpty(txtEditRetailPriceBox.Text))
            {
                MessageBox.Show("Please Enter Retail Price");
                return;
            }
            else if (String.IsNullOrEmpty(txtEditStockQuantityBox.Text))
            {
                MessageBox.Show("Please Enter Stock Quantity");
                return;
            }
            Item item = (Item)PartsBox.SelectedItem;
            item.ItemName = txtItemNameBox.Text;
            item.CostPrice = Convert.ToDecimal(txtEditCostPriceBox.Text);
            item.RetailPrice = Convert.ToDecimal(txtEditRetailPriceBox.Text);
            item.StockQuantity = Convert.ToInt32(txtEditStockQuantityBox.Text);
        }

        private void btnEditSelectedPart_Click(object sender, EventArgs e)
        {
            Item item = (Item)PartsBox.SelectedItem;
            txtEditItemNameBox.Text = item.ItemName;
            txtEditRetailPriceBox.Text = item.RetailPrice.ToString();
            txtEditStockQuantityBox.Text = item.StockQuantity.ToString();
            txtEditCostPriceBox.Text = item.StockQuantity.ToString();
        }

        private void SaveVendorButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(VendorNameBox.Text))
            {
                MessageBox.Show("Please Enter Vendor Name");
                return;
            }
            else if (String.IsNullOrEmpty(VendorAddressBox.Text))
            {
                MessageBox.Show("Please Enter Vendor Address");
                return;
            }
            Vendor vendor = new Vendor();
            vendor.VendorName = VendorNameBox.Text;
            vendor.VendorAddress = VendorAddressBox.Text;
            VendorCTRL vendorctrl = new VendorCTRL();
            vendorctrl.addVendor(vendor);
            MessageBox.Show("NEW VENDOR ADDED");
            VendorNameBox.Clear();
            VendorAddressBox.Clear();
        }

        private void AddPartsPg_Closed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
