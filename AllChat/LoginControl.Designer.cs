namespace AllChat
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewUser = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblInvalid1 = new System.Windows.Forms.Label();
            this.lblInvalid2 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblRegisterInvalid2 = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterInvalid1 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblAlready = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTaken = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewUser.Location = new System.Drawing.Point(157, 32);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(92, 16);
            this.lblNewUser.TabIndex = 15;
            this.lblNewUser.Text = "Register here.";
            this.lblNewUser.Click += new System.EventHandler(this.lblNewUser_Click);
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNew.Location = new System.Drawing.Point(89, 32);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(71, 16);
            this.lblNew.TabIndex = 14;
            this.lblNew.Text = "New user?";
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(50, 12);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(229, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Sign in to your AllChat account:";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(117, 138);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(102, 96);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(102, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 73);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 8;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblInvalid1
            // 
            this.lblInvalid1.AutoSize = true;
            this.lblInvalid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid1.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid1.Location = new System.Drawing.Point(8, 164);
            this.lblInvalid1.Name = "lblInvalid1";
            this.lblInvalid1.Size = new System.Drawing.Size(0, 15);
            this.lblInvalid1.TabIndex = 16;
            this.lblInvalid1.Click += new System.EventHandler(this.lblInvalid1_Click);
            // 
            // lblInvalid2
            // 
            this.lblInvalid2.AutoSize = true;
            this.lblInvalid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid2.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid2.Location = new System.Drawing.Point(38, 179);
            this.lblInvalid2.Name = "lblInvalid2";
            this.lblInvalid2.Size = new System.Drawing.Size(0, 15);
            this.lblInvalid2.TabIndex = 17;
            this.lblInvalid2.Click += new System.EventHandler(this.lblInvalid2_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblDescription);
            this.pnlLogin.Controls.Add(this.lblInvalid2);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblInvalid1);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblNewUser);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblNew);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(3, 3);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(314, 209);
            this.pnlLogin.TabIndex = 18;
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.lblTaken);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.lblRegisterInvalid2);
            this.pnlRegister.Controls.Add(this.txtNewUsername);
            this.pnlRegister.Controls.Add(this.lblRegisterInvalid1);
            this.pnlRegister.Controls.Add(this.txtNewPassword);
            this.pnlRegister.Controls.Add(this.lblLogin);
            this.pnlRegister.Controls.Add(this.lblNewUsername);
            this.pnlRegister.Controls.Add(this.lblAlready);
            this.pnlRegister.Controls.Add(this.lblNewPassword);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Location = new System.Drawing.Point(3, 4);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(346, 209);
            this.pnlRegister.TabIndex = 19;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(48, 11);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(235, 20);
            this.lblRegister.TabIndex = 23;
            this.lblRegister.Text = "Register a new AllChat account:";
            // 
            // lblRegisterInvalid2
            // 
            this.lblRegisterInvalid2.AutoSize = true;
            this.lblRegisterInvalid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterInvalid2.ForeColor = System.Drawing.Color.Red;
            this.lblRegisterInvalid2.Location = new System.Drawing.Point(38, 178);
            this.lblRegisterInvalid2.Name = "lblRegisterInvalid2";
            this.lblRegisterInvalid2.Size = new System.Drawing.Size(0, 15);
            this.lblRegisterInvalid2.TabIndex = 27;
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(105, 72);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(100, 20);
            this.txtNewUsername.TabIndex = 18;
            // 
            // lblRegisterInvalid1
            // 
            this.lblRegisterInvalid1.AutoSize = true;
            this.lblRegisterInvalid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterInvalid1.ForeColor = System.Drawing.Color.Red;
            this.lblRegisterInvalid1.Location = new System.Drawing.Point(8, 163);
            this.lblRegisterInvalid1.Name = "lblRegisterInvalid1";
            this.lblRegisterInvalid1.Size = new System.Drawing.Size(0, 15);
            this.lblRegisterInvalid1.TabIndex = 26;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(105, 111);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 19;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(208, 31);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(74, 16);
            this.lblLogin.TabIndex = 25;
            this.lblLogin.Text = "Login here.";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(102, 56);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(58, 13);
            this.lblNewUsername.TabIndex = 20;
            this.lblNewUsername.Text = "Username:";
            // 
            // lblAlready
            // 
            this.lblAlready.AutoSize = true;
            this.lblAlready.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlready.Location = new System.Drawing.Point(51, 31);
            this.lblAlready.Name = "lblAlready";
            this.lblAlready.Size = new System.Drawing.Size(163, 16);
            this.lblAlready.TabIndex = 24;
            this.lblAlready.Text = "Already have an account?";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(102, 95);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(56, 13);
            this.lblNewPassword.TabIndex = 21;
            this.lblNewPassword.Text = "Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(117, 137);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTaken
            // 
            this.lblTaken.AutoSize = true;
            this.lblTaken.ForeColor = System.Drawing.Color.Red;
            this.lblTaken.Location = new System.Drawing.Point(207, 75);
            this.lblTaken.Name = "lblTaken";
            this.lblTaken.Size = new System.Drawing.Size(0, 13);
            this.lblTaken.TabIndex = 28;
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlLogin);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(364, 218);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblInvalid1;
        private System.Windows.Forms.Label lblInvalid2;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblRegisterInvalid2;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblRegisterInvalid1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblAlready;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTaken;
    }
}
