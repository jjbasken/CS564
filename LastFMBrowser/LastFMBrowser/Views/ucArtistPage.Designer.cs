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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ArtistHeader = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OtherUserGrid = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkUserArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherUserGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkUserArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackTitleDataGridViewTextBoxColumn,
            this.playCountDataGridViewTextBoxColumn,
            this.trackURLDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(296, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagValueDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblTagBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(321, 250);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(106, 189);
            this.dataGridView2.TabIndex = 3;
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn,
            this.bandURLDataGridViewTextBoxColumn,
            this.bandPictureURLDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tblArtistBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(451, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(105, 387);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.tagValueDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.tblTagBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(321, 76);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(106, 155);
            this.dataGridView4.TabIndex = 6;
            this.dataGridView4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTagKeyDown);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Tag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ArtistHeader
            // 
            this.ArtistHeader.AutoSize = true;
            this.ArtistHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistHeader.Location = new System.Drawing.Point(4, 15);
            this.ArtistHeader.Name = "ArtistHeader";
            this.ArtistHeader.Size = new System.Drawing.Size(90, 20);
            this.ArtistHeader.TabIndex = 10;
            this.ArtistHeader.TabStop = true;
            this.ArtistHeader.Text = "linkLabel1";
            this.ArtistHeader.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ArtistHeader_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Artist Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Other users who listen to this artist";
            // 
            // OtherUserGrid
            // 
            this.OtherUserGrid.AllowUserToAddRows = false;
            this.OtherUserGrid.AllowUserToDeleteRows = false;
            this.OtherUserGrid.AutoGenerateColumns = false;
            this.OtherUserGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherUserGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn});
            this.OtherUserGrid.DataSource = this.lnkUserArtistBindingSource;
            this.OtherUserGrid.Location = new System.Drawing.Point(575, 52);
            this.OtherUserGrid.Name = "OtherUserGrid";
            this.OtherUserGrid.ReadOnly = true;
            this.OtherUserGrid.RowHeadersVisible = false;
            this.OtherUserGrid.Size = new System.Drawing.Size(164, 303);
            this.OtherUserGrid.TabIndex = 13;
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
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
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
            // ucArtistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.Controls.Add(this.OtherUserGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ArtistHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ucArtistPage";
            this.Size = new System.Drawing.Size(884, 518);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtherUserGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnkUserArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tblTagBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandPictureURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblArtistBindingSource;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel ArtistHeader;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView OtherUserGrid;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lnkUserArtistBindingSource;
    }
}
