namespace AllChat
{
    partial class MainScreenControl
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
            this.pnlAccounts = new System.Windows.Forms.Panel();
            this.pnlChat = new System.Windows.Forms.Panel();
            this.lblChat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlAccounts
            // 
            this.pnlAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccounts.AutoScroll = true;
            this.pnlAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccounts.Location = new System.Drawing.Point(13, 23);
            this.pnlAccounts.Name = "pnlAccounts";
            this.pnlAccounts.Size = new System.Drawing.Size(174, 396);
            this.pnlAccounts.TabIndex = 0;
            // 
            // pnlChat
            // 
            this.pnlChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChat.Location = new System.Drawing.Point(193, 23);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.Size = new System.Drawing.Size(419, 396);
            this.pnlChat.TabIndex = 1;
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChat.Location = new System.Drawing.Point(11, 8);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(75, 16);
            this.lblChat.TabIndex = 0;
            this.lblChat.Text = "Messages:";
            // 
            // MainScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlChat);
            this.Controls.Add(this.pnlAccounts);
            this.Controls.Add(this.lblChat);
            this.Name = "MainScreenControl";
            this.Size = new System.Drawing.Size(627, 422);
            this.Load += new System.EventHandler(this.MainScreenControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccounts;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Panel pnlChat;
    }
}
