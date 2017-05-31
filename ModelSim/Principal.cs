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
        private void RunSimulation(int steps, int repetitions)
        {
            Simulator sim = new Simulator(steps);
            SimulationResult simResult = sim.Run();
            if (repetitions == 0)
            {
                PlotChartPath(simResult, steps);
                PlotChartDistances(simResult, steps);
                labelDistanceWalkedResult.Text = Math.Truncate(simResult.DistanceFinal).ToString();
                labelDistanceEstimatedResult.Text = Math.Truncate(simResult.DistanceDiff).ToString();                
            }
            else
                PlotChartHistogram();
            
        }

        private void PlotChartPath(SimulationResult simResult, int steps)
        {
            ChartArea chartArea = new ChartArea("Path");
            chartArea.AxisX = new Axis()
            {
                Minimum = Math.Truncate(simResult.MinX) - 1,
                Maximum = Math.Truncate(simResult.MaxX) + 1,
                Interval = Math.Truncate((simResult.MaxX - simResult.MinX) / 5),
                IsStartedFromZero = false,
                MajorGrid = new Grid() { LineColor = Color.FromArgb(0x78b6b6b6) }
            };
            chartArea.AxisY = new Axis()
            {
                Minimum = Math.Truncate(simResult.MinY) - 1,
                Maximum = Math.Truncate(simResult.MaxY) + 1,
                Interval = Math.Truncate((simResult.MaxY - simResult.MinY) / 5),
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
                MarkerColor = Color.FromArgb(0x79000080),
                MarkerSize = 10,
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < steps; i++)
                series.Points.AddXY(simResult.CoordinatesX[i], simResult.CoordinatesY[i]);
            chartPath.Series.Add(series);
        }

        private void PlotChartDistances(SimulationResult simResult, int steps)
        {
            ChartArea chartArea = new ChartArea("Distance");
            chartArea.AxisX = new Axis()
            {
                Minimum = 0,
                Maximum = Math.Truncate(simResult.DistanceFinal),
                Interval = Math.Truncate((double)steps / 5),                
                MajorGrid = new Grid() { LineColor = Color.FromArgb(0x78b6b6b6) }
            };
            chartArea.AxisY = new Axis()
            {
                MajorGrid = new Grid() { LineColor = Color.FromArgb(0x78b6b6b6) }
            };
            chartDistance.ChartAreas.Add(chartArea);

            Series seriesDistances = new Series("Distâncias")
            {
                ChartArea = "Distance",
                Color = Color.Blue,
                BorderWidth = 3,
                ChartType = SeriesChartType.Line
            };

            Series seriesSquareRoot = new Series("Raiz n")
            {
                ChartArea = "Distance",
                Color = Color.Red,
                BorderWidth = 3,
                ChartType = SeriesChartType.Spline
            };

            double sumDistances = 0;
            seriesDistances.Points.AddXY(0, 0);
            seriesSquareRoot.Points.AddXY(0, 0);
            for (int i = 0; i < steps; i++)
            {
                sumDistances += simResult.Distances[i];
                double truncateX = Math.Truncate(sumDistances);
                seriesDistances.Points.AddXY(truncateX, simResult.Distances[i]);
                seriesSquareRoot.Points.AddXY(truncateX, Math.Sqrt(truncateX));
            }                
            chartDistance.Series.Add(seriesDistances);
            chartDistance.Series.Add(seriesSquareRoot);
        }

        private void PlotChartHistogram()
        {

        }

        private void ClearCharts()
        {
            this.chartPath.Titles.Clear();
            this.chartPath.Series.Clear();
            this.chartPath.ChartAreas.Clear();

            this.chartDistance.Titles.Clear();
            this.chartDistance.Series.Clear();
            this.chartDistance.ChartAreas.Clear();

            this.chartHistogram.Titles.Clear();
            this.chartHistogram.Series.Clear();
            this.chartHistogram.ChartAreas.Clear();
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
            int repetitions = 0;
            if (!string.IsNullOrEmpty(textBoxRepetitions.Text) && (!Int32.TryParse(textBoxRepetitions.Text, out repetitions) || repetitions < 1))
            {
                MessageBox.Show("Número de repetições inválido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ClearCharts();
            bool hasRepetition = (repetitions > 0);
            RunSimulation(steps, repetitions);
            panelDistanceResults.Visible = !hasRepetition;
            tabControlCharts.Visible = !hasRepetition;
            panelHistogram.Visible = hasRepetition;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSteps.Text = string.Empty;
            textBoxRepetitions.Text = string.Empty;
            panelDistanceResults.Visible = false;
            ClearCharts();
            textBoxSteps.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
