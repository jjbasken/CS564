namespace LastFMBrowser.Views
{
    partial class ucBrowseUsers
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
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMyTags = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblArtistListHeader = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchArtists = new System.Windows.Forms.TextBox();
            this.lstMyArtists = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMyTopFivePie = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchFriends = new System.Windows.Forms.TextBox();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddFriend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddFriend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddFriend.Location = new System.Drawing.Point(743, 11);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(114, 23);
            this.btnAddFriend.TabIndex = 37;
            this.btnAddFriend.Text = "Add As Friend";
            this.btnAddFriend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddFriend.UseVisualStyleBackColor = false;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(581, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "My Top 5 Artists";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstMyTags
            // 
            this.lstMyTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMyTags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.lstMyTags.FormattingEnabled = true;
            this.lstMyTags.Location = new System.Drawing.Point(316, 384);
            this.lstMyTags.Name = "lstMyTags";
            this.lstMyTags.Size = new System.Drawing.Size(248, 121);
            this.lstMyTags.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.BackColor = System.Drawing.Color.Linen;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(316, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tags They Gave This Artist";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArtistListHeader
            // 
            this.lblArtistListHeader.BackColor = System.Drawing.Color.Linen;
            this.lblArtistListHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArtistListHeader.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistListHeader.ForeColor = System.Drawing.Color.Navy;
            this.lblArtistListHeader.Location = new System.Drawing.Point(313, 46);
            this.lblArtistListHeader.Name = "lblArtistListHeader";
            this.lblArtistListHeader.Size = new System.Drawing.Size(184, 24);
            this.lblArtistListHeader.TabIndex = 31;
            this.lblArtistListHeader.Text = "Artists They Play";
            this.lblArtistListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(313, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Search List";
            // 
            // txtSearchArtists
            // 
            this.txtSearchArtists.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.txtSearchArtists.Location = new System.Drawing.Point(379, 318);
            this.txtSearchArtists.Name = "txtSearchArtists";
            this.txtSearchArtists.Size = new System.Drawing.Size(185, 20);
            this.txtSearchArtists.TabIndex = 29;
            this.txtSearchArtists.TextChanged += new System.EventHandler(this.txtSearchArtists_TextChanged);
            // 
            // lstMyArtists
            // 
            this.lstMyArtists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMyArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.lstMyArtists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMyArtists.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstMyArtists.ForeColor = System.Drawing.Color.Black;
            this.lstMyArtists.FormattingEnabled = true;
            this.lstMyArtists.Location = new System.Drawing.Point(316, 73);
            this.lstMyArtists.Name = "lstMyArtists";
            this.lstMyArtists.Size = new System.Drawing.Size(248, 236);
            this.lstMyArtists.TabIndex = 28;
            this.lstMyArtists.Click += new System.EventHandler(this.lstMyArtists_Click);
            this.lstMyArtists.DoubleClick += new System.EventHandler(this.lstMyArtists_DoubleClick);
            this.lstMyArtists.MouseEnter += new System.EventHandler(this.lstMyArtists_MouseEnter);
            this.lstMyArtists.MouseLeave += new System.EventHandler(this.lstMyArtists_MouseLeave);
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
            this.label7.Location = new System.Drawing.Point(307, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(564, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Users Artists";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMyTopFivePie
            // 
            this.panelMyTopFivePie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMyTopFivePie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(221)))), ((int)(((byte)(191)))));
            this.panelMyTopFivePie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMyTopFivePie.Location = new System.Drawing.Point(581, 73);
            this.panelMyTopFivePie.Name = "panelMyTopFivePie";
            this.panelMyTopFivePie.Size = new System.Drawing.Size(276, 433);
            this.panelMyTopFivePie.TabIndex = 26;
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
            this.label5.Location = new System.Drawing.Point(307, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 475);
            this.label5.TabIndex = 35;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(20, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Search Friends";
            // 
            // txtSearchFriends
            // 
            this.txtSearchFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearchFriends.BackColor = System.Drawing.Color.Lavender;
            this.txtSearchFriends.Location = new System.Drawing.Point(104, 485);
            this.txtSearchFriends.Name = "txtSearchFriends";
            this.txtSearchFriends.Size = new System.Drawing.Size(171, 20);
            this.txtSearchFriends.TabIndex = 42;
            this.txtSearchFriends.TextChanged += new System.EventHandler(this.txtSearchFriends_TextChanged);
            // 
            // lstUsers
            // 
            this.lstUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstUsers.BackColor = System.Drawing.Color.Lavender;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(23, 73);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(252, 407);
            this.lstUsers.TabIndex = 41;
            this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "All Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 28);
            this.label8.TabIndex = 38;
            this.label8.Text = "Find Users";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 475);
            this.label6.TabIndex = 39;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucBrowseUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchFriends);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddFriend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstMyTags);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblArtistListHeader);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchArtists);
            this.Controls.Add(this.lstMyArtists);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panelMyTopFivePie);
            this.Controls.Add(this.label5);
            this.Name = "ucBrowseUsers";
            this.Size = new System.Drawing.Size(884, 518);
            this.Load += new System.EventHandler(this.ucBrowseUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFriend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstMyTags;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblArtistListHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearchArtists;
        private System.Windows.Forms.ListBox lstMyArtists;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMyTopFivePie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchFriends;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}
