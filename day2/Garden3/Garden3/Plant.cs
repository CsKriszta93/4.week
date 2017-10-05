using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden3
{
    class Plant
    {
        public string color;
        public double currentWaterAmount;
        public double needWater;
        public double absorbWater;
        public string type;

        public bool IsThirsty()
        {
            return currentWaterAmount < needWater;
        }
    }
}
