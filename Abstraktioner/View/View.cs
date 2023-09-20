using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.View
{
    internal class View
    {
        #region GUI

        /// <summary>
        /// GUI to Total Of Animals
        /// </summary>
        /// <param name="totalAnimal"></param>
        public void TotalAnimals(int totalAnimal)
        {
            Console.WriteLine($"Total amount of animal {totalAnimal}");
        }

        public void TotalDogs(int totalAnimal)
        {
            Console.WriteLine($"Total amount of Dogs {totalAnimal}");
        }

        public void TotalChickens(int totalAnimal)
        {
            Console.WriteLine($"Total amount of Chicken {totalAnimal}");
        }

        public void TotalRabbits(int totalAnimal)
        {
            Console.WriteLine($"Total amount of Rabbits {totalAnimal}");
        }



        /// <summary>
        /// Reads the line
        /// </summary>
        public void Read()
        {
            Console.ReadKey();
        }
        #endregion
    }
}
