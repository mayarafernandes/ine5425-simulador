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

        public int UpperBound { get; set; }

        public int LowerBound { get; set; }
        #endregion

        #region Constructor
        public UniformDistribution(int lowerBound, int upperBound)
        {
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
            this.RandomBase = new Random((int)DateTime.Now.Ticks);
        }
        #endregion

        #region Get Value
        public int GetRandomValue()
        {
            //return (this.RandomBase.NextDouble() * (this.UpperBound - this.LowerBound) + this.LowerBound);
            return RandomBase.Next(this.LowerBound, this.UpperBound);
        }
        #endregion
    }
}
