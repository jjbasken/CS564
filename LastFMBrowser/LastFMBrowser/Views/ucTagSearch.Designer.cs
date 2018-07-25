namespace LastFMBrowser.Views
{
    partial class ucTagSearch
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
            this.txtSearchField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgArtists = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandPictureURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblArtistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchField
            // 
            this.txtSearchField.Location = new System.Drawing.Point(28, 28);
            this.txtSearchField.Name = "txtSearchField";
            this.txtSearchField.Size = new System.Drawing.Size(151, 20);
            this.txtSearchField.TabIndex = 0;
            this.txtSearchField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter tag search and hit enter:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(186, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgArtists
            // 
            this.dgArtists.AllowUserToAddRows = false;
            this.dgArtists.AllowUserToDeleteRows = false;
            this.dgArtists.AutoGenerateColumns = false;
            this.dgArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn,
            this.bandURLDataGridViewTextBoxColumn,
            this.bandPictureURLDataGridViewTextBoxColumn});
            this.dgArtists.DataSource = this.tblArtistBindingSource;
            this.dgArtists.Location = new System.Drawing.Point(28, 55);
            this.dgArtists.Name = "dgArtists";
            this.dgArtists.ReadOnly = true;
            this.dgArtists.Size = new System.Drawing.Size(240, 427);
            this.dgArtists.TabIndex = 3;
            this.dgArtists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // ucTagSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgArtists);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchField);
            this.Name = "ucTagSearch";
            this.Size = new System.Drawing.Size(384, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblArtistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgArtists;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandPictureURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblArtistBindingSource;
    }
}
