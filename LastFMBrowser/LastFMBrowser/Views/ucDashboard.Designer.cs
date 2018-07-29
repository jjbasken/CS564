namespace LastFMBrowser.Views
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
            this.components = new System.ComponentModel.Container();
            this.panelMyTopFivePie = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstMyArtists = new System.Windows.Forms.ListBox();
            this.txtSearchArtists = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblArtistListHeader = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstMyTags = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelMyTopFivePie
            // 
            this.panelMyTopFivePie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMyTopFivePie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.panelMyTopFivePie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMyTopFivePie.Location = new System.Drawing.Point(289, 69);
            this.panelMyTopFivePie.Name = "panelMyTopFivePie";
            this.panelMyTopFivePie.Size = new System.Drawing.Size(276, 436);
            this.panelMyTopFivePie.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OldLace;
            this.label7.Location = new System.Drawing.Point(15, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(564, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Artists Corner";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(595, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Friends Corner";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstMyArtists
            // 
            this.lstMyArtists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMyArtists.FormattingEnabled = true;
            this.lstMyArtists.Location = new System.Drawing.Point(24, 72);
            this.lstMyArtists.Name = "lstMyArtists";
            this.lstMyArtists.Size = new System.Drawing.Size(248, 238);
            this.lstMyArtists.TabIndex = 11;
            this.lstMyArtists.Click += new System.EventHandler(this.lstMyArtists_Click);
            this.lstMyArtists.DoubleClick += new System.EventHandler(this.lstMyArtists_DoubleClick);
            // 
            // txtSearchArtists
            // 
            this.txtSearchArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchArtists.Location = new System.Drawing.Point(87, 317);
            this.txtSearchArtists.Name = "txtSearchArtists";
            this.txtSearchArtists.Size = new System.Drawing.Size(185, 20);
            this.txtSearchArtists.TabIndex = 12;
            this.txtSearchArtists.TextChanged += new System.EventHandler(this.txtSearchArtists_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(21, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Search List";
            // 
            // lblArtistListHeader
            // 
            this.lblArtistListHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArtistListHeader.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistListHeader.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblArtistListHeader.Location = new System.Drawing.Point(21, 45);
            this.lblArtistListHeader.Name = "lblArtistListHeader";
            this.lblArtistListHeader.Size = new System.Drawing.Size(184, 24);
            this.lblArtistListHeader.TabIndex = 16;
            this.lblArtistListHeader.Text = "Artists I Play";
            this.lblArtistListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(24, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tags I Gave This Artist";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstMyTags
            // 
            this.lstMyTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMyTags.FormattingEnabled = true;
            this.lstMyTags.Location = new System.Drawing.Point(24, 383);
            this.lstMyTags.Name = "lstMyTags";
            this.lstMyTags.Size = new System.Drawing.Size(248, 121);
            this.lstMyTags.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(289, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "My Top 5 Artists";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 475);
            this.label5.TabIndex = 20;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(210)))), ((int)(((byte)(191)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(595, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 475);
            this.label6.TabIndex = 21;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(617, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "My Friends";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(617, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Trending With Friends";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstMyTags);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblArtistListHeader);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchArtists);
            this.Controls.Add(this.lstMyArtists);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelMyTopFivePie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(884, 518);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private uctrlTop5ArtistChart uctrlTop5ArtistChart1;
        private System.Windows.Forms.Panel panelMyTopFivePie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstMyArtists;
        private System.Windows.Forms.TextBox txtSearchArtists;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblArtistListHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstMyTags;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
