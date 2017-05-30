using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSim
{
    class UniformDistribution
    {
        #region Properties
        private Random RandomBase { get; set; }

        public double UpperBound { get; set; }

        public double LowerBound { get; set; }
        #endregion

        #region Constructor
        public UniformDistribution(double lowerBound, double upperBound)
        {
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
            this.RandomBase = new Random();
        }
        #endregion

        #region Get Value
        public double GetRandomValue()
        {
            return (this.RandomBase.NextDouble() * (this.UpperBound - this.LowerBound) + this.LowerBound);
        }
        #endregion
    }
}
