using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden3
{
    class Tree : Plant
    {
        public Tree(string color)
        {
            this.color = color;
            this.needWater = 10;
            this.absorbWater = 0.4;
            this.type = "tree";
        }
    }
}
