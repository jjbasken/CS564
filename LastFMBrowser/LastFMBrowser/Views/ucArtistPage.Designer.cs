namespace LastFMBrowser.Views
{
    partial class ucArtistPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgTopTracks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgTopTags = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgSimilarArtists = new System.Windows.Forms.DataGridView();
            this.dgUserTags = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.lnkArtistHeader = new System.Windows.Forms.LinkLabel();
            this.btnArtistSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgOtherUsers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkUserArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandPictureURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSimilarArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserTags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtherUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkUserArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTopTracks
            // 
            this.dgTopTracks.AllowUserToAddRows = false;
            this.dgTopTracks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgTopTracks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTopTracks.AutoGenerateColumns = false;
            this.dgTopTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTopTracks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackTitleDataGridViewTextBoxColumn,
            this.playCountDataGridViewTextBoxColumn,
            this.trackURLDataGridViewTextBoxColumn});
            this.dgTopTracks.DataSource = this.bindingSource1;
            this.dgTopTracks.Location = new System.Drawing.Point(8, 66);
            this.dgTopTracks.Name = "dgTopTracks";
            this.dgTopTracks.ReadOnly = true;
            this.dgTopTracks.RowHeadersVisible = false;
            this.dgTopTracks.Size = new System.Drawing.Size(296, 373);
            this.dgTopTracks.TabIndex = 0;
            this.dgTopTracks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTopTracks_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Tracks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Top Tags";
            // 
            // dgTopTags
            // 
            this.dgTopTags.AllowUserToAddRows = false;
            this.dgTopTags.AllowUserToDeleteRows = false;
            this.dgTopTags.AutoGenerateColumns = false;
            this.dgTopTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTopTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagValueDataGridViewTextBoxColumn});
            this.dgTopTags.DataSource = this.tblTagBindingSource;
            this.dgTopTags.Location = new System.Drawing.Point(321, 250);
            this.dgTopTags.Name = "dgTopTags";
            this.dgTopTags.ReadOnly = true;
            this.dgTopTags.RowHeadersVisible = false;
            this.dgTopTags.Size = new System.Drawing.Size(106, 189);
            this.dgTopTags.TabIndex = 3;
            this.dgTopTags.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTopTags_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Similar Artists";
            // 
            // dgSimilarArtists
            // 
            this.dgSimilarArtists.AllowUserToAddRows = false;
            this.dgSimilarArtists.AllowUserToDeleteRows = false;
            this.dgSimilarArtists.AutoGenerateColumns = false;
            this.dgSimilarArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSimilarArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn,
            this.bandURLDataGridViewTextBoxColumn,
            this.bandPictureURLDataGridViewTextBoxColumn});
            this.dgSimilarArtists.DataSource = this.tblArtistBindingSource;
            this.dgSimilarArtists.Location = new System.Drawing.Point(451, 52);
            this.dgSimilarArtists.Name = "dgSimilarArtists";
            this.dgSimilarArtists.ReadOnly = true;
            this.dgSimilarArtists.RowHeadersVisible = false;
            this.dgSimilarArtists.Size = new System.Drawing.Size(169, 387);
            this.dgSimilarArtists.TabIndex = 5;
            this.dgSimilarArtists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSimilarArtists_CellContentClick);
            // 
            // dgUserTags
            // 
            this.dgUserTags.AllowUserToAddRows = false;
            this.dgUserTags.AllowUserToDeleteRows = false;
            this.dgUserTags.AutoGenerateColumns = false;
            this.dgUserTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.tagValueDataGridViewTextBoxColumn1});
            this.dgUserTags.DataSource = this.tblTagBindingSource;
            this.dgUserTags.Location = new System.Drawing.Point(321, 76);
            this.dgUserTags.Name = "dgUserTags";
            this.dgUserTags.RowHeadersVisible = false;
            this.dgUserTags.Size = new System.Drawing.Size(106, 155);
            this.dgUserTags.TabIndex = 6;
            this.dgUserTags.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUserTags_CellContentClick);
            this.dgUserTags.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTagKeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Your tags";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(321, 52);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(106, 23);
            this.btnAddTag.TabIndex = 9;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // lnkArtistHeader
            // 
            this.lnkArtistHeader.AutoSize = true;
            this.lnkArtistHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkArtistHeader.Location = new System.Drawing.Point(4, 15);
            this.lnkArtistHeader.Name = "lnkArtistHeader";
            this.lnkArtistHeader.Size = new System.Drawing.Size(90, 20);
            this.lnkArtistHeader.TabIndex = 10;
            this.lnkArtistHeader.TabStop = true;
            this.lnkArtistHeader.Text = "linkLabel1";
            this.lnkArtistHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ArtistHeader_LinkClicked);
            // 
            // btnArtistSearch
            // 
            this.btnArtistSearch.Location = new System.Drawing.Point(8, 446);
            this.btnArtistSearch.Name = "btnArtistSearch";
            this.btnArtistSearch.Size = new System.Drawing.Size(86, 23);
            this.btnArtistSearch.TabIndex = 11;
            this.btnArtistSearch.Text = "Artist Search";
            this.btnArtistSearch.UseVisualStyleBackColor = true;
            this.btnArtistSearch.Click += new System.EventHandler(this.btnArtistSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Other users who listen to this artist";
            // 
            // dgOtherUsers
            // 
            this.dgOtherUsers.AllowUserToAddRows = false;
            this.dgOtherUsers.AllowUserToDeleteRows = false;
            this.dgOtherUsers.AutoGenerateColumns = false;
            this.dgOtherUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOtherUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn});
            this.dgOtherUsers.DataSource = this.lnkUserArtistBindingSource;
            this.dgOtherUsers.Location = new System.Drawing.Point(626, 52);
            this.dgOtherUsers.Name = "dgOtherUsers";
            this.dgOtherUsers.ReadOnly = true;
            this.dgOtherUsers.RowHeadersVisible = false;
            this.dgOtherUsers.Size = new System.Drawing.Size(164, 303);
            this.dgOtherUsers.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tag Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lnkUserArtistBindingSource
            // 
            this.lnkUserArtistBindingSource.DataSource = typeof(LastFMBrowser.Models.lnkUserArtist);
            // 
            // tblTagBindingSource
            // 
            this.tblTagBindingSource.DataSource = typeof(LastFMBrowser.Models.tblTag);
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            this.artistIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            this.artistNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bandURLDataGridViewTextBoxColumn
            // 
            this.bandURLDataGridViewTextBoxColumn.DataPropertyName = "BandURL";
            this.bandURLDataGridViewTextBoxColumn.HeaderText = "BandURL";
            this.bandURLDataGridViewTextBoxColumn.Name = "bandURLDataGridViewTextBoxColumn";
            this.bandURLDataGridViewTextBoxColumn.ReadOnly = true;
            this.bandURLDataGridViewTextBoxColumn.Visible = false;
            // 
            // bandPictureURLDataGridViewTextBoxColumn
            // 
            this.bandPictureURLDataGridViewTextBoxColumn.DataPropertyName = "BandPictureURL";
            this.bandPictureURLDataGridViewTextBoxColumn.HeaderText = "BandPictureURL";
            this.bandPictureURLDataGridViewTextBoxColumn.Name = "bandPictureURLDataGridViewTextBoxColumn";
            this.bandPictureURLDataGridViewTextBoxColumn.ReadOnly = true;
            this.bandPictureURLDataGridViewTextBoxColumn.Visible = false;
            // 
            // tblArtistBindingSource
            // 
            this.tblArtistBindingSource.DataSource = typeof(LastFMBrowser.Models.tblArtist);
            // 
            // tagValueDataGridViewTextBoxColumn
            // 
            this.tagValueDataGridViewTextBoxColumn.DataPropertyName = "tagValue";
            this.tagValueDataGridViewTextBoxColumn.HeaderText = "tagValue";
            this.tagValueDataGridViewTextBoxColumn.Name = "tagValueDataGridViewTextBoxColumn";
            this.tagValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackTitleDataGridViewTextBoxColumn
            // 
            this.trackTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.trackTitleDataGridViewTextBoxColumn.DataPropertyName = "TrackTitle";
            this.trackTitleDataGridViewTextBoxColumn.HeaderText = "TrackTitle";
            this.trackTitleDataGridViewTextBoxColumn.Name = "trackTitleDataGridViewTextBoxColumn";
            this.trackTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackTitleDataGridViewTextBoxColumn.Width = 5;
            // 
            // playCountDataGridViewTextBoxColumn
            // 
            this.playCountDataGridViewTextBoxColumn.DataPropertyName = "PlayCount";
            this.playCountDataGridViewTextBoxColumn.HeaderText = "PlayCount";
            this.playCountDataGridViewTextBoxColumn.Name = "playCountDataGridViewTextBoxColumn";
            this.playCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trackURLDataGridViewTextBoxColumn
            // 
            this.trackURLDataGridViewTextBoxColumn.DataPropertyName = "TrackURL";
            this.trackURLDataGridViewTextBoxColumn.HeaderText = "TrackURL";
            this.trackURLDataGridViewTextBoxColumn.Name = "trackURLDataGridViewTextBoxColumn";
            this.trackURLDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackURLDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LastFMBrowser.Models.tblTrack);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataSource = typeof(LastFMBrowser.Models.tblUser);
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "tagID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "tagID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            this.tagIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.tagIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tagValueDataGridViewTextBoxColumn1
            // 
            this.tagValueDataGridViewTextBoxColumn1.DataPropertyName = "tagValue";
            this.tagValueDataGridViewTextBoxColumn1.HeaderText = "tagValue";
            this.tagValueDataGridViewTextBoxColumn1.Name = "tagValueDataGridViewTextBoxColumn1";
            this.tagValueDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ucArtistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgOtherUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnArtistSearch);
            this.Controls.Add(this.lnkArtistHeader);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgUserTags);
            this.Controls.Add(this.dgSimilarArtists);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgTopTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTopTracks);
            this.Name = "ucArtistPage";
            this.Size = new System.Drawing.Size(884, 518);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgTopTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTopTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSimilarArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserTags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOtherUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkUserArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTopTracks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgTopTags;
        private System.Windows.Forms.BindingSource tblTagBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgSimilarArtists;
        private System.Windows.Forms.BindingSource tblArtistBindingSource;
        private System.Windows.Forms.DataGridView dgUserTags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel lnkArtistHeader;
        private System.Windows.Forms.Button btnArtistSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgOtherUsers;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lnkUserArtistBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandPictureURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagValueDataGridViewTextBoxColumn1;
    }
}
