using System.Collections.Generic;
using Zoolandia.AnimalsClass;
using Zoolandia.Habitats;

namespace Zoolandia.BorealForest

{

    public class BorealForestHabitat: Habitat
    {
        public List<Animal> BorealForestAnimals = new List<Animal>();
     public BorealForestHabitat(string name) {
            this.name = name;
        }  

    }
}