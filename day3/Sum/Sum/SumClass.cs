using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    public class SumClass
    {
        public int Summy(List<int> numbers)
        {
            if (numbers == null)
            {
                return -1;
            }
            else
            {
                return numbers.Sum();
            }
        }
    }
}
