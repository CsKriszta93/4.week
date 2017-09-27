using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple
{
    public class Apple
    {
        public string apple;
        public void GetApple(string apple)
        {
            this.apple = apple;
        }

        public string Printapple()
        {
            apple = "apple";
            Console.WriteLine(apple);
            return apple;
        }
    }
}
