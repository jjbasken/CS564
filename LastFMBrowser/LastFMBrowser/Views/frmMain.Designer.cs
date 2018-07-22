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
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lblIcon = new System.Windows.Forms.Label();
            this.btnUCMin = new System.Windows.Forms.Button();
            this.SwapPanel = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.NavPanel.Location = new System.Drawing.Point(3, 74);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(195, 539);
            this.NavPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(887, 71);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.IsSplitterFixed = true;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Margin = new System.Windows.Forms.Padding(0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.lblIcon);
            this.splitMain.Panel1.Controls.Add(this.NavPanel);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.lblFooter);
            this.splitMain.Panel2.Controls.Add(this.btnUCMin);
            this.splitMain.Panel2.Controls.Add(this.lblTitle);
            this.splitMain.Panel2.Controls.Add(this.SwapPanel);
            this.splitMain.Size = new System.Drawing.Size(1084, 613);
            this.splitMain.SplitterDistance = 200;
            this.splitMain.SplitterWidth = 1;
            this.splitMain.TabIndex = 5;
            // 
            // lblIcon
            // 
            this.lblIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblIcon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(210)))));
            this.lblIcon.Location = new System.Drawing.Point(3, 0);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(195, 71);
            this.lblIcon.TabIndex = 5;
            this.lblIcon.Text = "BrowseFM";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUCMin
            // 
            this.btnUCMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.btnUCMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUCMin.FlatAppearance.BorderSize = 0;
            this.btnUCMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnUCMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUCMin.Location = new System.Drawing.Point(0, 0);
            this.btnUCMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnUCMin.Name = "btnUCMin";
            this.btnUCMin.Size = new System.Drawing.Size(16, 19);
            this.btnUCMin.TabIndex = 90;
            this.btnUCMin.Text = "<";
            this.btnUCMin.UseVisualStyleBackColor = false;
            this.btnUCMin.Click += new System.EventHandler(this.btnUCMin_Click);
            // 
            // SwapPanel
            // 
            this.SwapPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwapPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.SwapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SwapPanel.Location = new System.Drawing.Point(0, 71);
            this.SwapPanel.Name = "SwapPanel";
            this.SwapPanel.Size = new System.Drawing.Size(884, 518);
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
            this.lblFooter.Size = new System.Drawing.Size(884, 21);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = ". . .";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 615);
            this.Controls.Add(this.splitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "Lose yourself in the music";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel NavPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel SwapPanel;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnUCMin;
    }
}