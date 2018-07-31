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
            this.btnRemoveTag = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.txtSearchFriends = new System.Windows.Forms.TextBox();
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFriendsTop5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMyTopFivePie
            // 
            this.panelMyTopFivePie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMyTopFivePie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.panelMyTopFivePie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMyTopFivePie.Location = new System.Drawing.Point(289, 72);
            this.panelMyTopFivePie.Name = "panelMyTopFivePie";
            this.panelMyTopFivePie.Size = new System.Drawing.Size(276, 433);
            this.panelMyTopFivePie.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
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
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lavender;
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
            this.lstMyArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.lstMyArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMyArtists.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstMyArtists.FormattingEnabled = true;
            this.lstMyArtists.Location = new System.Drawing.Point(24, 72);
            this.lstMyArtists.Name = "lstMyArtists";
            this.lstMyArtists.Size = new System.Drawing.Size(248, 236);
            this.lstMyArtists.TabIndex = 11;
            this.lstMyArtists.Click += new System.EventHandler(this.lstMyArtists_Click);
            this.lstMyArtists.DoubleClick += new System.EventHandler(this.lstMyArtists_DoubleClick);
            this.lstMyArtists.MouseEnter += new System.EventHandler(this.lstMyArtists_MouseEnter);
            this.lstMyArtists.MouseLeave += new System.EventHandler(this.lstMyArtists_MouseLeave);
            // 
            // txtSearchArtists
            // 
            this.txtSearchArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
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
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(21, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Search List";
            // 
            // lblArtistListHeader
            // 
            this.lblArtistListHeader.BackColor = System.Drawing.Color.Linen;
            this.lblArtistListHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArtistListHeader.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistListHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblArtistListHeader.Location = new System.Drawing.Point(21, 45);
            this.lblArtistListHeader.Name = "lblArtistListHeader";
            this.lblArtistListHeader.Size = new System.Drawing.Size(184, 24);
            this.lblArtistListHeader.TabIndex = 16;
            this.lblArtistListHeader.Text = "Artists I Play";
            this.lblArtistListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.BackColor = System.Drawing.Color.Linen;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(24, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tags I Gave This Artist";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstMyTags
            // 
            this.lstMyTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMyTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.lstMyTags.FormattingEnabled = true;
            this.lstMyTags.Location = new System.Drawing.Point(24, 383);
            this.lstMyTags.Name = "lstMyTags";
            this.lstMyTags.Size = new System.Drawing.Size(248, 121);
            this.lstMyTags.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(289, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "My Top 5 Artists";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Linen;
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
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(595, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 475);
            this.label6.TabIndex = 21;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(603, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "My Friends";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(603, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Trending With Friends";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemoveTag
            // 
            this.btnRemoveTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveTag.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRemoveTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTag.ForeColor = System.Drawing.Color.Maroon;
            this.btnRemoveTag.Location = new System.Drawing.Point(210, 361);
            this.btnRemoveTag.Name = "btnRemoveTag";
            this.btnRemoveTag.Size = new System.Drawing.Size(23, 20);
            this.btnRemoveTag.TabIndex = 24;
            this.btnRemoveTag.Text = "-";
            this.btnRemoveTag.UseVisualStyleBackColor = true;
            this.btnRemoveTag.MouseEnter += new System.EventHandler(this.btnRemoveTag_MouseEnter);
            this.btnRemoveTag.MouseLeave += new System.EventHandler(this.btnRemoveTag_MouseLeave);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddTag.Location = new System.Drawing.Point(239, 358);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(33, 23);
            this.btnAddTag.TabIndex = 25;
            this.btnAddTag.Text = "+";
            this.btnAddTag.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            this.btnAddTag.MouseEnter += new System.EventHandler(this.btnAddTag_MouseEnter);
            this.btnAddTag.MouseLeave += new System.EventHandler(this.btnAddTag_MouseLeave);
            // 
            // txtSearchFriends
            // 
            this.txtSearchFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchFriends.BackColor = System.Drawing.Color.Lavender;
            this.txtSearchFriends.Location = new System.Drawing.Point(687, 235);
            this.txtSearchFriends.Name = "txtSearchFriends";
            this.txtSearchFriends.Size = new System.Drawing.Size(171, 20);
            this.txtSearchFriends.TabIndex = 27;
            this.txtSearchFriends.TextChanged += new System.EventHandler(this.txtSearchFriends_TextChanged);
            // 
            // lstFriends
            // 
            this.lstFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFriends.BackColor = System.Drawing.Color.Lavender;
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.Location = new System.Drawing.Point(606, 72);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(252, 160);
            this.lstFriends.TabIndex = 26;
            this.lstFriends.Click += new System.EventHandler(this.lstFriends_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(603, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Search Friends";
            // 
            // panelFriendsTop5
            // 
            this.panelFriendsTop5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFriendsTop5.BackColor = System.Drawing.Color.Lavender;
            this.panelFriendsTop5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFriendsTop5.Location = new System.Drawing.Point(606, 301);
            this.panelFriendsTop5.Name = "panelFriendsTop5";
            this.panelFriendsTop5.Size = new System.Drawing.Size(252, 203);
            this.panelFriendsTop5.TabIndex = 9;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.panelFriendsTop5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchFriends);
            this.Controls.Add(this.lstFriends);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.btnRemoveTag);
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
        private System.Windows.Forms.Button btnRemoveTag;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox txtSearchFriends;
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFriendsTop5;
    }
}
