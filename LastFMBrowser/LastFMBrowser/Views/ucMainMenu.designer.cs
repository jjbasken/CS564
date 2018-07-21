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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitMenu = new System.Windows.Forms.SplitContainer();
            this.btnUCMax = new System.Windows.Forms.Button();
            this.lblUCStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitMenu)).BeginInit();
            this.splitMenu.Panel1.SuspendLayout();
            this.splitMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitMenu
            // 
            this.splitMenu.Location = new System.Drawing.Point(0, 0);
            this.splitMenu.Name = "splitMenu";
            this.splitMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMenu.Panel1
            // 
            this.splitMenu.Panel1.Controls.Add(this.btnUCMax);
            this.splitMenu.Panel1.Controls.Add(this.lblUCStatus);
            // 
            // splitMenu.Panel2
            // 
            this.splitMenu.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitMenu.Panel2.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.splitMenu.Size = new System.Drawing.Size(161, 65);
            this.splitMenu.SplitterDistance = 25;
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
            this.btnUCMax.Location = new System.Drawing.Point(133, 0);
            this.btnUCMax.Name = "btnUCMax";
            this.btnUCMax.Size = new System.Drawing.Size(28, 30);
            this.btnUCMax.TabIndex = 88;
            this.btnUCMax.Text = "V";
            this.btnUCMax.UseVisualStyleBackColor = false;
            this.btnUCMax.Click += new System.EventHandler(this.btnUCMax_Click);
            // 
            // lblUCStatus
            // 
            this.lblUCStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblUCStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUCStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUCStatus.ForeColor = System.Drawing.Color.LightYellow;
            this.lblUCStatus.Location = new System.Drawing.Point(0, 0);
            this.lblUCStatus.Name = "lblUCStatus";
            this.lblUCStatus.Size = new System.Drawing.Size(131, 30);
            this.lblUCStatus.TabIndex = 87;
            this.lblUCStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUCStatus.DoubleClick += new System.EventHandler(this.lblUCStatus_DoubleClick);
            // 
            // ucMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitMenu);
            this.Name = "ucMainMenu";
            this.Size = new System.Drawing.Size(164, 68);
            this.splitMenu.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMenu)).EndInit();
            this.splitMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SplitContainer splitMenu;
        private System.Windows.Forms.Button btnUCMax;
        private System.Windows.Forms.Label lblUCStatus;
    }
}
