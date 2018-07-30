namespace LastFMBrowser.Views
{
    partial class frmSelectTag
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
            this.lstSelect = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblArtistListHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSelect
            // 
            this.lstSelect.FormattingEnabled = true;
            this.lstSelect.Location = new System.Drawing.Point(12, 36);
            this.lstSelect.Name = "lstSelect";
            this.lstSelect.Size = new System.Drawing.Size(277, 303);
            this.lstSelect.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(84, 349);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Tags";
            // 
            // lblArtistListHeader
            // 
            this.lblArtistListHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblArtistListHeader.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistListHeader.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblArtistListHeader.Location = new System.Drawing.Point(9, 9);
            this.lblArtistListHeader.Name = "lblArtistListHeader";
            this.lblArtistListHeader.Size = new System.Drawing.Size(69, 24);
            this.lblArtistListHeader.TabIndex = 17;
            this.lblArtistListHeader.Text = "Tags ";
            this.lblArtistListHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(123, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "(Double click to select)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSelectTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(305, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArtistListHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstSelect);
            this.Name = "frmSelectTag";
            this.Text = "Select A Tag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSelect;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArtistListHeader;
        private System.Windows.Forms.Label label1;
    }
}