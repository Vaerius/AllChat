namespace AllChat
{
    partial class PersonControl
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
            this.lblPreviewName = new System.Windows.Forms.Label();
            this.lblPreviewTime = new System.Windows.Forms.Label();
            this.lblPreviewText = new System.Windows.Forms.Label();
            this.PreviewRedline = new AllChat.RedLineControl();
            this.SuspendLayout();
            // 
            // lblPreviewName
            // 
            this.lblPreviewName.AutoSize = true;
            this.lblPreviewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewName.ForeColor = System.Drawing.Color.Black;
            this.lblPreviewName.Location = new System.Drawing.Point(14, 3);
            this.lblPreviewName.Name = "lblPreviewName";
            this.lblPreviewName.Size = new System.Drawing.Size(0, 16);
            this.lblPreviewName.TabIndex = 0;
            // 
            // lblPreviewTime
            // 
            this.lblPreviewTime.AutoSize = true;
            this.lblPreviewTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviewTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPreviewTime.Location = new System.Drawing.Point(118, 3);
            this.lblPreviewTime.Name = "lblPreviewTime";
            this.lblPreviewTime.Size = new System.Drawing.Size(0, 15);
            this.lblPreviewTime.TabIndex = 1;
            // 
            // lblPreviewText
            // 
            this.lblPreviewText.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPreviewText.Location = new System.Drawing.Point(14, 24);
            this.lblPreviewText.Name = "lblPreviewText";
            this.lblPreviewText.Size = new System.Drawing.Size(142, 40);
            this.lblPreviewText.TabIndex = 2;
            // 
            // PreviewRedline
            // 
            this.PreviewRedline.Location = new System.Drawing.Point(9, 65);
            this.PreviewRedline.MaximumSize = new System.Drawing.Size(2000, 2);
            this.PreviewRedline.MinimumSize = new System.Drawing.Size(0, 2);
            this.PreviewRedline.Name = "PreviewRedline";
            this.PreviewRedline.Size = new System.Drawing.Size(148, 2);
            this.PreviewRedline.TabIndex = 4;
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.PreviewRedline);
            this.Controls.Add(this.lblPreviewText);
            this.Controls.Add(this.lblPreviewTime);
            this.Controls.Add(this.lblPreviewName);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(166, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviewName;
        private System.Windows.Forms.Label lblPreviewTime;
        private System.Windows.Forms.Label lblPreviewText;
        private RedLineControl PreviewRedline;
    }
}
