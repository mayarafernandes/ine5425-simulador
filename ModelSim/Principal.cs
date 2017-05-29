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

            Series series = this.chartPath.Series.Add("Caminho Percorrido");

            series.MarkerStyle = MarkerStyle.Diamond;
            series.MarkerColor = Color.Blue;

            series.ChartType = SeriesChartType.Line;
            for (int i = 0; i < 10; i++)
                series.Points.AddXY(simResult.CoordinatesX[i], simResult.CoordinatesY[i]);
        }

        private void ClearCharts()
        {
            this.chartPath.Titles.Clear();
            this.chartDistance.Titles.Clear();
            this.chartPath.Series.Clear();
            this.chartDistance.Series.Clear();
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

            RunSimulation(steps);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
