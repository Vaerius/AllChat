namespace AllChat
{
    partial class frmMain
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
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.loginControl1 = new AllChat.ucLogin();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.tmiAbout});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(564, 24);
            this.mnsMain.TabIndex = 0;
            this.mnsMain.Text = "Mainmenu";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiLogin,
            this.tmiRegister,
            this.tmiExit});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // tmiLogin
            // 
            this.tmiLogin.Name = "tmiLogin";
            this.tmiLogin.Size = new System.Drawing.Size(116, 22);
            this.tmiLogin.Text = "Login";
            // 
            // tmiRegister
            // 
            this.tmiRegister.Name = "tmiRegister";
            this.tmiRegister.Size = new System.Drawing.Size(116, 22);
            this.tmiRegister.Text = "Register";
            // 
            // tmiExit
            // 
            this.tmiExit.Name = "tmiExit";
            this.tmiExit.Size = new System.Drawing.Size(116, 22);
            this.tmiExit.Text = "Exit";
            this.tmiExit.Click += new System.EventHandler(this.tmiExit_Click);
            // 
            // tmiAbout
            // 
            this.tmiAbout.Name = "tmiAbout";
            this.tmiAbout.Size = new System.Drawing.Size(52, 20);
            this.tmiAbout.Text = "About";
            // 
            // loginControl1
            // 
            this.loginControl1.Location = new System.Drawing.Point(118, 113);
            this.loginControl1.Name = "loginControl1";
            this.loginControl1.Size = new System.Drawing.Size(316, 211);
            this.loginControl1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 440);
            this.Controls.Add(this.loginControl1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "AllChat™";
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmiLogin;
        private System.Windows.Forms.ToolStripMenuItem tmiExit;
        private System.Windows.Forms.ToolStripMenuItem tmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tmiRegister;
        private ucLogin loginControl1;
    }
}

