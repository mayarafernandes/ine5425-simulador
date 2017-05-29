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
            
            for (int i=0; i < this.Steps; i++)
            {                
                int l = i + 1;
                double angleRad = uniform.GetRandomValue();
                x = (x + (l * Math.Cos(angleRad)));                
                y = (y + (l * Math.Sin(angleRad)));
                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                simulationResult.CoordinatesX.Add(x);
                simulationResult.CoordinatesY.Add(y);
                simulationResult.Distances.Add(distance);
            }

            return simulationResult;
        }
        #endregion

    }
}
