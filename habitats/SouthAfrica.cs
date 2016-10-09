using System.Collections.Generic;
using Zoolandia.AnimalsClass;
using Zoolandia.Habitats;

namespace Zoolandia.SouthAfrica

{

    public class SouthAfricanHabitat: Habitat
    {
        public List<Animal> SouthAfricanAnimals = new List<Animal>();

        public void addToSouthAfricanHabitat(Animal animal)
        {
            SouthAfricanAnimals.Add(animal);
        }

        public string showSouthAfricanAnimals()
        {
            string output = "";

            foreach (Animal animal in SouthAfricanAnimals)
            {
                output += $"\n{animal.animalName} has joined the South African Habitat!";
            }

            return output;
        }
    }
}