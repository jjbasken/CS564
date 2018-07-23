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
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandPictureURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tagValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trackTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(205, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Tracks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 12);
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
            this.dataGridView2.Location = new System.Drawing.Point(216, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(106, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 12);
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
            this.dataGridView3.Location = new System.Drawing.Point(328, 31);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(105, 358);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
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
            // tblTagBindingSource
            // 
            this.tblTagBindingSource.DataSource = typeof(LastFMBrowser.Models.tblTag);
            // 
            // trackTitleDataGridViewTextBoxColumn
            // 
            this.trackTitleDataGridViewTextBoxColumn.DataPropertyName = "TrackTitle";
            this.trackTitleDataGridViewTextBoxColumn.HeaderText = "TrackTitle";
            this.trackTitleDataGridViewTextBoxColumn.Name = "trackTitleDataGridViewTextBoxColumn";
            this.trackTitleDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ucArtistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
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
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackURLDataGridViewTextBoxColumn;
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
    }
}
