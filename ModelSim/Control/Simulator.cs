using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSim
{
    class Simulator
    {
        #region Properties
        public int Steps { get; set; }

        public int Repetitions { get; set; }
        #endregion

        #region Constructor
        public Simulator(int steps)
        {
            this.Steps = steps;
        }
        #endregion

        #region Simulation
        public SimulationResult Run()
        {
            UniformDistribution uniform = new UniformDistribution(0, (2 * Math.PI));
            SimulationResult simulationResult = new SimulationResult();
            double x = 0;
            double y = 0;

            simulationResult.DistanceFinal = 0;
            for (int i=0; i < this.Steps; i++)
            {
                int l = 1;
                double angleRad = uniform.GetRandomValue();
                x = (x + (l * Math.Cos(angleRad)));                
                y = (y + (l * Math.Sin(angleRad)));
                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (i == 0)
                {
                    simulationResult.MinX = simulationResult.MaxX = x;
                    simulationResult.MinY = simulationResult.MaxY = y;
                }
                else
                {
                    simulationResult.MinX = (x < simulationResult.MinX) ? x : simulationResult.MinX;
                    simulationResult.MaxX = (x > simulationResult.MaxX) ? x : simulationResult.MaxX;
                    simulationResult.MinY = (y < simulationResult.MinY) ? y : simulationResult.MinY;
                    simulationResult.MaxY = (y > simulationResult.MaxY) ? y : simulationResult.MaxY;
                }                
                simulationResult.CoordinatesX.Add(x);
                simulationResult.CoordinatesY.Add(y);
                simulationResult.Distances.Add(distance);
                simulationResult.DistanceFinal += distance;
            }
            simulationResult.DistanceDiff = Math.Abs((Steps * Math.Sqrt(Steps)) - simulationResult.DistanceFinal);
            return simulationResult;
        }

        public SimulationResult Run(int repetitions)
        {
            SimulationResult simulationResult = new SimulationResult();
            List<SimulationResult> repetitionsResults = new List<SimulationResult>();
            for (int i = 0; i < repetitions; i++)
                repetitionsResults.Add(Run());

            return simulationResult;
        }
        #endregion

    }
}
