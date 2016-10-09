using System.Collections.Generic;
using Zoolandia.AnimalsClass;
using Zoolandia.Habitats;

namespace Zoolandia.AmazonianRainforest

{

    public class AmazonianRainforestHabitat: Habitat
    {
        public List<Animal> AmazonianRainforestAnimals = new List<Animal>();

        public void addtoAmazonianRainforest(Animal animal)
        {
            AmazonianRainforestAnimals.Add(animal);
        }

        public string showAmazonianRainforestAnimals()
        {
            string output = "";

            foreach (Animal animal in AmazonianRainforestAnimals)
            {
                output += $"\n{animal.animalName} has joined the Amazonian Rainforest Habitat!";
            }

            return output;
        }
    }
}