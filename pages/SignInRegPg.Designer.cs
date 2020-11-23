namespace CSE412_Group17
{
    partial class SignInRegPg
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
            this.lblLoginMessage = new System.Windows.Forms.Label();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.lblRegisterMessage = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblPasswordDisplay = new System.Windows.Forms.Label();
            this.lblNewUsernameDisplay = new System.Windows.Forms.Label();
            this.lblNewPasswordDisplay = new System.Windows.Forms.Label();
            this.SignInAsAdminBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMessage.Location = new System.Drawing.Point(511, 352);
            this.lblLoginMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(295, 25);
            this.lblLoginMessage.TabIndex = 18;
            this.lblLoginMessage.Text = "Existing members, login here.";
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Location = new System.Drawing.Point(516, 52);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(424, 71);
            this.btnHomePage.TabIndex = 21;
            this.btnHomePage.Text = "Store Name";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // lblRegisterMessage
            // 
            this.lblRegisterMessage.AutoSize = true;
            this.lblRegisterMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterMessage.Location = new System.Drawing.Point(511, 562);
            this.lblRegisterMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegisterMessage.Name = "lblRegisterMessage";
            this.lblRegisterMessage.Size = new System.Drawing.Size(368, 25);
            this.lblRegisterMessage.TabIndex = 22;
            this.lblRegisterMessage.Text = "Unregistered members, register here.";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(516, 396);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 22);
            this.txtUsername.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(516, 443);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 22);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(516, 485);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(516, 695);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 28;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(516, 654);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(184, 22);
            this.txtNewPassword.TabIndex = 27;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(516, 607);
            this.txtNewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(184, 22);
            this.txtNewUser.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Welcome! Please login or register to access our exclusive online bicycle store.";
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDisplay.Location = new System.Drawing.Point(419, 400);
            this.lblUsernameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(77, 17);
            this.lblUsernameDisplay.TabIndex = 30;
            this.lblUsernameDisplay.Text = "Username:";
            // 
            // lblPasswordDisplay
            // 
            this.lblPasswordDisplay.AutoSize = true;
            this.lblPasswordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDisplay.Location = new System.Drawing.Point(421, 447);
            this.lblPasswordDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordDisplay.Name = "lblPasswordDisplay";
            this.lblPasswordDisplay.Size = new System.Drawing.Size(73, 17);
            this.lblPasswordDisplay.TabIndex = 31;
            this.lblPasswordDisplay.Text = "Password:";
            // 
            // lblNewUsernameDisplay
            // 
            this.lblNewUsernameDisplay.AutoSize = true;
            this.lblNewUsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUsernameDisplay.Location = new System.Drawing.Point(368, 615);
            this.lblNewUsernameDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewUsernameDisplay.Name = "lblNewUsernameDisplay";
            this.lblNewUsernameDisplay.Size = new System.Drawing.Size(127, 17);
            this.lblNewUsernameDisplay.TabIndex = 32;
            this.lblNewUsernameDisplay.Text = "Enter a Username:";
            // 
            // lblNewPasswordDisplay
            // 
            this.lblNewPasswordDisplay.AutoSize = true;
            this.lblNewPasswordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordDisplay.Location = new System.Drawing.Point(368, 662);
            this.lblNewPasswordDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPasswordDisplay.Name = "lblNewPasswordDisplay";
            this.lblNewPasswordDisplay.Size = new System.Drawing.Size(123, 17);
            this.lblNewPasswordDisplay.TabIndex = 33;
            this.lblNewPasswordDisplay.Text = "Enter a Password:";
            // 
            // SignInAsAdminBox
            // 
            this.SignInAsAdminBox.AutoSize = true;
            this.SignInAsAdminBox.Location = new System.Drawing.Point(624, 491);
            this.SignInAsAdminBox.Name = "SignInAsAdminBox";
            this.SignInAsAdminBox.Size = new System.Drawing.Size(132, 21);
            this.SignInAsAdminBox.TabIndex = 34;
            this.SignInAsAdminBox.Text = "Sign In to Admin";
            this.SignInAsAdminBox.UseVisualStyleBackColor = true;
            this.SignInAsAdminBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignInRegPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 864);
            this.Controls.Add(this.SignInAsAdminBox);
            this.Controls.Add(this.lblNewPasswordDisplay);
            this.Controls.Add(this.lblNewUsernameDisplay);
            this.Controls.Add(this.lblPasswordDisplay);
            this.Controls.Add(this.lblUsernameDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRegisterMessage);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.lblLoginMessage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignInRegPg";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.SignInRegPg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLoginMessage;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label lblRegisterMessage;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Label lblPasswordDisplay;
        private System.Windows.Forms.Label lblNewUsernameDisplay;
        private System.Windows.Forms.Label lblNewPasswordDisplay;
        private System.Windows.Forms.CheckBox SignInAsAdminBox;
    }
}