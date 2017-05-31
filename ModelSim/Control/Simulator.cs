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
            List<double> distancesDiffs = new List<double>();
            SimulationResult simulationResult = new SimulationResult();
            List<SimulationResult> repetitionsResults = new List<SimulationResult>();
            for (int i = 0; i < repetitions; i++)
                repetitionsResults.Add(Run());
            foreach (SimulationResult simResult in repetitionsResults)
                distancesDiffs.Add(simResult.DistanceDiff);
            distancesDiffs.Sort();

            int classesCount = Int32.Parse(Math.Truncate(Math.Sqrt(repetitions)).ToString());
            if (classesCount > 30)
                classesCount = 30;
            double classValue = (distancesDiffs[distancesDiffs.Count - 1] / classesCount);
            Dictionary<double, int> classesFrequencies = new Dictionary<double, int>();
            for (int i = 1; i <= classesCount; i++)
                classesFrequencies.Add((i * classValue), 0);
            foreach (double distanceDiff in distancesDiffs)
            {
                for (int i = 1; i <= classesCount; i++)
                {
                    if (i == 1)
                    {
                        if (distanceDiff > 0 && distanceDiff <= classValue)
                            classesFrequencies[classValue] += 1;
                    }
                    else
                    {
                        double lower = (i - 1) * classValue;
                        double upper = i * classValue;
                        if ((distanceDiff > lower) && (distanceDiff <= upper))
                            classesFrequencies[upper] += 1;
                    }
                }
            }
            foreach (KeyValuePair<double, int> classFrequency in classesFrequencies)
            {
                simulationResult.CoordinatesX.Add(classFrequency.Key);
                simulationResult.CoordinatesY.Add(Math.Truncate((double)(100 * (classFrequency.Value)) / repetitions));
            }

            return simulationResult;
        }
        #endregion

    }
}
