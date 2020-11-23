namespace CSE412_Group17
{
    partial class AdminBox
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
            this.UsersBox = new System.Windows.Forms.ListBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.DOBBox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.DOBLabel = new System.Windows.Forms.Label();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveUserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GetAllUsersButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.EditFirstNameLabel = new System.Windows.Forms.Label();
            this.EditLastNameLabel = new System.Windows.Forms.Label();
            this.EditAddressLabel = new System.Windows.Forms.Label();
            this.EditPhoneNumberLabel = new System.Windows.Forms.Label();
            this.EditEmailLabel = new System.Windows.Forms.Label();
            this.EditAdminLabel = new System.Windows.Forms.Label();
            this.EditFirstNameBox = new System.Windows.Forms.TextBox();
            this.EditLastNameBox = new System.Windows.Forms.TextBox();
            this.EditAddressBox = new System.Windows.Forms.TextBox();
            this.EditPhoneNumberBox = new System.Windows.Forms.TextBox();
            this.EditEmailBox = new System.Windows.Forms.TextBox();
            this.EditAdminBox = new System.Windows.Forms.CheckBox();
            this.EditSaveChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 69);
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
            this.btnSignOut.Location = new System.Drawing.Point(1079, 32);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(136, 46);
            this.btnSignOut.TabIndex = 30;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // UsersBox
            // 
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.ItemHeight = 16;
            this.UsersBox.Location = new System.Drawing.Point(688, 142);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(693, 356);
            this.UsersBox.TabIndex = 31;
            this.UsersBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(152, 198);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 22);
            this.UsernameBox.TabIndex = 32;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(152, 227);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordBox.TabIndex = 33;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(152, 255);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(100, 22);
            this.FirstNameBox.TabIndex = 34;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(152, 284);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(100, 22);
            this.LastNameBox.TabIndex = 35;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(426, 198);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneNumberBox.TabIndex = 36;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(26, 198);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(73, 17);
            this.UsernameLabel.TabIndex = 37;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(26, 227);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(69, 17);
            this.PasswordLabel.TabIndex = 38;
            this.PasswordLabel.Text = "Password";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(26, 255);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.FirstNameLabel.TabIndex = 39;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(26, 284);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.LastNameLabel.TabIndex = 40;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(300, 198);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumberLabel.TabIndex = 41;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(426, 227);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(224, 22);
            this.AddressBox.TabIndex = 42;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(426, 256);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(224, 22);
            this.EmailBox.TabIndex = 43;
            // 
            // DOBBox
            // 
            this.DOBBox.Location = new System.Drawing.Point(426, 285);
            this.DOBBox.Name = "DOBBox";
            this.DOBBox.Size = new System.Drawing.Size(100, 22);
            this.DOBBox.TabIndex = 44;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(303, 315);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(56, 17);
            this.GenderLabel.TabIndex = 45;
            this.GenderLabel.Text = "Gender";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(303, 256);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 46;
            this.EmailLabel.Text = "Email";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(303, 227);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(60, 17);
            this.AddressLabel.TabIndex = 47;
            this.AddressLabel.Text = "Address";
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Location = new System.Drawing.Point(152, 315);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(127, 21);
            this.AdminCheckBox.TabIndex = 48;
            this.AdminCheckBox.Text = "Is Administrator";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Location = new System.Drawing.Point(303, 285);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(90, 17);
            this.DOBLabel.TabIndex = 49;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(426, 315);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(59, 21);
            this.MaleButton.TabIndex = 50;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(493, 315);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleButton.TabIndex = 51;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Enter A New User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Location = new System.Drawing.Point(451, 357);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(75, 23);
            this.SaveUserButton.TabIndex = 53;
            this.SaveUserButton.Text = "Save";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            this.SaveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "Currently Registered Users";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GetAllUsersButton
            // 
            this.GetAllUsersButton.Location = new System.Drawing.Point(688, 504);
            this.GetAllUsersButton.Name = "GetAllUsersButton";
            this.GetAllUsersButton.Size = new System.Drawing.Size(130, 23);
            this.GetAllUsersButton.TabIndex = 56;
            this.GetAllUsersButton.Text = "Get All Users";
            this.GetAllUsersButton.UseVisualStyleBackColor = true;
            this.GetAllUsersButton.Click += new System.EventHandler(this.GetAllUsersButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(833, 504);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(147, 23);
            this.EditUserButton.TabIndex = 57;
            this.EditUserButton.Text = "Edit Selected User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // EditFirstNameLabel
            // 
            this.EditFirstNameLabel.AutoSize = true;
            this.EditFirstNameLabel.Location = new System.Drawing.Point(697, 552);
            this.EditFirstNameLabel.Name = "EditFirstNameLabel";
            this.EditFirstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.EditFirstNameLabel.TabIndex = 58;
            this.EditFirstNameLabel.Text = "First Name";
            // 
            // EditLastNameLabel
            // 
            this.EditLastNameLabel.AutoSize = true;
            this.EditLastNameLabel.Location = new System.Drawing.Point(697, 582);
            this.EditLastNameLabel.Name = "EditLastNameLabel";
            this.EditLastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.EditLastNameLabel.TabIndex = 59;
            this.EditLastNameLabel.Text = "Last Name";
            // 
            // EditAddressLabel
            // 
            this.EditAddressLabel.AutoSize = true;
            this.EditAddressLabel.Location = new System.Drawing.Point(697, 610);
            this.EditAddressLabel.Name = "EditAddressLabel";
            this.EditAddressLabel.Size = new System.Drawing.Size(60, 17);
            this.EditAddressLabel.TabIndex = 60;
            this.EditAddressLabel.Text = "Address";
            // 
            // EditPhoneNumberLabel
            // 
            this.EditPhoneNumberLabel.AutoSize = true;
            this.EditPhoneNumberLabel.Location = new System.Drawing.Point(697, 637);
            this.EditPhoneNumberLabel.Name = "EditPhoneNumberLabel";
            this.EditPhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.EditPhoneNumberLabel.TabIndex = 61;
            this.EditPhoneNumberLabel.Text = "Phone Number";
            // 
            // EditEmailLabel
            // 
            this.EditEmailLabel.AutoSize = true;
            this.EditEmailLabel.Location = new System.Drawing.Point(697, 664);
            this.EditEmailLabel.Name = "EditEmailLabel";
            this.EditEmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EditEmailLabel.TabIndex = 62;
            this.EditEmailLabel.Text = "Email";
            this.EditEmailLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // EditAdminLabel
            // 
            this.EditAdminLabel.AutoSize = true;
            this.EditAdminLabel.Location = new System.Drawing.Point(697, 693);
            this.EditAdminLabel.Name = "EditAdminLabel";
            this.EditAdminLabel.Size = new System.Drawing.Size(113, 17);
            this.EditAdminLabel.TabIndex = 63;
            this.EditAdminLabel.Text = "Is Administrator?";
            // 
            // EditFirstNameBox
            // 
            this.EditFirstNameBox.Location = new System.Drawing.Point(833, 552);
            this.EditFirstNameBox.Name = "EditFirstNameBox";
            this.EditFirstNameBox.Size = new System.Drawing.Size(179, 22);
            this.EditFirstNameBox.TabIndex = 64;
            // 
            // EditLastNameBox
            // 
            this.EditLastNameBox.Location = new System.Drawing.Point(833, 581);
            this.EditLastNameBox.Name = "EditLastNameBox";
            this.EditLastNameBox.Size = new System.Drawing.Size(179, 22);
            this.EditLastNameBox.TabIndex = 65;
            // 
            // EditAddressBox
            // 
            this.EditAddressBox.Location = new System.Drawing.Point(833, 610);
            this.EditAddressBox.Name = "EditAddressBox";
            this.EditAddressBox.Size = new System.Drawing.Size(337, 22);
            this.EditAddressBox.TabIndex = 66;
            // 
            // EditPhoneNumberBox
            // 
            this.EditPhoneNumberBox.Location = new System.Drawing.Point(833, 638);
            this.EditPhoneNumberBox.Name = "EditPhoneNumberBox";
            this.EditPhoneNumberBox.Size = new System.Drawing.Size(179, 22);
            this.EditPhoneNumberBox.TabIndex = 67;
            // 
            // EditEmailBox
            // 
            this.EditEmailBox.Location = new System.Drawing.Point(833, 667);
            this.EditEmailBox.Name = "EditEmailBox";
            this.EditEmailBox.Size = new System.Drawing.Size(179, 22);
            this.EditEmailBox.TabIndex = 68;
            // 
            // EditAdminBox
            // 
            this.EditAdminBox.AutoSize = true;
            this.EditAdminBox.Location = new System.Drawing.Point(833, 693);
            this.EditAdminBox.Name = "EditAdminBox";
            this.EditAdminBox.Size = new System.Drawing.Size(69, 21);
            this.EditAdminBox.TabIndex = 69;
            this.EditAdminBox.Text = "Admin";
            this.EditAdminBox.UseVisualStyleBackColor = true;
            this.EditAdminBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EditSaveChangesButton
            // 
            this.EditSaveChangesButton.Location = new System.Drawing.Point(1005, 715);
            this.EditSaveChangesButton.Name = "EditSaveChangesButton";
            this.EditSaveChangesButton.Size = new System.Drawing.Size(117, 23);
            this.EditSaveChangesButton.TabIndex = 70;
            this.EditSaveChangesButton.Text = "Save Changes";
            this.EditSaveChangesButton.UseVisualStyleBackColor = true;
            this.EditSaveChangesButton.Click += new System.EventHandler(this.EditSaveChangesButton_Click);
            // 
            // AdminBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 864);
            this.Controls.Add(this.EditSaveChangesButton);
            this.Controls.Add(this.EditAdminBox);
            this.Controls.Add(this.EditEmailBox);
            this.Controls.Add(this.EditPhoneNumberBox);
            this.Controls.Add(this.EditAddressBox);
            this.Controls.Add(this.EditLastNameBox);
            this.Controls.Add(this.EditFirstNameBox);
            this.Controls.Add(this.EditAdminLabel);
            this.Controls.Add(this.EditEmailLabel);
            this.Controls.Add(this.EditPhoneNumberLabel);
            this.Controls.Add(this.EditAddressLabel);
            this.Controls.Add(this.EditLastNameLabel);
            this.Controls.Add(this.EditFirstNameLabel);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.GetAllUsersButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveUserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FemaleButton);
            this.Controls.Add(this.MaleButton);
            this.Controls.Add(this.DOBLabel);
            this.Controls.Add(this.AdminCheckBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.DOBBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminBox";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.AdminPg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.ListBox UsersBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox DOBBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.Label DOBLabel;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveUserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GetAllUsersButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Label EditFirstNameLabel;
        private System.Windows.Forms.Label EditLastNameLabel;
        private System.Windows.Forms.Label EditAddressLabel;
        private System.Windows.Forms.Label EditPhoneNumberLabel;
        private System.Windows.Forms.Label EditEmailLabel;
        private System.Windows.Forms.Label EditAdminLabel;
        private System.Windows.Forms.TextBox EditFirstNameBox;
        private System.Windows.Forms.TextBox EditLastNameBox;
        private System.Windows.Forms.TextBox EditAddressBox;
        private System.Windows.Forms.TextBox EditPhoneNumberBox;
        private System.Windows.Forms.TextBox EditEmailBox;
        private System.Windows.Forms.CheckBox EditAdminBox;
        private System.Windows.Forms.Button EditSaveChangesButton;
    }
}