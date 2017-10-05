using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden3
{
    class Program
    {
        static void Main(string[] args)
        {
            var garden = new Garden();
            var flower = new Flower("yellow");
            var flower2 = new Flower("blue");
            var tree = new Tree("purple");
            var tree2 = new Tree("orange");
            garden.plants.Add(flower);
            garden.plants.Add(tree);
            garden.plants.Add(flower2);
            garden.plants.Add(tree2);

            garden.StateOfGarden();
            Console.WriteLine();
            garden.Watering(40);
            Console.WriteLine();
            garden.StateOfGarden();
            Console.WriteLine();
            garden.Watering(70);
            Console.WriteLine();
            garden.StateOfGarden();
            Console.ReadLine();
        }
    }
}
