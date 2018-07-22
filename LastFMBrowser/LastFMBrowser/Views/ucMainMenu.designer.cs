namespace AppEmaMonitor.Tools
{
    partial class ucMainMenu
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
            this.splitMenu = new System.Windows.Forms.SplitContainer();
            this.btnUCMax = new System.Windows.Forms.Button();
            this.btnUCMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenu)).BeginInit();
            this.splitMenu.Panel1.SuspendLayout();
            this.splitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMenu
            // 
            this.splitMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.splitMenu.Location = new System.Drawing.Point(0, 0);
            this.splitMenu.Name = "splitMenu";
            // 
            // splitMenu.Panel1
            // 
            this.splitMenu.Panel1.Controls.Add(this.btnUCMin);
            this.splitMenu.Panel1.Controls.Add(this.btnUCMax);
            this.splitMenu.Panel1MinSize = 18;
            // 
            // splitMenu.Panel2
            // 
            this.splitMenu.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitMenu.Panel2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.splitMenu.Panel2MinSize = 18;
            this.splitMenu.Size = new System.Drawing.Size(217, 30);
            this.splitMenu.SplitterDistance = 25;
            this.splitMenu.SplitterWidth = 2;
            this.splitMenu.TabIndex = 1;
            // 
            // btnUCMax
            // 
            this.btnUCMax.BackColor = System.Drawing.Color.Transparent;
            this.btnUCMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUCMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnUCMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUCMax.Location = new System.Drawing.Point(0, 0);
            this.btnUCMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnUCMax.Name = "btnUCMax";
            this.btnUCMax.Size = new System.Drawing.Size(18, 27);
            this.btnUCMax.TabIndex = 88;
            this.btnUCMax.Text = ">";
            this.btnUCMax.UseVisualStyleBackColor = false;
            this.btnUCMax.Click += new System.EventHandler(this.btnUCMax_Click);
            // 
            // btnUCMin
            // 
            this.btnUCMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(138)))), ((int)(((byte)(160)))));
            this.btnUCMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUCMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnUCMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUCMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUCMin.Location = new System.Drawing.Point(0, 0);
            this.btnUCMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnUCMin.Name = "btnUCMin";
            this.btnUCMin.Size = new System.Drawing.Size(18, 27);
            this.btnUCMin.TabIndex = 89;
            this.btnUCMin.Text = "<";
            this.btnUCMin.UseVisualStyleBackColor = false;
            this.btnUCMin.Click += new System.EventHandler(this.btnUCMin_Click);
            // 
            // ucMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitMenu);
            this.Name = "ucMainMenu";
            this.Size = new System.Drawing.Size(219, 33);
            this.splitMenu.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMenu)).EndInit();
            this.splitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitMenu;
        private System.Windows.Forms.Button btnUCMax;
        private System.Windows.Forms.Button btnUCMin;
    }
}
