using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ModelSim
{
    public partial class Principal : Form
    {
        public int ChartType { get; set; }

        public Principal()
        {
            InitializeComponent();
            this.ChartType = 3;
            this.DrawChart();
        }

        private void buttonCreateChart_Click(object sender, EventArgs e)
        {
            this.DrawChart();
        }

        private void DrawChart()
        {
            this.chart.Titles.Clear();
            this.chart.Series.Clear();

            if (this.ChartType == 1)
            {
                // Data arrays
                string[] seriesArray = { "Cat", "Dog", "Bird", "Monkey" };
                int[] pointsArray = { 2, 1, 7, 5 };

                // Set palette
                this.chart.Palette = ChartColorPalette.EarthTones;

                // Set title            
                this.chart.Titles.Add("Animals");

                // Add series.
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    Series series = this.chart.Series.Add(seriesArray[i]);
                    series.Points.Add(pointsArray[i]);
                }
                this.ChartType = 2;
            }
            else if (this.ChartType == 2)
            {
                this.chart.Titles.Add("Total Income");

                Series series = this.chart.Series.Add("Total Income");
                series.ChartType = SeriesChartType.Spline;
                series.Points.AddXY("September", 100);
                series.Points.AddXY("Obtober", 300);
                series.Points.AddXY("November", 800);
                series.Points.AddXY("December", 200);
                series.Points.AddXY("January", 600);
                series.Points.AddXY("February", 400);

                this.ChartType = 3;
            }
            else if (this.ChartType == 3)
            {
                this.chart.Titles.Add("Total Income");               

                Series series = this.chart.Series.Add("Total Income");

                series.ChartType = SeriesChartType.Line;
                for (int i = -5; i < 6; i++)
                    series.Points.AddXY(i, i - 2);

                series = this.chart.Series.Add("Total Income 2");

                series.MarkerStyle = MarkerStyle.Diamond;
                series.MarkerColor = Color.Blue;
                
                series.ChartType = SeriesChartType.Line;
                for (int i = -5; i < 6; i++)
                    series.Points.AddXY(i, i - 4);
            }

        }
    }
}
