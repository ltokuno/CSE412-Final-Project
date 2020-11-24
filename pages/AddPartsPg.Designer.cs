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
            this.txtCategoryBox = new System.Windows.Forms.TextBox();
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
            this.lblEditCategory = new System.Windows.Forms.Label();
            this.lblEditRetailPrice = new System.Windows.Forms.Label();
            this.lblEditCostPrice = new System.Windows.Forms.Label();
            this.lblEditStockQuantity = new System.Windows.Forms.Label();
            this.txtEditItemNameBox = new System.Windows.Forms.TextBox();
            this.txtEditCategoryBox = new System.Windows.Forms.TextBox();
            this.txtEditRetailPriceBox = new System.Windows.Forms.TextBox();
            this.txtEditCostPriceBox = new System.Windows.Forms.TextBox();
            this.txtEditStockQuantityBox = new System.Windows.Forms.TextBox();
            this.lblEditItemName = new System.Windows.Forms.Label();
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
            this.txtItemNameBox.TabIndex = 32;
            // 
            // txtCategoryBox
            // 
            this.txtCategoryBox.Location = new System.Drawing.Point(111, 286);
            this.txtCategoryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCategoryBox.Name = "txtCategoryBox";
            this.txtCategoryBox.Size = new System.Drawing.Size(98, 20);
            this.txtCategoryBox.TabIndex = 33;
            this.txtCategoryBox.UseSystemPasswordChar = true;
            // 
            // txtRetailPriceBox
            // 
            this.txtRetailPriceBox.Location = new System.Drawing.Point(111, 309);
            this.txtRetailPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRetailPriceBox.Name = "txtRetailPriceBox";
            this.txtRetailPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtRetailPriceBox.TabIndex = 34;
            // 
            // txtCostPriceBox
            // 
            this.txtCostPriceBox.Location = new System.Drawing.Point(111, 333);
            this.txtCostPriceBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostPriceBox.Name = "txtCostPriceBox";
            this.txtCostPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtCostPriceBox.TabIndex = 35;
            // 
            // txtStockQuantityBox
            // 
            this.txtStockQuantityBox.Location = new System.Drawing.Point(317, 263);
            this.txtStockQuantityBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStockQuantityBox.Name = "txtStockQuantityBox";
            this.txtStockQuantityBox.Size = new System.Drawing.Size(76, 20);
            this.txtStockQuantityBox.TabIndex = 36;
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
            this.label2.Location = new System.Drawing.Point(16, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Enter A New Bike Part";
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(278, 309);
            this.btnSavePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(58, 20);
            this.btnSavePart.TabIndex = 53;
            this.btnSavePart.Text = "Save";
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
            this.btnSaveEditedPart.Location = new System.Drawing.Point(751, 649);
            this.btnSaveEditedPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveEditedPart.Name = "btnSaveEditedPart";
            this.btnSaveEditedPart.Size = new System.Drawing.Size(94, 28);
            this.btnSaveEditedPart.TabIndex = 103;
            this.btnSaveEditedPart.Text = "Save Changes";
            this.btnSaveEditedPart.UseVisualStyleBackColor = true;
            // 
            // btnEditSelectedPart
            // 
            this.btnEditSelectedPart.Location = new System.Drawing.Point(634, 481);
            this.btnEditSelectedPart.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSelectedPart.Name = "btnEditSelectedPart";
            this.btnEditSelectedPart.Size = new System.Drawing.Size(110, 26);
            this.btnEditSelectedPart.TabIndex = 90;
            this.btnEditSelectedPart.Text = "Edit Selected Part";
            this.btnEditSelectedPart.UseVisualStyleBackColor = true;
            // 
            // btnGetAllParts
            // 
            this.btnGetAllParts.Location = new System.Drawing.Point(525, 481);
            this.btnGetAllParts.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAllParts.Name = "btnGetAllParts";
            this.btnGetAllParts.Size = new System.Drawing.Size(98, 26);
            this.btnGetAllParts.TabIndex = 89;
            this.btnGetAllParts.Text = "Get All Parts";
            this.btnGetAllParts.UseVisualStyleBackColor = true;
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
            this.PartsBox.Margin = new System.Windows.Forms.Padding(2);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(521, 290);
            this.PartsBox.TabIndex = 87;
            // 
            // lblEditCategory
            // 
            this.lblEditCategory.AutoSize = true;
            this.lblEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCategory.Location = new System.Drawing.Point(532, 544);
            this.lblEditCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditCategory.Name = "lblEditCategory";
            this.lblEditCategory.Size = new System.Drawing.Size(49, 13);
            this.lblEditCategory.TabIndex = 92;
            this.lblEditCategory.Text = "Category";
            // 
            // lblEditRetailPrice
            // 
            this.lblEditRetailPrice.AutoSize = true;
            this.lblEditRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRetailPrice.Location = new System.Drawing.Point(532, 567);
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
            this.lblEditCostPrice.Location = new System.Drawing.Point(532, 589);
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
            this.lblEditStockQuantity.Location = new System.Drawing.Point(532, 611);
            this.lblEditStockQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditStockQuantity.Name = "lblEditStockQuantity";
            this.lblEditStockQuantity.Size = new System.Drawing.Size(77, 13);
            this.lblEditStockQuantity.TabIndex = 95;
            this.lblEditStockQuantity.Text = "Stock Quantity";
            // 
            // txtEditItemNameBox
            // 
            this.txtEditItemNameBox.Location = new System.Drawing.Point(634, 519);
            this.txtEditItemNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditItemNameBox.Name = "txtEditItemNameBox";
            this.txtEditItemNameBox.Size = new System.Drawing.Size(96, 20);
            this.txtEditItemNameBox.TabIndex = 97;
            // 
            // txtEditCategoryBox
            // 
            this.txtEditCategoryBox.Location = new System.Drawing.Point(634, 543);
            this.txtEditCategoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditCategoryBox.Name = "txtEditCategoryBox";
            this.txtEditCategoryBox.Size = new System.Drawing.Size(96, 20);
            this.txtEditCategoryBox.TabIndex = 98;
            // 
            // txtEditRetailPriceBox
            // 
            this.txtEditRetailPriceBox.Location = new System.Drawing.Point(634, 567);
            this.txtEditRetailPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditRetailPriceBox.Name = "txtEditRetailPriceBox";
            this.txtEditRetailPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtEditRetailPriceBox.TabIndex = 99;
            // 
            // txtEditCostPriceBox
            // 
            this.txtEditCostPriceBox.Location = new System.Drawing.Point(634, 589);
            this.txtEditCostPriceBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditCostPriceBox.Name = "txtEditCostPriceBox";
            this.txtEditCostPriceBox.Size = new System.Drawing.Size(76, 20);
            this.txtEditCostPriceBox.TabIndex = 100;
            // 
            // txtEditStockQuantityBox
            // 
            this.txtEditStockQuantityBox.Location = new System.Drawing.Point(634, 613);
            this.txtEditStockQuantityBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditStockQuantityBox.Name = "txtEditStockQuantityBox";
            this.txtEditStockQuantityBox.Size = new System.Drawing.Size(76, 20);
            this.txtEditStockQuantityBox.TabIndex = 101;
            // 
            // lblEditItemName
            // 
            this.lblEditItemName.AutoSize = true;
            this.lblEditItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditItemName.Location = new System.Drawing.Point(532, 519);
            this.lblEditItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditItemName.Name = "lblEditItemName";
            this.lblEditItemName.Size = new System.Drawing.Size(58, 13);
            this.lblEditItemName.TabIndex = 91;
            this.lblEditItemName.Text = "Item Name";
            // 
            // AddPartsPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 702);
            this.Controls.Add(this.btnSaveEditedPart);
            this.Controls.Add(this.txtEditStockQuantityBox);
            this.Controls.Add(this.txtEditCostPriceBox);
            this.Controls.Add(this.txtEditRetailPriceBox);
            this.Controls.Add(this.txtEditCategoryBox);
            this.Controls.Add(this.txtEditItemNameBox);
            this.Controls.Add(this.lblEditStockQuantity);
            this.Controls.Add(this.lblEditCostPrice);
            this.Controls.Add(this.lblEditRetailPrice);
            this.Controls.Add(this.lblEditCategory);
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
            this.Controls.Add(this.txtCategoryBox);
            this.Controls.Add(this.txtItemNameBox);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.label1);
            this.Name = "AddPartsPg";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.AdminPg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TextBox txtItemNameBox;
        private System.Windows.Forms.TextBox txtCategoryBox;
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
        private System.Windows.Forms.Label lblEditCategory;
        private System.Windows.Forms.Label lblEditRetailPrice;
        private System.Windows.Forms.Label lblEditCostPrice;
        private System.Windows.Forms.Label lblEditStockQuantity;
        private System.Windows.Forms.TextBox txtEditItemNameBox;
        private System.Windows.Forms.TextBox txtEditCategoryBox;
        private System.Windows.Forms.TextBox txtEditRetailPriceBox;
        private System.Windows.Forms.TextBox txtEditCostPriceBox;
        private System.Windows.Forms.TextBox txtEditStockQuantityBox;
        private System.Windows.Forms.Label lblEditItemName;
    }
}