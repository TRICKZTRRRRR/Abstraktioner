using Abstraktioner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktioner.Controller
{
    internal class Controller
    {
        View.View view = new View.View();

        

        #region Main Controller
        public void MainController()
        {
            InsertData();
            view.Read();
            ShowAnimalCount();
        }
        #endregion

        #region Insert Data
        public void InsertData()
        {
            // Make a new list of animals, with the data below
            Model.AnimalList animals = new Model.AnimalList();

            // Data of the chickens
            Model.Chicken chicken1 = new Model.Chicken(true, false, false, true, true, true, false, 12, "Eat whatever you give it sometimes", "John wick", "white");
            Model.Chicken chicken2 = new Model.Chicken(true, false, false, true, true, true, false, 29, "Eat whatever you give it sometimes", "John wick", "white");
            Model.Chicken chicken3 = new Model.Chicken(true, false, false, true, true, true, false, 18, "Eat whatever you give it sometimes", "John wick", "white");

            // Adds the chickens to the list
            animals.AddChicken(chicken1);
            animals.AddChicken(chicken2);
            animals.AddChicken(chicken3);

            // Data of the rabbits
            Model.Rabbit rabbit1 = new Model.Rabbit(true, false, false, true, true, true, false, 20, "Eat whatever you give it sometimes", "John wick", 10);
            Model.Rabbit rabbit2 = new Model.Rabbit(true, false, false, true, true, true, false, 10, "Eat whatever you give it sometimes", "John wick", 25);
            Model.Rabbit rabbit3 = new Model.Rabbit(true, false, false, true, true, true, false, 9, "Eat whatever you give it sometimes", "John wick", 39);

            // Adds the rabbits to the list
            animals.AddRabbit(rabbit1);
            animals.AddRabbit(rabbit2);
            animals.AddRabbit(rabbit3);

            // Data of the dogs
            Model.Dog dog1 = new Model.Dog(false, true, true, false, true, false, false, 12, "Bones", "Jackie Chan", 10, true);
            Model.Dog dog2 = new Model.Dog(false, true, true, false, true, false, false, 31,  "Bones", "Jackie Chan", 7, true);
            Model.Dog dog3 = new Model.Dog(false, true, true, false, true, false, false, 7, "Bones", "Jackie Chan", 12, true);

            // Adds the dogs to the list
            animals.AddDog(dog1);
            animals.AddDog(dog2);
            animals.AddDog(dog3);

            // Shows how many animals, there is over 15
            animals.AnimalGone();

            // Writes the list, to the CMD / Application
            Console.WriteLine(animals.ToString());
        }
        #endregion

        #region Check Total Amount
        
        void ShowAnimalCount()
        {
            Model.AnimalList animals = new Model.AnimalList();

            string input = Console.ReadLine();

            if (int.TryParse(input, out int getUserInput))
            {
                switch (getUserInput)
                {
                    case 1:
                        int dogs = animals.TotalAmount(1);
                        view.TotalDogs(dogs);
                        break;

                    case 2:
                        int chickens = animals.TotalAmount(2);
                        view.TotalChickens(chickens);
                        break;

                    case 3:
                        int rabbits = animals.TotalAmount(3);
                        view.TotalRabbits(rabbits);
                        break;

                    case 4:
                        int animal = animals.TotalAmount(4);
                        view.TotalAnimals(animal);
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            Console.ReadLine();
        }

        #endregion
    }
}