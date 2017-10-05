using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden3
{
    class Flower : Plant
    {
        public Flower(string color)
        {
            this.color = color;
            this.needWater = 5;
            this.absorbWater = 0.75;
            this.type = "flower";
        }       
    }
}
