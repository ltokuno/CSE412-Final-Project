﻿namespace CSE412_Group17
{
    partial class MyCartPg
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btnParts = new System.Windows.Forms.Button();
            this.panelParts = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnMyCart = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panelResources = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnResources = new System.Windows.Forms.Button();
            this.lblCartMessage = new System.Windows.Forms.Label();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblPlaceOrderMessage = new System.Windows.Forms.Label();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.panelParts.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelResources.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnParts
            // 
            this.btnParts.BackColor = System.Drawing.Color.Gray;
            this.btnParts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParts.FlatAppearance.BorderSize = 0;
            this.btnParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParts.ForeColor = System.Drawing.Color.Transparent;
            this.btnParts.Location = new System.Drawing.Point(0, 0);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(249, 52);
            this.btnParts.TabIndex = 4;
            this.btnParts.Text = "Parts";
            this.btnParts.UseVisualStyleBackColor = false;
            this.btnParts.Click += new System.EventHandler(this.btnParts_Click);
            // 
            // panelParts
            // 
            this.panelParts.Controls.Add(this.button1);
            this.panelParts.Controls.Add(this.btnParts);
            this.panelParts.Location = new System.Drawing.Point(81, 143);
            this.panelParts.Name = "panelParts";
            this.panelParts.Size = new System.Drawing.Size(249, 52);
            this.panelParts.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 118);
            this.button1.TabIndex = 12;
            this.button1.Text = "Parts";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.BackColor = System.Drawing.Color.Gray;
            this.btnMyAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyAccount.FlatAppearance.BorderSize = 0;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccount.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyAccount.Location = new System.Drawing.Point(0, 0);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(249, 52);
            this.btnMyAccount.TabIndex = 13;
            this.btnMyAccount.Text = "My Account";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.btnMyOrders);
            this.panelAccount.Controls.Add(this.btnMyCart);
            this.panelAccount.Controls.Add(this.btnSignOut);
            this.panelAccount.Controls.Add(this.btnMyAccount);
            this.panelAccount.Location = new System.Drawing.Point(419, 143);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(249, 52);
            this.panelAccount.TabIndex = 14;
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.Color.Gray;
            this.btnMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOrders.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyOrders.Location = new System.Drawing.Point(0, 126);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(249, 37);
            this.btnMyOrders.TabIndex = 16;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnMyCart
            // 
            this.btnMyCart.BackColor = System.Drawing.Color.Gray;
            this.btnMyCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyCart.FlatAppearance.BorderSize = 0;
            this.btnMyCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCart.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyCart.Location = new System.Drawing.Point(0, 89);
            this.btnMyCart.Name = "btnMyCart";
            this.btnMyCart.Size = new System.Drawing.Size(249, 37);
            this.btnMyCart.TabIndex = 15;
            this.btnMyCart.Text = "My Cart";
            this.btnMyCart.UseVisualStyleBackColor = false;
            this.btnMyCart.Click += new System.EventHandler(this.btnMyCart_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Gray;
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Location = new System.Drawing.Point(0, 52);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(249, 37);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignInRegister_Click);
            // 
            // panelResources
            // 
            this.panelResources.Controls.Add(this.btnAboutUs);
            this.panelResources.Controls.Add(this.btnResources);
            this.panelResources.Location = new System.Drawing.Point(737, 143);
            this.panelResources.Name = "panelResources";
            this.panelResources.Size = new System.Drawing.Size(249, 52);
            this.panelResources.TabIndex = 17;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Gray;
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 52);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(249, 37);
            this.btnAboutUs.TabIndex = 14;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnResources
            // 
            this.btnResources.BackColor = System.Drawing.Color.Gray;
            this.btnResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResources.FlatAppearance.BorderSize = 0;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResources.ForeColor = System.Drawing.Color.Transparent;
            this.btnResources.Location = new System.Drawing.Point(0, 0);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(249, 52);
            this.btnResources.TabIndex = 13;
            this.btnResources.Text = "Resources";
            this.btnResources.UseVisualStyleBackColor = false;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // lblCartMessage
            // 
            this.lblCartMessage.AutoSize = true;
            this.lblCartMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartMessage.Location = new System.Drawing.Point(77, 286);
            this.lblCartMessage.Name = "lblCartMessage";
            this.lblCartMessage.Size = new System.Drawing.Size(167, 20);
            this.lblCartMessage.TabIndex = 18;
            this.lblCartMessage.Text = "Your Shopping Cart";
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Location = new System.Drawing.Point(387, 42);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(318, 58);
            this.btnHomePage.TabIndex = 21;
            this.btnHomePage.Text = "Store Name";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItem,
            this.columnPrice,
            this.columnQuantity});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(81, 343);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(624, 266);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnItem
            // 
            this.columnItem.Text = "Item";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(796, 434);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(132, 43);
            this.btnPlaceOrder.TabIndex = 23;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblPlaceOrderMessage
            // 
            this.lblPlaceOrderMessage.AutoSize = true;
            this.lblPlaceOrderMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrderMessage.Location = new System.Drawing.Point(742, 397);
            this.lblPlaceOrderMessage.Name = "lblPlaceOrderMessage";
            this.lblPlaceOrderMessage.Size = new System.Drawing.Size(244, 20);
            this.lblPlaceOrderMessage.TabIndex = 24;
            this.lblPlaceOrderMessage.Text = "Click below to place an order!";
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.Gray;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyProfile.Location = new System.Drawing.Point(884, 63);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(102, 37);
            this.btnMyProfile.TabIndex = 25;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // MyCartPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 702);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.lblPlaceOrderMessage);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.panelParts);
            this.Controls.Add(this.panelResources);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.lblCartMessage);
            this.Controls.Add(this.listView1);
            this.Name = "MyCartPg";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MyCartPg_FormClosed);
            this.panelParts.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.panelResources.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Panel panelParts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnMyCart;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel panelResources;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.Label lblCartMessage;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnItem;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblPlaceOrderMessage;
        private System.Windows.Forms.Button btnMyProfile;
    }
}