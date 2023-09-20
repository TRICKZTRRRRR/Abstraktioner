using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Model
{
    internal class AnimalList
    {
        #region List
        List<Dog> dogs { get; set; } = new List<Dog>(); // Creates a list of the dogs
        List<Chicken> chickens { get; set; } = new List<Chicken>(); // Creates a list of the chickens
        List<Rabbit> rabbits { get; set; } = new List<Rabbit>(); // Creates a list of the rabbits
        List<Animals> animals { get; set; } = new List<Animals>(); // Creates a list of the animals
        List<Animals> animalsAge { get; set; } = new List<Animals>(); // Creates a list of the animals age

        #endregion

        #region Methods

       /// <summary>
       /// Adds a dog to the list
       /// </summary>
       /// <param name="dog"></param>
        public void AddDog(Dog dog)
        {
            dogs.Add(dog);
            animals.Add(dog);
        }

        /// <summary>
        /// Adds a chicken to the list
        /// </summary>
        /// <param name="chicken"></param>
        public void AddChicken(Chicken chicken) 
        {
            chickens.Add(chicken);
            animals.Add(chicken);
        }    

        /// <summary>
        /// Adds a rabbit to the list
        /// </summary>
        /// <param name="rabbit"></param>
        public void AddRabbit(Rabbit rabbit)
        {
            rabbits.Add(rabbit);
            animals.Add(rabbit);
        }

        /// <summary>
        /// Gives the number of how many, theres is in the choosed list
        /// </summary>
        /// <param name="choose"></param>
        /// <returns></returns>
        public int TotalAmount(byte choose)
        {
            if (choose == 1) 
            {
                return Convert.ToInt32(dogs.Count);
            }
            else if (choose == 2)
            {
                return Convert.ToInt32(chickens.Count);
            }
            else if(choose == 3)
            {
                return Convert.ToInt32(rabbits.Count);
            }
            else 
            {
                return Convert.ToInt32(animals.Count);
            }
        }

        /// <summary>
        /// Makes the calculation of the animals age, and who over 15
        /// </summary>
        public void AnimalGone()
        {
            foreach (Animals animal in animals)
            {
                for(int i = 0; i < animals.Count; i++)
                {
                    if (animal.age >= 15)
                    {

                        animalsAge.Add(animal);
                    }
                }
            }
        }

        /// <summary>
        /// Counts how many animals there are over 15, and divides it with 9, so we get how many who over 15
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{animalsAge.Count/9}";
        }

        #endregion
    }
}
