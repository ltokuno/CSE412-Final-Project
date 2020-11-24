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
            this.EditLoginCredsLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.ListBox();
            this.EditUsernameBox = new System.Windows.Forms.TextBox();
            this.EditPasswordBox = new System.Windows.Forms.TextBox();
            this.EditPasswordBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GetLoginCredentialsButton = new System.Windows.Forms.Button();
            this.EditSelectedCredentialButton = new System.Windows.Forms.Button();
            this.EditCredentialsSaveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.btnAddParts = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
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
            // UsersBox
            // 
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(516, 115);
            this.UsersBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(521, 290);
            this.UsersBox.TabIndex = 31;
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(114, 161);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(76, 20);
            this.UsernameBox.TabIndex = 32;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(114, 184);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(76, 20);
            this.PasswordBox.TabIndex = 33;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(114, 207);
            this.FirstNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(76, 20);
            this.FirstNameBox.TabIndex = 34;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(114, 231);
            this.LastNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(76, 20);
            this.LastNameBox.TabIndex = 35;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Location = new System.Drawing.Point(320, 161);
            this.PhoneNumberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(76, 20);
            this.PhoneNumberBox.TabIndex = 36;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(20, 161);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 37;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(20, 184);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 38;
            this.PasswordLabel.Text = "Password";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(20, 207);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 39;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(20, 231);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 40;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(225, 161);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 41;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(320, 184);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(169, 20);
            this.AddressBox.TabIndex = 42;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(320, 208);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(169, 20);
            this.EmailBox.TabIndex = 43;
            // 
            // DOBBox
            // 
            this.DOBBox.Location = new System.Drawing.Point(320, 232);
            this.DOBBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DOBBox.Name = "DOBBox";
            this.DOBBox.Size = new System.Drawing.Size(76, 20);
            this.DOBBox.TabIndex = 44;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(227, 256);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderLabel.TabIndex = 45;
            this.GenderLabel.Text = "Gender";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(227, 208);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 46;
            this.EmailLabel.Text = "Email";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(227, 184);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 47;
            this.AddressLabel.Text = "Address";
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheckBox.Location = new System.Drawing.Point(114, 256);
            this.AdminCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(97, 17);
            this.AdminCheckBox.TabIndex = 48;
            this.AdminCheckBox.Text = "Is Administrator";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // DOBLabel
            // 
            this.DOBLabel.AutoSize = true;
            this.DOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBLabel.Location = new System.Drawing.Point(227, 232);
            this.DOBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DOBLabel.Name = "DOBLabel";
            this.DOBLabel.Size = new System.Drawing.Size(68, 13);
            this.DOBLabel.TabIndex = 49;
            this.DOBLabel.Text = "Date Of Birth";
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaleButton.Location = new System.Drawing.Point(320, 256);
            this.MaleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(48, 17);
            this.MaleButton.TabIndex = 50;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemaleButton.Location = new System.Drawing.Point(370, 256);
            this.FemaleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleButton.TabIndex = 51;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Enter A New User";
            // 
            // SaveUserButton
            // 
            this.SaveUserButton.Location = new System.Drawing.Point(338, 290);
            this.SaveUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveUserButton.Name = "SaveUserButton";
            this.SaveUserButton.Size = new System.Drawing.Size(58, 20);
            this.SaveUserButton.TabIndex = 53;
            this.SaveUserButton.Text = "Save";
            this.SaveUserButton.UseVisualStyleBackColor = true;
            this.SaveUserButton.Click += new System.EventHandler(this.SaveUserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(573, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Currently Registered Users";
            // 
            // GetAllUsersButton
            // 
            this.GetAllUsersButton.Location = new System.Drawing.Point(516, 410);
            this.GetAllUsersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetAllUsersButton.Name = "GetAllUsersButton";
            this.GetAllUsersButton.Size = new System.Drawing.Size(98, 26);
            this.GetAllUsersButton.TabIndex = 56;
            this.GetAllUsersButton.Text = "Get All Users";
            this.GetAllUsersButton.UseVisualStyleBackColor = true;
            this.GetAllUsersButton.Click += new System.EventHandler(this.GetAllUsersButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(625, 410);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(110, 26);
            this.EditUserButton.TabIndex = 57;
            this.EditUserButton.Text = "Edit Selected User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // EditFirstNameLabel
            // 
            this.EditFirstNameLabel.AutoSize = true;
            this.EditFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFirstNameLabel.Location = new System.Drawing.Point(523, 448);
            this.EditFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditFirstNameLabel.Name = "EditFirstNameLabel";
            this.EditFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.EditFirstNameLabel.TabIndex = 58;
            this.EditFirstNameLabel.Text = "First Name";
            // 
            // EditLastNameLabel
            // 
            this.EditLastNameLabel.AutoSize = true;
            this.EditLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLastNameLabel.Location = new System.Drawing.Point(523, 473);
            this.EditLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditLastNameLabel.Name = "EditLastNameLabel";
            this.EditLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.EditLastNameLabel.TabIndex = 59;
            this.EditLastNameLabel.Text = "Last Name";
            // 
            // EditAddressLabel
            // 
            this.EditAddressLabel.AutoSize = true;
            this.EditAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAddressLabel.Location = new System.Drawing.Point(523, 496);
            this.EditAddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditAddressLabel.Name = "EditAddressLabel";
            this.EditAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.EditAddressLabel.TabIndex = 60;
            this.EditAddressLabel.Text = "Address";
            // 
            // EditPhoneNumberLabel
            // 
            this.EditPhoneNumberLabel.AutoSize = true;
            this.EditPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPhoneNumberLabel.Location = new System.Drawing.Point(523, 518);
            this.EditPhoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditPhoneNumberLabel.Name = "EditPhoneNumberLabel";
            this.EditPhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.EditPhoneNumberLabel.TabIndex = 61;
            this.EditPhoneNumberLabel.Text = "Phone Number";
            // 
            // EditEmailLabel
            // 
            this.EditEmailLabel.AutoSize = true;
            this.EditEmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmailLabel.Location = new System.Drawing.Point(523, 540);
            this.EditEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditEmailLabel.Name = "EditEmailLabel";
            this.EditEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EditEmailLabel.TabIndex = 62;
            this.EditEmailLabel.Text = "Email";
            // 
            // EditAdminLabel
            // 
            this.EditAdminLabel.AutoSize = true;
            this.EditAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAdminLabel.Location = new System.Drawing.Point(523, 563);
            this.EditAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditAdminLabel.Name = "EditAdminLabel";
            this.EditAdminLabel.Size = new System.Drawing.Size(84, 13);
            this.EditAdminLabel.TabIndex = 63;
            this.EditAdminLabel.Text = "Is Administrator?";
            // 
            // EditFirstNameBox
            // 
            this.EditFirstNameBox.Location = new System.Drawing.Point(625, 448);
            this.EditFirstNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditFirstNameBox.Name = "EditFirstNameBox";
            this.EditFirstNameBox.Size = new System.Drawing.Size(135, 20);
            this.EditFirstNameBox.TabIndex = 64;
            // 
            // EditLastNameBox
            // 
            this.EditLastNameBox.Location = new System.Drawing.Point(625, 472);
            this.EditLastNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditLastNameBox.Name = "EditLastNameBox";
            this.EditLastNameBox.Size = new System.Drawing.Size(135, 20);
            this.EditLastNameBox.TabIndex = 65;
            // 
            // EditAddressBox
            // 
            this.EditAddressBox.Location = new System.Drawing.Point(625, 496);
            this.EditAddressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditAddressBox.Name = "EditAddressBox";
            this.EditAddressBox.Size = new System.Drawing.Size(254, 20);
            this.EditAddressBox.TabIndex = 66;
            // 
            // EditPhoneNumberBox
            // 
            this.EditPhoneNumberBox.Location = new System.Drawing.Point(625, 518);
            this.EditPhoneNumberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditPhoneNumberBox.Name = "EditPhoneNumberBox";
            this.EditPhoneNumberBox.Size = new System.Drawing.Size(135, 20);
            this.EditPhoneNumberBox.TabIndex = 67;
            // 
            // EditEmailBox
            // 
            this.EditEmailBox.Location = new System.Drawing.Point(625, 542);
            this.EditEmailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditEmailBox.Name = "EditEmailBox";
            this.EditEmailBox.Size = new System.Drawing.Size(135, 20);
            this.EditEmailBox.TabIndex = 68;
            // 
            // EditAdminBox
            // 
            this.EditAdminBox.AutoSize = true;
            this.EditAdminBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAdminBox.Location = new System.Drawing.Point(625, 563);
            this.EditAdminBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditAdminBox.Name = "EditAdminBox";
            this.EditAdminBox.Size = new System.Drawing.Size(55, 17);
            this.EditAdminBox.TabIndex = 69;
            this.EditAdminBox.Text = "Admin";
            this.EditAdminBox.UseVisualStyleBackColor = true;
            // 
            // EditSaveChangesButton
            // 
            this.EditSaveChangesButton.Location = new System.Drawing.Point(754, 581);
            this.EditSaveChangesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditSaveChangesButton.Name = "EditSaveChangesButton";
            this.EditSaveChangesButton.Size = new System.Drawing.Size(94, 28);
            this.EditSaveChangesButton.TabIndex = 70;
            this.EditSaveChangesButton.Text = "Save Changes";
            this.EditSaveChangesButton.UseVisualStyleBackColor = true;
            this.EditSaveChangesButton.Click += new System.EventHandler(this.EditSaveChangesButton_Click);
            // 
            // EditLoginCredsLabel
            // 
            this.EditLoginCredsLabel.AutoSize = true;
            this.EditLoginCredsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLoginCredsLabel.Location = new System.Drawing.Point(22, 358);
            this.EditLoginCredsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditLoginCredsLabel.Name = "EditLoginCredsLabel";
            this.EditLoginCredsLabel.Size = new System.Drawing.Size(264, 24);
            this.EditLoginCredsLabel.TabIndex = 71;
            this.EditLoginCredsLabel.Text = "Edit User Login Credentials";
            // 
            // LoginBox
            // 
            this.LoginBox.FormattingEnabled = true;
            this.LoginBox.Location = new System.Drawing.Point(26, 410);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(368, 160);
            this.LoginBox.TabIndex = 72;
            // 
            // EditUsernameBox
            // 
            this.EditUsernameBox.Location = new System.Drawing.Point(134, 607);
            this.EditUsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditUsernameBox.Name = "EditUsernameBox";
            this.EditUsernameBox.Size = new System.Drawing.Size(76, 20);
            this.EditUsernameBox.TabIndex = 73;
            // 
            // EditPasswordBox
            // 
            this.EditPasswordBox.Location = new System.Drawing.Point(134, 630);
            this.EditPasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditPasswordBox.Name = "EditPasswordBox";
            this.EditPasswordBox.Size = new System.Drawing.Size(76, 20);
            this.EditPasswordBox.TabIndex = 74;
            this.EditPasswordBox.UseSystemPasswordChar = true;
            // 
            // EditPasswordBox2
            // 
            this.EditPasswordBox2.Location = new System.Drawing.Point(134, 652);
            this.EditPasswordBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditPasswordBox2.Name = "EditPasswordBox2";
            this.EditPasswordBox2.Size = new System.Drawing.Size(76, 20);
            this.EditPasswordBox2.TabIndex = 75;
            this.EditPasswordBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 609);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "New Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 631);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "New Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 654);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Re-enter Password";
            // 
            // GetLoginCredentialsButton
            // 
            this.GetLoginCredentialsButton.Location = new System.Drawing.Point(26, 574);
            this.GetLoginCredentialsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetLoginCredentialsButton.Name = "GetLoginCredentialsButton";
            this.GetLoginCredentialsButton.Size = new System.Drawing.Size(116, 26);
            this.GetLoginCredentialsButton.TabIndex = 79;
            this.GetLoginCredentialsButton.Text = "Get Login Credentials";
            this.GetLoginCredentialsButton.UseVisualStyleBackColor = true;
            this.GetLoginCredentialsButton.Click += new System.EventHandler(this.GetLoginCredentialsButton_Click);
            // 
            // EditSelectedCredentialButton
            // 
            this.EditSelectedCredentialButton.Location = new System.Drawing.Point(153, 574);
            this.EditSelectedCredentialButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditSelectedCredentialButton.Name = "EditSelectedCredentialButton";
            this.EditSelectedCredentialButton.Size = new System.Drawing.Size(130, 26);
            this.EditSelectedCredentialButton.TabIndex = 80;
            this.EditSelectedCredentialButton.Text = "Edit Selected Credential";
            this.EditSelectedCredentialButton.UseVisualStyleBackColor = true;
            this.EditSelectedCredentialButton.Click += new System.EventHandler(this.EditSelectedCredentialButton_Click);
            // 
            // EditCredentialsSaveButton
            // 
            this.EditCredentialsSaveButton.Location = new System.Drawing.Point(227, 648);
            this.EditCredentialsSaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditCredentialsSaveButton.Name = "EditCredentialsSaveButton";
            this.EditCredentialsSaveButton.Size = new System.Drawing.Size(95, 26);
            this.EditCredentialsSaveButton.TabIndex = 81;
            this.EditCredentialsSaveButton.Text = "Save Changes";
            this.EditCredentialsSaveButton.UseVisualStyleBackColor = true;
            this.EditCredentialsSaveButton.Click += new System.EventHandler(this.EditCredentialsSaveButton_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(9, 340);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(488, 2);
            this.label7.TabIndex = 82;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(501, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 650);
            this.label8.TabIndex = 83;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(400, 236);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(79, 13);
            this.DateOfBirthLabel.TabIndex = 84;
            this.DateOfBirthLabel.Text = "MM/DD/YYYY";
            // 
            // btnAddParts
            // 
            this.btnAddParts.Location = new System.Drawing.Point(820, 648);
            this.btnAddParts.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddParts.Name = "btnAddParts";
            this.btnAddParts.Size = new System.Drawing.Size(94, 28);
            this.btnAddParts.TabIndex = 85;
            this.btnAddParts.Text = "Add Parts";
            this.btnAddParts.UseVisualStyleBackColor = true;
            this.btnAddParts.Click += new System.EventHandler(this.btnAddParts_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(573, 652);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 24);
            this.label9.TabIndex = 86;
            this.label9.Text = "Add New Bike Parts";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(507, 630);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(488, 2);
            this.label10.TabIndex = 87;
            // 
            // AdminBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 702);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddParts);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EditCredentialsSaveButton);
            this.Controls.Add(this.EditSelectedCredentialButton);
            this.Controls.Add(this.GetLoginCredentialsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditPasswordBox2);
            this.Controls.Add(this.EditPasswordBox);
            this.Controls.Add(this.EditUsernameBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.EditLoginCredsLabel);
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
        private System.Windows.Forms.Label EditLoginCredsLabel;
        private System.Windows.Forms.ListBox LoginBox;
        private System.Windows.Forms.TextBox EditUsernameBox;
        private System.Windows.Forms.TextBox EditPasswordBox;
        private System.Windows.Forms.TextBox EditPasswordBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GetLoginCredentialsButton;
        private System.Windows.Forms.Button EditSelectedCredentialButton;
        private System.Windows.Forms.Button EditCredentialsSaveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Button btnAddParts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}