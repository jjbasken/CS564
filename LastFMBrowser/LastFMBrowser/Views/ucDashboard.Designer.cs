﻿namespace LastFMBrowser.Views
{
    partial class ucDashboard
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
            this.lblUCHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUCHeader
            // 
            this.lblUCHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUCHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCHeader.Location = new System.Drawing.Point(0, 0);
            this.lblUCHeader.Name = "lblUCHeader";
            this.lblUCHeader.Size = new System.Drawing.Size(881, 60);
            this.lblUCHeader.TabIndex = 0;
            this.lblUCHeader.Text = "User Dashboard";
            this.lblUCHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUCHeader);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(884, 518);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUCHeader;
    }
}
