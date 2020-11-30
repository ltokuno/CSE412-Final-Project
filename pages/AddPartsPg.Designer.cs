namespace CSE412_Group17
{
    partial class AddPartsPg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.txtItemNameBox = new System.Windows.Forms.TextBox();
            this.txtRetailPriceBox = new System.Windows.Forms.TextBox();
            this.txtCostPriceBox = new System.Windows.Forms.TextBox();
            this.txtStockQuantityBox = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.LastCostLabel = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBackToAdminPg = new System.Windows.Forms.Button();
            this.btnSaveEditedPart = new System.Windows.Forms.Button();
            this.btnEditSelectedPart = new System.Windows.Forms.Button();
            this.btnGetAllParts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PartsBox = new System.Windows.Forms.ListBox();
            this.lblEditRetailPrice = new System.Windows.Forms.Label();
            this.lblEditCostPrice = new System.Windows.Forms.Label();
            this.lblEditStockQuantity = new System.Windows.Forms.Label();
            this.txtEditItemNameBox = new System.Windows.Forms.TextBox();
            this.txtEditRetailPriceBox = new System.Windows.Forms.TextBox();
            this.txtEditCostPriceBox = new System.Windows.Forms.TextBox();
            this.txtEditStockQuantityBox = new System.Windows.Forms.TextBox();
            this.lblEditItemName = new System.Windows.Forms.Label();
            this.VendorSelectBox = new System.Windows.Forms.ComboBox();
            this.lblVendor = new System.Windows.Forms.Label();
            this.CategorySelectBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditCategoryBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VendorNameBox = new System.Windows.Forms.TextBox();
            this.VendorAddressBox = new System.Windows.Forms.TextBox();
            this.SaveVendorButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 55);
            this.label1.TabIndex = 29;
            this.label1.Text = "Administrator Page";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Gray;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Location = new System.Drawing.Point(935, 44);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(102, 37);
            this.btnSignOut.TabIndex = 30;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // txtItemNameBox
            // 
            this.txtItemNameBox.Location = new System.Drawing.Point(111, 263);
            this.txtItemNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItemNameBox.Name = "txtItemNameBox";
            this.txtItemNameBox.Size = new System.Drawing.Size(98, 20);
            this.txtItemNameBox.TabIndex = 1;
            // 
            // txtRetailPriceBox
            // 
            this.txtRetailPriceBox.Location = new System.Drawing.Point(111, 309);
            this.txtRetailPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRetailPriceBox.Name = "txtRetailPriceBox";
            this.txtRetailPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtRetailPriceBox.TabIndex = 3;
            // 
            // txtCostPriceBox
            // 
            this.txtCostPriceBox.Location = new System.Drawing.Point(111, 333);
            this.txtCostPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostPriceBox.Name = "txtCostPriceBox";
            this.txtCostPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtCostPriceBox.TabIndex = 4;
            // 
            // txtStockQuantityBox
            // 
            this.txtStockQuantityBox.Location = new System.Drawing.Point(317, 263);
            this.txtStockQuantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockQuantityBox.Name = "txtStockQuantityBox";
            this.txtStockQuantityBox.Size = new System.Drawing.Size(76, 20);
            this.txtStockQuantityBox.TabIndex = 5;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(17, 263);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 37;
            this.lblItemName.Text = "Item Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(17, 286);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 38;
            this.lblCategory.Text = "Category";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetailPrice.Location = new System.Drawing.Point(17, 309);
            this.lblRetailPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(61, 13);
            this.lblRetailPrice.TabIndex = 39;
            this.lblRetailPrice.Text = "Retail Price";
            // 
            // LastCostLabel
            // 
            this.LastCostLabel.AutoSize = true;
            this.LastCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastCostLabel.Location = new System.Drawing.Point(17, 333);
            this.LastCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastCostLabel.Name = "LastCostLabel";
            this.LastCostLabel.Size = new System.Drawing.Size(55, 13);
            this.LastCostLabel.TabIndex = 40;
            this.LastCostLabel.Text = "Cost Price";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(222, 263);
            this.lblStockQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(77, 13);
            this.lblStockQuantity.TabIndex = 41;
            this.lblStockQuantity.Text = "Stock Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 219);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Add Bike Part to Inventory";
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(311, 327);
            this.btnSavePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(97, 26);
            this.btnSavePart.TabIndex = 7;
            this.btnSavePart.Text = "Add To Inventory";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(512, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 650);
            this.label8.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(20, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(488, 2);
            this.label7.TabIndex = 84;
            // 
            // btnBackToAdminPg
            // 
            this.btnBackToAdminPg.BackColor = System.Drawing.Color.Gray;
            this.btnBackToAdminPg.FlatAppearance.BorderSize = 0;
            this.btnBackToAdminPg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToAdminPg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToAdminPg.ForeColor = System.Drawing.Color.Transparent;
            this.btnBackToAdminPg.Location = new System.Drawing.Point(20, 44);
            this.btnBackToAdminPg.Name = "btnBackToAdminPg";
            this.btnBackToAdminPg.Size = new System.Drawing.Size(102, 37);
            this.btnBackToAdminPg.TabIndex = 86;
            this.btnBackToAdminPg.Text = "Go Back";
            this.btnBackToAdminPg.UseVisualStyleBackColor = false;
            this.btnBackToAdminPg.Click += new System.EventHandler(this.btnBackToAdminPg_Click);
            // 
            // btnSaveEditedPart
            // 
            this.btnSaveEditedPart.Location = new System.Drawing.Point(939, 631);
            this.btnSaveEditedPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveEditedPart.Name = "btnSaveEditedPart";
            this.btnSaveEditedPart.Size = new System.Drawing.Size(94, 28);
            this.btnSaveEditedPart.TabIndex = 28;
            this.btnSaveEditedPart.Text = "Save Changes";
            this.btnSaveEditedPart.UseVisualStyleBackColor = true;
            this.btnSaveEditedPart.Click += new System.EventHandler(this.btnSaveEditedPart_Click);
            // 
            // btnEditSelectedPart
            // 
            this.btnEditSelectedPart.Location = new System.Drawing.Point(836, 490);
            this.btnEditSelectedPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditSelectedPart.Name = "btnEditSelectedPart";
            this.btnEditSelectedPart.Size = new System.Drawing.Size(110, 26);
            this.btnEditSelectedPart.TabIndex = 22;
            this.btnEditSelectedPart.Text = "Edit Selected Part";
            this.btnEditSelectedPart.UseVisualStyleBackColor = true;
            this.btnEditSelectedPart.Click += new System.EventHandler(this.btnEditSelectedPart_Click);
            // 
            // btnGetAllParts
            // 
            this.btnGetAllParts.Location = new System.Drawing.Point(734, 490);
            this.btnGetAllParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetAllParts.Name = "btnGetAllParts";
            this.btnGetAllParts.Size = new System.Drawing.Size(98, 26);
            this.btnGetAllParts.TabIndex = 21;
            this.btnGetAllParts.Text = "Get All Parts";
            this.btnGetAllParts.UseVisualStyleBackColor = true;
            this.btnGetAllParts.Click += new System.EventHandler(this.btnGetAllParts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(582, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 24);
            this.label3.TabIndex = 88;
            this.label3.Text = "Currently Selling Bike Parts";
            // 
            // PartsBox
            // 
            this.PartsBox.FormattingEnabled = true;
            this.PartsBox.Location = new System.Drawing.Point(525, 186);
            this.PartsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(521, 290);
            this.PartsBox.TabIndex = 87;
            // 
            // lblEditRetailPrice
            // 
            this.lblEditRetailPrice.AutoSize = true;
            this.lblEditRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRetailPrice.Location = new System.Drawing.Point(740, 572);
            this.lblEditRetailPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditRetailPrice.Name = "lblEditRetailPrice";
            this.lblEditRetailPrice.Size = new System.Drawing.Size(61, 13);
            this.lblEditRetailPrice.TabIndex = 93;
            this.lblEditRetailPrice.Text = "Retail Price";
            // 
            // lblEditCostPrice
            // 
            this.lblEditCostPrice.AutoSize = true;
            this.lblEditCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCostPrice.Location = new System.Drawing.Point(740, 594);
            this.lblEditCostPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditCostPrice.Name = "lblEditCostPrice";
            this.lblEditCostPrice.Size = new System.Drawing.Size(55, 13);
            this.lblEditCostPrice.TabIndex = 94;
            this.lblEditCostPrice.Text = "Cost Price";
            // 
            // lblEditStockQuantity
            // 
            this.lblEditStockQuantity.AutoSize = true;
            this.lblEditStockQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditStockQuantity.Location = new System.Drawing.Point(740, 616);
            this.lblEditStockQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditStockQuantity.Name = "lblEditStockQuantity";
            this.lblEditStockQuantity.Size = new System.Drawing.Size(77, 13);
            this.lblEditStockQuantity.TabIndex = 95;
            this.lblEditStockQuantity.Text = "Stock Quantity";
            // 
            // txtEditItemNameBox
            // 
            this.txtEditItemNameBox.Location = new System.Drawing.Point(842, 548);
            this.txtEditItemNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditItemNameBox.Name = "txtEditItemNameBox";
            this.txtEditItemNameBox.Size = new System.Drawing.Size(96, 20);
            this.txtEditItemNameBox.TabIndex = 24;
            // 
            // txtEditRetailPriceBox
            // 
            this.txtEditRetailPriceBox.Location = new System.Drawing.Point(842, 572);
            this.txtEditRetailPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditRetailPriceBox.Name = "txtEditRetailPriceBox";
            this.txtEditRetailPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtEditRetailPriceBox.TabIndex = 25;
            // 
            // txtEditCostPriceBox
            // 
            this.txtEditCostPriceBox.Location = new System.Drawing.Point(842, 594);
            this.txtEditCostPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditCostPriceBox.Name = "txtEditCostPriceBox";
            this.txtEditCostPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtEditCostPriceBox.TabIndex = 26;
            // 
            // txtEditStockQuantityBox
            // 
            this.txtEditStockQuantityBox.Location = new System.Drawing.Point(842, 618);
            this.txtEditStockQuantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEditStockQuantityBox.Name = "txtEditStockQuantityBox";
            this.txtEditStockQuantityBox.Size = new System.Drawing.Size(76, 20);
            this.txtEditStockQuantityBox.TabIndex = 27;
            this.txtEditStockQuantityBox.TextChanged += new System.EventHandler(this.txtEditStockQuantityBox_TextChanged);
            // 
            // lblEditItemName
            // 
            this.lblEditItemName.AutoSize = true;
            this.lblEditItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditItemName.Location = new System.Drawing.Point(740, 548);
            this.lblEditItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditItemName.Name = "lblEditItemName";
            this.lblEditItemName.Size = new System.Drawing.Size(58, 13);
            this.lblEditItemName.TabIndex = 91;
            this.lblEditItemName.Text = "Item Name";
            // 
            // VendorSelectBox
            // 
            this.VendorSelectBox.FormattingEnabled = true;
            this.VendorSelectBox.Location = new System.Drawing.Point(317, 286);
            this.VendorSelectBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VendorSelectBox.Name = "VendorSelectBox";
            this.VendorSelectBox.Size = new System.Drawing.Size(92, 21);
            this.VendorSelectBox.TabIndex = 6;
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendor.Location = new System.Drawing.Point(224, 291);
            this.lblVendor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(74, 13);
            this.lblVendor.TabIndex = 105;
            this.lblVendor.Text = "Select Vendor";
            // 
            // CategorySelectBox
            // 
            this.CategorySelectBox.FormattingEnabled = true;
            this.CategorySelectBox.Location = new System.Drawing.Point(111, 286);
            this.CategorySelectBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategorySelectBox.Name = "CategorySelectBox";
            this.CategorySelectBox.Size = new System.Drawing.Size(92, 21);
            this.CategorySelectBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 492);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Select a Category";
            // 
            // EditCategoryBox
            // 
            this.EditCategoryBox.FormattingEnabled = true;
            this.EditCategoryBox.Location = new System.Drawing.Point(627, 490);
            this.EditCategoryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditCategoryBox.Name = "EditCategoryBox";
            this.EditCategoryBox.Size = new System.Drawing.Size(92, 21);
            this.EditCategoryBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Add New Bike Parts Vendor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 471);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Vendor Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 492);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Vendor Address";
            // 
            // VendorNameBox
            // 
            this.VendorNameBox.Location = new System.Drawing.Point(111, 471);
            this.VendorNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VendorNameBox.Name = "VendorNameBox";
            this.VendorNameBox.Size = new System.Drawing.Size(127, 20);
            this.VendorNameBox.TabIndex = 10;
            // 
            // VendorAddressBox
            // 
            this.VendorAddressBox.Location = new System.Drawing.Point(111, 494);
            this.VendorAddressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VendorAddressBox.Name = "VendorAddressBox";
            this.VendorAddressBox.Size = new System.Drawing.Size(332, 20);
            this.VendorAddressBox.TabIndex = 11;
            // 
            // SaveVendorButton
            // 
            this.SaveVendorButton.Location = new System.Drawing.Point(326, 525);
            this.SaveVendorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveVendorButton.Name = "SaveVendorButton";
            this.SaveVendorButton.Size = new System.Drawing.Size(109, 26);
            this.SaveVendorButton.TabIndex = 12;
            this.SaveVendorButton.Text = "Save New Vendor";
            this.SaveVendorButton.UseVisualStyleBackColor = true;
            this.SaveVendorButton.Click += new System.EventHandler(this.SaveVendorButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(959, 490);
            this.DeletePartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(78, 26);
            this.DeletePartButton.TabIndex = 23;
            this.DeletePartButton.Text = "Delete Part";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // AddPartsPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 702);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.SaveVendorButton);
            this.Controls.Add(this.VendorAddressBox);
            this.Controls.Add(this.VendorNameBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditCategoryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CategorySelectBox);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.VendorSelectBox);
            this.Controls.Add(this.btnSaveEditedPart);
            this.Controls.Add(this.txtEditStockQuantityBox);
            this.Controls.Add(this.txtEditCostPriceBox);
            this.Controls.Add(this.txtEditRetailPriceBox);
            this.Controls.Add(this.txtEditItemNameBox);
            this.Controls.Add(this.lblEditStockQuantity);
            this.Controls.Add(this.lblEditCostPrice);
            this.Controls.Add(this.lblEditRetailPrice);
            this.Controls.Add(this.lblEditItemName);
            this.Controls.Add(this.btnEditSelectedPart);
            this.Controls.Add(this.btnGetAllParts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PartsBox);
            this.Controls.Add(this.btnBackToAdminPg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSavePart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStockQuantity);
            this.Controls.Add(this.LastCostLabel);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtStockQuantityBox);
            this.Controls.Add(this.txtCostPriceBox);
            this.Controls.Add(this.txtRetailPriceBox);
            this.Controls.Add(this.txtItemNameBox);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.label1);
            this.Name = "AddPartsPg";
            this.Text = "Admin Parts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPartsPg_Closed);
            this.Load += new System.EventHandler(this.AdminPg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TextBox txtItemNameBox;
        private System.Windows.Forms.TextBox txtRetailPriceBox;
        private System.Windows.Forms.TextBox txtCostPriceBox;
        private System.Windows.Forms.TextBox txtStockQuantityBox;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label LastCostLabel;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBackToAdminPg;
        private System.Windows.Forms.Button btnSaveEditedPart;
        private System.Windows.Forms.Button btnEditSelectedPart;
        private System.Windows.Forms.Button btnGetAllParts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox PartsBox;
        private System.Windows.Forms.Label lblEditRetailPrice;
        private System.Windows.Forms.Label lblEditCostPrice;
        private System.Windows.Forms.Label lblEditStockQuantity;
        private System.Windows.Forms.TextBox txtEditItemNameBox;
        private System.Windows.Forms.TextBox txtEditRetailPriceBox;
        private System.Windows.Forms.TextBox txtEditCostPriceBox;
        private System.Windows.Forms.TextBox txtEditStockQuantityBox;
        private System.Windows.Forms.Label lblEditItemName;
        private System.Windows.Forms.ComboBox VendorSelectBox;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.ComboBox CategorySelectBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EditCategoryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox VendorNameBox;
        private System.Windows.Forms.TextBox VendorAddressBox;
        private System.Windows.Forms.Button SaveVendorButton;
        private System.Windows.Forms.Button DeletePartButton;
    }
}