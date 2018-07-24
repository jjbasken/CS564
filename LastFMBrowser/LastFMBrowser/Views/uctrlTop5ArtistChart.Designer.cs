namespace LastFMBrowser.Views
{
    partial class uctrlTop5ArtistChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtTop5Pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtTop5Pie)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtTop5Pie
            // 
            this.chrtTop5Pie.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chrtTop5Pie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtTop5Pie.Legends.Add(legend1);
            this.chrtTop5Pie.Location = new System.Drawing.Point(0, 0);
            this.chrtTop5Pie.Name = "chrtTop5Pie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtTop5Pie.Series.Add(series1);
            this.chrtTop5Pie.Size = new System.Drawing.Size(239, 160);
            this.chrtTop5Pie.TabIndex = 0;
            this.chrtTop5Pie.Text = "chart1";
            // 
            // uctrlTop5ArtistChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.chrtTop5Pie);
            this.Name = "uctrlTop5ArtistChart";
            this.Size = new System.Drawing.Size(240, 162);
            ((System.ComponentModel.ISupportInitialize)(this.chrtTop5Pie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtTop5Pie;
    }
}
