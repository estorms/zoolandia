using System.Collections.Generic;
using Zoolandia.AnimalsClass;
using Zoolandia.Habitats;

namespace Zoolandia.BorealForest

{

    public class BorealForestHabitat: Habitat
    {
        public List<Animal> BorealForestAnimals = new List<Animal>();

        public void addToBorealForest(Animal animal)
        {
            BorealForestAnimals.Add(animal);
        }

        public string showBorealForestAnimals()
        {
            string output = "";

            foreach (Animal animal in BorealForestAnimals)
            {
                output += $"\n{animal.animalName} has joined the Boreal Forest Habitat!";
            }

            return output;
        }
    }
}