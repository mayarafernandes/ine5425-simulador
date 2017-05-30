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
        #region Constructor
        public Principal()
        {
            InitializeComponent();
            ClearCharts();
        }
        #endregion

        #region Charts
        private void RunSimulation(int steps)
        {
            Simulator sim = new Simulator(steps);
            SimulationResult simResult = sim.Run();
            PlotChartPath(simResult, steps);
            PlotChartDistances(simResult, steps);
        }

        private void PlotChartPath(SimulationResult simResult, int steps)
        {
            ChartArea chartArea = new ChartArea("Path");
            chartArea.AxisX = new Axis()
            {
                //Minimum = Math.Truncate(simResult.MinX) - 1,
                //Maximum = Math.Truncate(simResult.MaxX) + 1,                
                //Interval = Math.Truncate((simResult.MaxX - simResult.MinX) / 5),
                IsStartedFromZero = false,
                MajorGrid = new Grid() { LineColor = Color.FromArgb(0x78b6b6b6) }
            };
            chartArea.AxisY = new Axis()
            {
                //Minimum = Math.Truncate(simResult.MinY) - 1,
                //Maximum = Math.Truncate(simResult.MaxY) + 1,                
                //Interval = Math.Truncate((simResult.MaxY - simResult.MinY) / 5),
                IsStartedFromZero = false,
                MajorGrid = new Grid() { LineColor = Color.FromArgb(0x78b6b6b6) }
            };
            chartPath.ChartAreas.Add(chartArea);

            Series series = new Series()
            {
                ChartArea = "Path",
                Color = Color.FromArgb(0x78CCCC00),
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Diamond,
                MarkerColor = Color.FromArgb(0x784169E1),
                MarkerSize = 10,
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < steps; i++)
                series.Points.AddXY(simResult.CoordinatesX[i], simResult.CoordinatesY[i]);
            chartPath.Series.Add(series);
        }

        private void PlotChartDistances(SimulationResult simResult, int steps)
        {

        }

        private void ClearCharts()
        {
            this.chartPath.Titles.Clear();
            this.chartDistance.Titles.Clear();
            this.chartPath.Series.Clear();
            this.chartDistance.Series.Clear();
            this.chartPath.ChartAreas.Clear();
            this.chartDistance.ChartAreas.Clear();
        }
        #endregion

        #region Events
        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSteps.Text))
            {
                MessageBox.Show("Insira o número de passos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int steps = 0;
            if (!Int32.TryParse(textBoxSteps.Text, out steps) || steps <= 0)
            {
                MessageBox.Show("Número de passos inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClearCharts();
            RunSimulation(steps);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
