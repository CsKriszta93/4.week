using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden3
{
    class Garden
    {
        public List<Plant> plants = new List<Plant>();

        public void StateOfGarden()
        {
            foreach (var plant in plants)
            {
                string thirsty = "";
                if (plant.IsThirsty())
                {
                    thirsty = "needs water";
                }
                else
                {
                    thirsty = "doesn't need water";
                }

                Console.WriteLine("The {0} {1} {2}.", plant.color, plant.type, thirsty);
            }           
        }

        public void Watering(int amount)
        {
            Console.WriteLine("Watering with " + amount);
            int counter = 0;
            foreach (Plant plant in plants)
            {
                if (plant.IsThirsty())
                {
                    counter++;
                }
            }
            double waterPerPlant = amount / counter;
            foreach (Plant plant in plants)
            {
                plant.currentWaterAmount += waterPerPlant * plant.absorbWater;
            }         
        }
    }
}
