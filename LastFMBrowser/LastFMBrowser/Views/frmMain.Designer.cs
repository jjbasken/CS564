namespace LastFMBrowser.Views
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
            this.NavPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnArtist = new System.Windows.Forms.Button();
            this.SwapPanel = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NavPanel.Controls.Add(this.lblIcon);
            this.NavPanel.Controls.Add(this.btnDashboard);
            this.NavPanel.Controls.Add(this.btnArtist);
            this.NavPanel.Location = new System.Drawing.Point(3, 0);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(195, 589);
            this.NavPanel.TabIndex = 0;
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblIcon.Location = new System.Drawing.Point(3, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(195, 71);
            this.lblIcon.TabIndex = 2;
            this.lblIcon.Text = "BrowseFM";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoEllipsis = true;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(230)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btnDashboard.Location = new System.Drawing.Point(2, 71);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 1);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(191, 41);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnArtist
            // 
            this.btnArtist.AutoEllipsis = true;
            this.btnArtist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(197)))), ((int)(((byte)(236)))));
            this.btnArtist.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnArtist.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.btnArtist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(230)))));
            this.btnArtist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtist.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.btnArtist.Location = new System.Drawing.Point(2, 114);
            this.btnArtist.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(191, 41);
            this.btnArtist.TabIndex = 1;
            this.btnArtist.Text = "Artists";
            this.btnArtist.UseVisualStyleBackColor = false;
            this.btnArtist.Click += new System.EventHandler(this.btnArtist_Click);
            // 
            // SwapPanel
            // 
            this.SwapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwapPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.SwapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwapPanel.Location = new System.Drawing.Point(201, 71);
            this.SwapPanel.Name = "SwapPanel";
            this.SwapPanel.Size = new System.Drawing.Size(888, 518);
            this.SwapPanel.TabIndex = 1;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(94)))), ((int)(((byte)(81)))));
            this.lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(179)))), ((int)(((byte)(160)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 592);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1093, 21);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = ". . .";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.lblTitle.Location = new System.Drawing.Point(201, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(888, 71);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 613);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.SwapPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "frmMain";
            this.Text = "Lose yourself in the music";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.NavPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel NavPanel;
        private System.Windows.Forms.Panel SwapPanel;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIcon;
    }
}