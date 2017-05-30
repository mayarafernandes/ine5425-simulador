using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSim
{
    class SimulationResult
    {
        public List<double> CoordinatesX { get; set; }

        public List<double> CoordinatesY { get; set; }

        public List<double> Distances { get; set; }

        public double MinX { get; set; }

        public double MaxX { get; set; }

        public double MinY { get; set; }

        public double MaxY { get; set; }

        public SimulationResult()
        {
            this.CoordinatesX = new List<double>();
            this.CoordinatesY = new List<double>();
            this.Distances = new List<double>();
            this.MinX = 0;
            this.MaxX = 0;
            this.MinY = 0;
            this.MaxY = 0;
        }
    }
}
