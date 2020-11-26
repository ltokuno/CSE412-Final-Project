using System;
using System.Windows.Forms;
using CSE412_Group17.controllers;
using CSE412_Group17.models;

namespace CSE412_Group17 {
    public partial class AddPartsPg : Form
    {
        protected AddPartsPg()
        {

        }

        private static AddPartsPg instance;

        public static AddPartsPg getInstance() {
            if (instance == null) {
                instance = new AddPartsPg();
                instance.InitializeComponent();
            }
            instance.Initialize();
            instance.Show();
            return instance;
        }


        private void AdminPg_Load(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            UserSingleton.LogOutUser();
            this.Hide();

            SignInRegPg.GetInstance();

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
            PartsBox.Items.Clear();
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
                if (item.StockQuantity > -1)
                {
                    PartsBox.Items.Add(item);
                }
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
            item.ItemName = txtEditItemNameBox.Text;
            item.CostPrice = Convert.ToDecimal(txtEditCostPriceBox.Text);
            item.RetailPrice = Convert.ToDecimal(txtEditRetailPriceBox.Text);
            item.StockQuantity = Convert.ToInt32(txtEditStockQuantityBox.Text);
            ItemsCTRL itemsctrl = new ItemsCTRL();
            itemsctrl.changeItem(item);
            MessageBox.Show("PART SAVED");
            txtEditItemNameBox.Clear();
            txtEditCostPriceBox.Clear();
            txtEditRetailPriceBox.Clear();
            txtEditStockQuantityBox.Clear();
            PartsBox.Items.Clear();
        }

        private void btnEditSelectedPart_Click(object sender, EventArgs e)
        {
            Item item = (Item)PartsBox.SelectedItem;
            txtEditItemNameBox.Text = item.ItemName;
            txtEditRetailPriceBox.Text = item.RetailPrice.ToString();
            txtEditStockQuantityBox.Text = item.StockQuantity.ToString();
            txtEditCostPriceBox.Text = item.CostPrice.ToString();
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
            VendorSelectBox.Items.Clear();
            foreach (Vendor v in vendorctrl.getAllVendors())
            {
                VendorSelectBox.Items.Add(v);
            }
            VendorNameBox.Clear();
            VendorAddressBox.Clear();
        }

        private void Initialize()
        {
            VendorSelectBox.Items.Clear();
            CategorySelectBox.Items.Clear();
            PartsBox.Items.Clear();
            EditCategoryBox.Items.Clear();
            VendorCTRL vendorctrl = new VendorCTRL();
            foreach (Vendor v in vendorctrl.getAllVendors())
            {
                VendorSelectBox.Items.Add(v);
            }
            ItemsCTRL itemctrl = new ItemsCTRL();
            foreach (String category in itemctrl.getItemCategories())
            {
                CategorySelectBox.Items.Add(category);
                EditCategoryBox.Items.Add(category);
            }
        }

        private void AddPartsPg_Closed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (PartsBox.SelectedIndex > -1)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this Part ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Item selectedItem = (Item)PartsBox.SelectedItem;
                    ItemsCTRL itemctrl = new ItemsCTRL();
                    selectedItem.StockQuantity = -1;
                    itemctrl.changeItem(selectedItem);
                    MessageBox.Show("PART HAS BEEN REMOVED");
                }
                else
                {
                    return;
                }
            }
            else
                MessageBox.Show("Please Select a Part to Delete");
            return;
        }
    }
}
