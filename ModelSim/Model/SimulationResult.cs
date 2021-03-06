﻿using System;
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

        public double DistanceFinal { get; set; }

        public double DistanceDiff { get; set; }

        public SimulationResult()
        {
            this.CoordinatesX = new List<double>();
            this.CoordinatesY = new List<double>();
            this.Distances = new List<double>();            
        }
    }
}
