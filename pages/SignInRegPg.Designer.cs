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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsernameDisplay = new System.Windows.Forms.Label();
            this.lblPasswordDisplay = new System.Windows.Forms.Label();
            this.SignInAsAdminBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.AutoSize = true;
            this.lblLoginMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMessage.Location = new System.Drawing.Point(225, 309);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(244, 20);
            this.lblLoginMessage.TabIndex = 18;
            this.lblLoginMessage.Text = "Existing members, login here.";
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Location = new System.Drawing.Point(386, 42);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(318, 58);
            this.btnHomePage.TabIndex = 21;
            this.btnHomePage.Text = "BikeBoss";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // lblRegisterMessage
            // 
            this.lblRegisterMessage.AutoSize = true;
            this.lblRegisterMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterMessage.Location = new System.Drawing.Point(560, 309);
            this.lblRegisterMessage.Name = "lblRegisterMessage";
            this.lblRegisterMessage.Size = new System.Drawing.Size(385, 20);
            this.lblRegisterMessage.TabIndex = 22;
            this.lblRegisterMessage.Text = "Don\'t have an account? Click to register below.";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(229, 345);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 20);
            this.txtUsername.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(229, 383);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 24;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(229, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(712, 417);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 28;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Welcome! Please login to access our exclusive online bicycle store.";
            // 
            // lblUsernameDisplay
            // 
            this.lblUsernameDisplay.AutoSize = true;
            this.lblUsernameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameDisplay.Location = new System.Drawing.Point(156, 348);
            this.lblUsernameDisplay.Name = "lblUsernameDisplay";
            this.lblUsernameDisplay.Size = new System.Drawing.Size(58, 13);
            this.lblUsernameDisplay.TabIndex = 30;
            this.lblUsernameDisplay.Text = "Username:";
            // 
            // lblPasswordDisplay
            // 
            this.lblPasswordDisplay.AutoSize = true;
            this.lblPasswordDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDisplay.Location = new System.Drawing.Point(158, 386);
            this.lblPasswordDisplay.Name = "lblPasswordDisplay";
            this.lblPasswordDisplay.Size = new System.Drawing.Size(56, 13);
            this.lblPasswordDisplay.TabIndex = 31;
            this.lblPasswordDisplay.Text = "Password:";
            // 
            // SignInAsAdminBox
            // 
            this.SignInAsAdminBox.AutoSize = true;
            this.SignInAsAdminBox.Location = new System.Drawing.Point(310, 422);
            this.SignInAsAdminBox.Margin = new System.Windows.Forms.Padding(2);
            this.SignInAsAdminBox.Name = "SignInAsAdminBox";
            this.SignInAsAdminBox.Size = new System.Drawing.Size(103, 17);
            this.SignInAsAdminBox.TabIndex = 34;
            this.SignInAsAdminBox.Text = "Sign In to Admin";
            this.SignInAsAdminBox.UseVisualStyleBackColor = true;
            this.SignInAsAdminBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignInRegPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 702);
            this.Controls.Add(this.SignInAsAdminBox);
            this.Controls.Add(this.lblPasswordDisplay);
            this.Controls.Add(this.lblUsernameDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRegisterMessage);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.lblLoginMessage);
            this.Name = "SignInRegPg";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignInRegPg_FormClosed);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsernameDisplay;
        private System.Windows.Forms.Label lblPasswordDisplay;
        private System.Windows.Forms.CheckBox SignInAsAdminBox;
    }
}