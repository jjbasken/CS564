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
            this.SwapPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NavPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NavPanel.BackColor = System.Drawing.Color.White;
            this.NavPanel.Controls.Add(this.button1);
            this.NavPanel.Controls.Add(this.button2);
            this.NavPanel.Location = new System.Drawing.Point(3, 71);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(200, 518);
            this.NavPanel.TabIndex = 0;
            // 
            // SwapPanel
            // 
            this.SwapPanel.BackColor = System.Drawing.Color.White;
            this.SwapPanel.Location = new System.Drawing.Point(209, 71);
            this.SwapPanel.Name = "SwapPanel";
            this.SwapPanel.Size = new System.Drawing.Size(884, 518);
            this.SwapPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1093, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LastFM Browser";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFooter.BackColor = System.Drawing.Color.White;
            this.lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFooter.Location = new System.Drawing.Point(0, 592);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(1093, 21);
            this.lblFooter.TabIndex = 2;
            this.lblFooter.Text = "Some sort of status can go down here, controlled by the SwapPanel user control";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Artists";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 613);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblTitle);
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}