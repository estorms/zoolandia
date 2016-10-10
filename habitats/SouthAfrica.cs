using System.Collections.Generic;
using Zoolandia.AnimalsClass;
using Zoolandia.Habitats;

namespace Zoolandia.SouthAfrica

{

    public class SouthAfricanHabitat: Habitat
    {
        public List<Animal> SouthAfricanAnimals = new List<Animal>();
      public SouthAfricanHabitat(string name) {
            this.name = name;
        } 

    }
}