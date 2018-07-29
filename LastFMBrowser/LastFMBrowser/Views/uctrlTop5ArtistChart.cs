using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LastFMBrowser.Models;
using LastFMBrowser.Tools;

namespace LastFMBrowser.Views
{
    public partial class uctrlTop5ArtistChart : UserControl
    {
        /*************************
         * Member Fields  and Properties
         *************************/

        //Static representation of the chart
        private static Chart mChart { get; set; }
        private static frmMain mParent { get; set; }

        private List<Tuple<string, int?>> SQLList { get; set; }
        /*************************
         * Constructors
         *************************/

        public uctrlTop5ArtistChart(List<Tuple<string, int?>> sqlList)
        {
            InitializeComponent();
            InitUC(sqlList);
            RenderChart();
        }

        /*************************
         * Form Initialization
         *************************/

        private void InitUC(List<Tuple<string, int?>> sqlList)
        {
            mParent = (frmMain) this.Parent;
            SQLList = sqlList;
            //mParent = (Workbench) this.Parent.Parent;
            mChart = chrtTop5Pie;
        }
        /*************************
         * Private Helper Functions
         *************************/

            /// <summary>
            ///     Build the pie chart via sub functions
            /// </summary>
            /// <param name="CallSuccess"></param>
            /// <param name="CallFailure"></param>
        private void RenderChart ()
        {
            PaintChart();
            BuildGraph();
        }

        /// <summary>
        ///     Set chart details
        /// </summary>
        private void PaintChart()
        {
            //Chart General Color Rendering
            mChart.Palette = ChartColorPalette.None;
            mChart.PaletteCustomColors = new Color[] { Color.FromArgb(255, 90,9,0),
                                                            Color.FromArgb(255, 108,41,41),
                                                            Color.FromArgb(255, 173,86,86),
                                                            Color.FromArgb(255, 203,179,160),
                                                            Color.FromArgb(255, 255,235,217)};
            mChart.ChartAreas["ChartArea1"].BorderColor = Color.DarkOrange;
            mChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            mChart.Legends["Legend1"].BackColor = Color.Transparent;
        }


        


        /// <summary>
        ///     Pie chart showing top 5 of query
        /// </summary>
        private void BuildGraph ()
        {
            //Set up series
            mChart.Series.Clear();
            mChart.Series.Add("Series1");
            mChart.Series["Series1"].ChartArea = "ChartArea1";
            mChart.Series["Series1"].ChartType = SeriesChartType.Pie;
            //mChart.Series["Series1"]["PieLabelStyle"] = "Outside";
            //mChart.Series["Series1"]["LabelStyle"] = "Center";
            //mChart.Series["Series1"].Font = new System.Drawing.Font("Arial", 12);
            
 

            //mChart.Titles.Add("Your Top 5 Played Artists");
            //mChart.BorderlineColor = Color.FromArgb(255, 108, 41, 41);

            int i = 0;
            foreach (Tuple<string, int?> dataPoint in SQLList)
            {
                mChart.Series["Series1"].Points.AddXY(dataPoint.Item2 + "", (double) dataPoint.Item2);
                mChart.Series["Series1"].Points[i].LegendText = dataPoint.Item1;

                i++;
            }
            /*NOTE: I need to bring in a list containing a small class with user name and 

            /*
             * 
             * 
             * 
             */
            ////Success Points
            //mChart.Series["Series1"].Points.AddXY("Succeeded", CallSuccess);
            //mChart.Series["Series1"].Points[0].AxisLabel = "Success\n" + CallSuccess.ToString();

            ////Failure Points
            //mChart.Series["Series1"].Points.AddXY("Failed", CallFailure);
            //mChart.Series["Series1"].Points[1].AxisLabel = "Failed\n" + CallFailure.ToString();
            //mChart.Series["Series1"].Points[1].LabelForeColor = Color.Orange;
        }

        private void chrtTop5Pie_Click(object sender, EventArgs e)
        {

        }

        private void uctrlTop5ArtistChart_Load(object sender, EventArgs e)
        {

        }
    }
}
