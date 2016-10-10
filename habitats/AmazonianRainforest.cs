using System.Collections.Generic;
using Zoolandia.AnimalsClass;
using Zoolandia.Habitats;

namespace Zoolandia.AmazonianRainforest

{
    public class AmazonianRainforestHabitat: Habitat
    {
        public List<Animal> AmazonianRainforestAnimals = new List<Animal>();

        public AmazonianRainforestHabitat(string name) {
            this.name = name;
        }

    }

}